'use strict';

comparaCad();
console.log(tipoFichero());

function comparaCad () {
    let palabra1 = prompt("Escribe una palabra");
    let palabra2 = prompt("Escribe otra palabra");

    if (typeof palabra1 !== "string" || typeof palabra2 !== "string") {
        console.log("Error, los parámetros no son válidos");
    }
    else if (palabra1.length > palabra2.length) {
        console.log("La primera palabra tiene mayor longitud");
    }
        else if (palabra1.length == palabra2.length) {
            console.log("Las dos palabras son iguales");
        }
        else {
            console.log("La segunda palabra tiene mayor longitud");
        }
}

function tipoFichero () {
    let fichero = prompt("Sube un fichero", ".pdf");

    return (fichero.toLocaleUpperCase().endsWith(".PDF"));
}