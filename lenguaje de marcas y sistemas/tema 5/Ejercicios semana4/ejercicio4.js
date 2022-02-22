'use strict';

colorFondo();
ocultar();

function colorFondo() {
    let colorFondo = document.getElementsByTagName("p")[0];
    colorFondo.style.backgroundColor = "yellow";
}


function ocultar() {
    let oculto = document.getElementsByTagName("p")[1];
    oculto.style.visibility = "hidden";
}
