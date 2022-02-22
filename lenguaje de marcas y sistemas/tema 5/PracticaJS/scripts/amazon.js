'use strict';

let aMoviles = [
    { id: '1', img: 'img/mi10T.png', nombre: 'Mi 10t', precio: 300 },
    { id: '2', img: 'img/pocoM2PRO.png', nombre: 'POCO M2 Pro', precio: 400 },
    { id: '3', img: 'img/pocoX2.png', nombre: 'POCO X2', precio: 200 },
    { id: '4', img: 'img/pocoX3NFC.png', nombre: 'POCO X3 NFC', precio: 700 }
];


document.addEventListener('DOMContentLoaded', cargarProductos);

function cargarProductos(evento) {
    let productos = document.getElementById('productos');
    aMoviles.forEach(element => {
        let article = document.createElement('article');
        article.classList.add('mvl');
        let imagen = document.createElement('img');
        imagen.src = element.img;
        let nombre = document.createElement('p');
        nombre.textContent = element.nombre;
        let precio = document.createElement('p');
        precio.textContent = element.precio.toFixed(2) + "€";
        let comprar = document.createElement('button');
        comprar.textContent = 'Comprar';
        article.append(imagen, nombre, precio, comprar);
        productos.append(article);
    });
}

document.querySelector('.borrar').addEventListener('click', borrarItem);

function borrarItem(evento){
    let movil = evento.target;
    console.log("movil" + movil);
    console.log("padre" + movil.parentNode);
    confirm('¿Estás seguro de querer borrar el móvil?' + movil.parentNode);
}