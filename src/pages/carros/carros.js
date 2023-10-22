var caixadeInfo = document.getElementById('caixadeInformação');
var textoHorário = document.getElementById('presençaAutomática');


function mostrarDiv() {
    if (caixadeInfo.style.display === "block") {
        caixadeInfo.style.display = "none";
    } else {
        caixadeInfo.style.display = "block";
    }
}

