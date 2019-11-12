function buttonClicked(){
    //console.log("Click!");
    document.getElementById("button").innerHTML = "Clicked";
}

function hideFunc() {
    var x = document.getElementById("obiwan");
    if (x.style.display === "block") {
        x.style.display = "none";
    } else {
        x.style.display = "block";
    }
}

function changeText() {
    document.getElementById("form2").innerHTML = "ALL MALE";
}

function removeSomething() {
    document.getElementById("form2").remove();
}

function myOwnFunction (button) {
    button.style.backgroundColor = "white" ;
}

function printContent() {
    var firstname = document.getElementById("customFirst").value;
    var lastname = document.getElementById("customLast").value;
    var fullname = firstname + " " + lastname;
    document.getElementById("fullname").innerHTML = fullname;
}
