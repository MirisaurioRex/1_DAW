'use strict';

cantidadEnlaces();
direccion();
enlacesParrafoTres();

function cantidadEnlaces() {
    let enlaces = alert(document.querySelectorAll("a").length);
}

function direccion() {
    let direccion = alert(document.querySelector("a").href);
}

function enlacesParrafoTres() {
    let parrafoTres = alert(document.querySelectorAll("#p3>a").length);
}