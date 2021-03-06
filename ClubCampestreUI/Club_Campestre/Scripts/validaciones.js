﻿function closeApp() {
    var w = window.self;
    w.opener = window.self;
    w.close();
    window.location = "IndexCliente.aspx";
    document.getElementById("idUsuario").innerText = "USUARIO";
}



function NoEnterBuscar(e) {
    if((e.keyCode == 13) || (e.which  == 13))
        return false
}



function SoloNumeros(e) {
    key = e.keyCode || e.which;
    tecla = String.fromCharCode(key).toLowerCase();
    numeros = "0123456789";
    especiales = "8-37-39-46";

    tecla_especial = false
    for (var i in especiales) {
        if (key == especiales[i]) {
            tecla_especial = true;
            break;
        }
    }

    if (numeros.indexOf(tecla) == -1 && !tecla_especial) {
        return false;
    }
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

   function soloLetras(e){
       key = e.keyCode || e.which;
       tecla = String.fromCharCode(key).toLowerCase();
       letras = " áéíóúabcdefghijklmnñopqrstuvwxyz";
       especiales = "8-37-39-46";

       tecla_especial = false
       for(var i in especiales){
           if(key == especiales[i]){
               tecla_especial = true;
               break;
           }
       }

       if(letras.indexOf(tecla)==-1 && !tecla_especial){
           return false;
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

$(function () {
    $('.ckBox').bind('change', function () {
        if ($(this).is(":checked")) {
            $('.ckBox').attr('disabled', 'disabled');
            $(this).removeAttr('disabled'); //show checkbox has been checked
        } else {
            $('.ckBox').removeAttr('disabled'); //Disable all checkboxes
        } return false;
    });
});