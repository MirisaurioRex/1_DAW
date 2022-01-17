function mostrarResultados() {
    let num1 = document.getElementById("num1").value;
    let num2 = document.getElementById("num2").value;
    let suma, resta, mult, div;
    suma = Number(num1)+Number(num2);
    resta = Number(num1)-Number(num2);
    mult = Number(num1)*Number(num2);
    div = Number(num1)/Number(num2);
    
    alert("num1: "+ num1 + " num2: " + num2);
    console.log("La suma es: " + suma);
    console.log("La resta es: " + resta);
    console.log("La multiplicación es: " + mult);
    console.log("La división es: " + div);
}