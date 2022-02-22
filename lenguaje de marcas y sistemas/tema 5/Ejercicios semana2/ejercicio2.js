'use strict';

calificaciones();

function calificaciones() {
    let nombre = prompt("Inserta un nombre");
    let notaT = prompt("Inserta un número");
    let notaP = prompt("Inserta otro número");
    notaFinal (nombre, notaT, notaP);
}

function notaFinal (nombre, notaT, notaP) {
    
    if (isNaN(notaT) || isNaN(notaP)) {
        console.log("Datos incorrectos");
    }
    else {
        let resultado = (+notaT*0.4) + (+notaP*0.6);
        console.log(nombre + ": " + resultado);
    }
}