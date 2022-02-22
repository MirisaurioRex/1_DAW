let eventoClic = function() {
    alert("Has pulsado " + this.id);
}

let div = document.getElementById("div1");
let p = document.getElementById("p1");
let img = document.getElementById("img1");

/*
div.addEventListener("click", eventoClic);
p.addEventListener("click", eventoClic);
img.addEventListener("click", eventoClic);
*/

div.addEventListener("click", eventoClic, true);
p.addEventListener("click", eventoClic, true);
img.addEventListener("click", eventoClic, true);