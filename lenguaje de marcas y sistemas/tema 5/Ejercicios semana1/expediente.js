function mostrarResultados() {
    let nota = document.getElementById("nota").value;
    
    if (nota >= 5) {
        switch (nota) {
            case "5":
                console.log("Suficiente");
                break;
            case "6":
                console.log("Bien");
                break;
            case "7":
                console.log("Bien");
                break;
            case "8":
                console.log("Notable");
                break;
            case "9":
                console.log("Sobresaliente");
                break;
            case "10":
                console.log("Matrícula")
                break;
        
            default:
                console.log("Dato introducido incorrecto")
                break;
        }
    }
    else {
        console.log("Suspenso");
    }
}