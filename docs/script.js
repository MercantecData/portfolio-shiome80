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