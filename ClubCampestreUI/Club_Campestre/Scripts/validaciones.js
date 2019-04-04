function myFunction() {
    var x = document.getElementById("txtFiltrar").value;
    document.getElementById("errorMensaje").innerHTML = "You wrote: " + x;
}

function Alert() {
    var mjs = document.getElementById("errorMensaje").value;
    if (caja_texto.trim() === "") {       
        return false;
    }
    else {
        alert(mjs);
        return true;
    }


}

function SoloNumeros(e) {
    var key = e.keyCode || e.which;
    var teclado = String.fromCharCode(key);
    var numero = "0123456789.";

    return numero.indexOf(teclado) !== -1;
}

function SOLO_LETRAS(e) {
    key = e.keyCode || e.which;
    teclado = String.fromCharCode(key).toLowerCase();
    letras = "abcdefghijklñnmopqrstuvwxyzáéíóú";
    especiales = "8-37-38-46";
    tecaldo_especiales = false;

    for (var i in especiales) {

        if (key == especiales[i]) {
            tecaldo_especiales = true;
            break;
        }

        if ((letras.indexOf(teclado) == -1) && (!tecaldo_especiales)) {
            document.getElementById("formError").innerHTML = "no puede digitar numeros";
            return false;
        }
        else {
            document.getElementById("formError").innerHTML = "";
            return true;
        }

    }
}

function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
}

function AvoidSpace(event) {
    var k = event ? event.which : window.event.keyCode;
    if (k == 32) return false;
}



function VALIDA_INPUT_TEXT() {
    var caja_texto = document.getElementById("LETRAS").value;

    if (caja_texto.trim() === "") {
        document.getElementById("formError").innerHTML = "debe digitar una frase";
        return false;
    }
    else {
        document.getElementById("formError").innerHTML = "";
        return true;
    }


}

