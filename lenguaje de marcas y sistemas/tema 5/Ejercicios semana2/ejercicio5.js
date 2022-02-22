'use strict';

producto();

function producto() {

    let nomProducto = prompt("Elige un producto");
    let precio = prompt("Elige un precio");
    let impuesto = prompt("Elige un IVA");

    if (String(nomProducto) == "") {
        nomProducto = "Producto genérico";
    }
    if (isNaN(precio) || isNaN(impuesto)) {
        console.log("Los datos introducidos son incorrectos");
    }
    else{
        if (precio == "") {
            precio = 100;
        }
        if (impuesto == "") {
            impuesto = 21;
        }
        console.log(precio);
        console.log(impuesto);

        console.log(nomProducto + ": " +(+precio + ((precio*impuesto)/100)) + " €");
    } 


}