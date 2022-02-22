'use strict';

añadir();
borrar();

function añadir() {
    let p = document.createElement("p");
    let pTexto = document.createTextNode("Miranda");
    p.appendChild(pTexto);
 
    document.body.appendChild(p);
}
function borrar() {
    let cuerpo = document.getElementsByTagName("body")[0];
    let parrafos = document.getElementsByTagName("p");
    cuerpo.removeChild(parrafos[1]);
}

