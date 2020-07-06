let db;
let dbReq = indexedDB.open("myDatabase", 2);
var god = "God is great123";
var godSelect = document.getElementById("godPrint");
godSelect.innerHTML = god;
dbReq.onupgradeneeded = function(event) {
  debugger;
  db = event.target.result;

  // Create the notes object store, or retrieve that store if it
  // already exists.
  let notes;
  if (!db.objectStoreNames.contains("notes")) {
    notes = db.createObjectStore("notes", { autoIncrement: true });
  } else {
    notes = dbReq.transaction.objectStore("notes");
  }

  // If there isn't already a timestamp index in our notes object
  // store, make one so we can query notes by their timestamps
  if (!notes.indexNames.contains("timestamp")) {
    notes.createIndex("timestamp", "timestamp");
  }
};
dbReq.onsuccess = function(event) {
  debugger;
  db = event.target.result;

  getAndDisplayNotes(db);
  // Add some sticky notes
  // addStickyNote(db, 'Sloths are awesome!');
  // addStickyNote(db, 'Order more hibiscus tea');
  // addStickyNote(db, 'And Green Sheen shampoo, the best for sloth fur algae grooming!');
};

dbReq.onerror = function(event) {
  alert("error opening database " + event.target.errorCode);
};

function addStickyNote(db, message) {
  // Start a database transaction and get the notes object store
  let tx = db.transaction(["notes"], "readwrite");
  let store = tx.objectStore("notes");

  // Put the sticky note into the object store
  let note = { text: message, timestamp: Date.now() };
  store.add(note);

  // Wait for the database transaction to complete
  tx.oncomplete = function() {
    //alert("Transaction completed");
    getAndDisplayNotes(db);
  };
  tx.onerror = function(event) {
    alert("error storing note " + event.target.errorCode);
  };
}

function submitNote() {
  let message = document.getElementById("newmessage");
  addStickyNote(db, message.value);
  message.value = "";
}

function addManyNotes(db, messages) {
  let tx = db.transaction(["notes"], "readwrite");
  let store = tx.objectStore("notes");

  for (let i = 0; i < messages.length; i++) {
    // All of the requests made from store.add are part of
    // the same transaction
    store.add({ text: messages[i], timestamp: Date.now() });
  }

  // When all of these requests complete, the transaction's oncomplete
  // event fires
  tx.oncomplete = function() {
    console.log("transaction complete");
  };
}

function getAndDisplayNotes(db) {
  let tx = db.transaction(["notes"], "readonly");
  let store = tx.objectStore("notes");

  // Retrieve the sticky notes index to run our cursor query on;
  // the results will be ordered by their timestamp
  let index = store.index("timestamp");

  // Create our openCursor request, on the index rather than the main
  // notes object store. If we're going in reverse, then specify the
  // direction as "prev". Otherwise, we specify it as "next".
  //let req = index.openCursor(null, reverseOrder ? 'prev' : 'next');

  // Create a cursor request to get all items in the store, which
  // we collect in the allNotes array
  let anHourAgoInMilliseconds = Date.now() - 60 * 60 * 1000;

  // IDBKeyRange is a global variable for defining ranges to query
  // indices on
  let keyRange = IDBKeyRange.lowerBound(anHourAgoInMilliseconds);
  let req = index.openCursor(keyRange, "next");
  let allNotes = [];

  req.onsuccess = function(event) {
    // The result of req.onsuccess in openCursor requests is an
    // IDBCursor
    let cursor = event.target.result;

    if (cursor != null) {
      // If the cursor isn't null, we got an item. Add it to the
      // the note array and have the cursor continue!
      allNotes.push(cursor.value);
      cursor.continue();
    } else {
      // If we have a null cursor, it means we've gotten
      // all the items in the store, so display the notes we got.
      displayNotes(allNotes);
    }
  };

  req.onerror = function(event) {
    alert("error in cursor request " + event.target.errorCode);
  };
}

function displayNotes(notes) {
  let listHTML = "<ul>";
  for (let i = 0; i < notes.length; i++) {
    let note = notes[i];
    listHTML +=
      "<li>" + note.text + " " + new Date(note.timestamp).toString() + "</li>";
  }

  document.getElementById("notes").innerHTML = listHTML;
}

function flipNoteOrder(notes) {
  reverseOrder = !reverseOrder;
  getAndDisplayNotes(db);
}
