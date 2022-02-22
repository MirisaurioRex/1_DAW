'use strict'

let campo = document.getElementById("campo");
campo.addEventListener("focus", amarillo);
campo.addEventListener("blur", rojo);


function amarillo() {
    campo.style.background = "yellow";
}

function rojo() {
    if (value == "") {
        campo.style.background = "red";
    }
    else
        campo.style.background = "white";
}