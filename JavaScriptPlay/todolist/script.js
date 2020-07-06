// a new array is declared
var listItem = new Array();

var list = document.getElementById("list");//the ul is stored in a object named list.

// is used to save the list in the array.
function onSaveClick() {
    var item = document.getElementById("todo");//the item form the textbox is taken.
    if (item.value != "") {//if the item value is not null the populateSpellList is called.
        listItem.push(item.value);//item is pushed into the array.
        populateSpellList();
    }
    item.value = "";//textbox is reset to empty.
}

// it creates a new div list to show it in the html page.
let indexI = 0;
let Count = 0;
function populateSpellList() {
    newItem = document.createElement("li");
    newItemValue = document.createTextNode(listItem[0]);//creates an html node so that DOM operations can be done.
    newItem.appendChild(newItemValue);//appends the values to the li element.

    list.insertBefore(newItem, list.firstChild)//inserts into the first element.

    newItem.id = "li" + indexI;
    var checkbox = document.createElement("input");
    checkbox.type = "checkbox";
    checkbox.className = "checkbox";
    checkbox.id = indexI;//creates a checkbox with an id so that operations can be performed on it.
    checkbox.setAttribute("onClick", "deleteItem(this.id)");
    newItem.appendChild(checkbox);//inserts the checkbox in the li.
    listItem = [];
    indexI++;
    Count++;
}

var deleteList = new Array();

function deleteItem(id) {

    var checkbox = document.getElementById(id);
    
    if(checkbox.checked == true){
        deleteList.push(id);
    }
    else{

        for( var i = 0; i < deleteList.length; i++){ 
            if ( deleteList[i] === id) {
              deleteList.splice(i, 1); 
            }
         }
    }

    var x = document.getElementById("DeleteAll");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        if (deleteList.length < 1) {
            x.style.display = "none";
        }
    }
}

function deleteButton() {
    for (var i = 0; i < deleteList.length; i++) {
        var id = deleteList[i];
        let mI = document.getElementById("li" + id);//selects the li node.
        mI.remove();//removes the li node.
    }
    deleteList = [];
    var checkbox = document.getElementsByClassName('checkbox');
    Count = checkbox.length;
    var x = document.getElementById("DeleteAll");
    x.style.display = "none";
}
