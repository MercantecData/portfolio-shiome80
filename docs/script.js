//Hides Obiwan
function hideFunc() {
    var x = document.getElementById("obiwan");
    if (x.style.display === "block") {
        x.style.display = "none";
    } else {
        x.style.display = "block";
    }
}

//Changes form to only single string
function changeText() {
    document.getElementById("form2").innerHTML = "ALL MALE";
}

//Removes form 2
function removeSomething() {
    document.getElementById("form2").remove();
}

//Changes background color on <div> button
function myOwnFunction (button) {
    button.style.backgroundColor = "white" ;
}

//Adds a new paragraph with content from custom form
function addP() {
    var firstname = document.getElementById("customFirst").value;
    var lastname = document.getElementById("customLast").value;
    var fullname = firstname + " " + lastname;
    var newP = "<p>" + fullname + "</p>";
    document.getElementById("blankSpace").insertAdjacentHTML("afterbegin", newP);
}

//Just for flavor - Clears guestbook writings
function clearPrint() {
    document.getElementById("blankSpace").innerHTML = "";
}




//Old solution to print guestbook assignment
//
/*
function printContent() {
    var firstname = document.getElementById("customFirst").value;
    var lastname = document.getElementById("customLast").value;
    var fullname = firstname + " " + lastname;

    document.getElementById("blankSpace").innerHTML += fullname + "<br>";
}
*/

//Solution to another student problem
/*
function buttonClicked(){
    const x = document.getElementById("fullname");
    x.style.fontFamily = "Courier new";
    console.log(x.style.fontFamily);
}
*/