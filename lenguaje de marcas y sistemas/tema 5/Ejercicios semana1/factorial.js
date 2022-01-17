function mostrarResultados() {
    let num = document.getElementById("factorial").value;
    let fact = 1;
    num = Number(num);

    for (let i = 1; i <= num; i++) {
        fact *= i;
    }

    console.log("El factorial de " + num + " es: " + fact);
}