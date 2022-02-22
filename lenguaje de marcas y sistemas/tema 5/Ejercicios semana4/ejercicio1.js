'use strict';

cantidadEnlaces();
direccion();
enlacesParrafoTres();

function cantidadEnlaces() {
    let enlaces = alert(document.getElementsByTagName("a").length);
}

function direccion() {
    let direccion = alert(document.getElementsByTagName("a")[0].href);
}

function enlacesParrafoTres() {
    let parrafoTres = alert(document.getElementById("p3").getElementsByTagName("a").length);
}
