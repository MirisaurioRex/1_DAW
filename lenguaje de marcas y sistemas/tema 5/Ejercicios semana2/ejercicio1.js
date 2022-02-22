'use strict';


principal();

function principal() {
    let numero1 = prompt("Inserta un número");
    let numero2 = prompt("Inserta otro número");
    suma(numero1, numero2);
    resta(numero1, numero2);
    multiplicacion(numero1, numero2);
    division(numero1, numero2);
    modulo(numero1, numero2);
}

/**
 * Función que pide dos números y te muestra el resultado de su suma
 */
function suma(numero1, numero2) {
    // Versión "pro"
    let resultado = +numero1 + +numero2;
    // Versión académica
    // let resultado = Number(numero1) + Number(numero2);
    console.log(numero1 + " + " + numero2 + " = " + resultado);
}


/**
 * Función que RECIBE dos números y te muestra el resultado de su resta
 */
function resta(numero1, numero2) {
    let resultado = +numero1 - +numero2;
    console.log(numero1 + " - " + numero2 + " = " + resultado);
}

/**
 * Función que RECIBE dos números y te muestra el resultado de su multiplicación
 */
function multiplicacion(numero1, numero2) {
    let resultado = +numero1 * +numero2;
    console.log(numero1 + " * " + numero2 + " = " + resultado);
}

/**
 * Función que RECIBE dos números y te muestra el resultado de su división
 */
function division(numero1, numero2) {
    let resultado = +numero1 / +numero2;
    console.log(numero1 + " / " + numero2 + " = " + resultado);
}

/**
 * Función que RECIBE dos números y te muestra el resultado del módulo
 */
function modulo(numero1, numero2) {
    let resultado = +numero1 % +numero2;
    console.log(numero1 + " % " + numero2 + " = " + resultado);
}