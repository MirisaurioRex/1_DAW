'use strict';

piramide();

function piramide() {
    let numero = prompt("Inserta un número");
    while (numero < 1 || isNaN(numero)) {
        numero = prompt("Inserta un número válido");
    }
    let asteriscos;
    for (let i = 0; i < numero; i++) {
        asteriscos = "";
        for (let j = 0; j <= i; j++) {
            asteriscos += "*";      
        }
        console.log(asteriscos);
    }
}

