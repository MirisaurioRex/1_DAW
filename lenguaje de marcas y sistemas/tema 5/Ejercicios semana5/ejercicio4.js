'use strict';
window.onload=function(){
    let raton = document.getElementById("div1");
    raton.innerHTML = "Hello";
    raton.addEventListener("click", posicion);
    raton.addEventListener("mousemove", moverRaton, raton);

}

function posicion(e) {
    alert(e.pageX +" " +e.pageY);
}
function moverRaton(e, raton){
    raton.innerHTML = e.pageX + "x" + e.pageY;
}