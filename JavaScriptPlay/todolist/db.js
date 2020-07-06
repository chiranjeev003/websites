var request = window.indexedDB.open("MyTestDatabase", 2);

request.onupgradeneeded = function(event) { 
    // Save the IDBDatabase interface 
    var db = event.target.result;
  
    // Create an objectStore for this database
    var objectStore = db.createObjectStore("name", { keyPath: "myKey" });
  };