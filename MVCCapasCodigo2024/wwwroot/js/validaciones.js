$(document).ready(function () {


    $('#contactForm').submit(function (event) {


        // Evitar que el formulario se envíe automáticamente
        event.preventDefault();
        // Validar el campo de nombre
        var name = $('#name').val().trim();
        if (name === '') {
            $('#nameError').text('El nombre es obligatorio.');
        } else {
            $('#nameError').text('');
        }

        var name = $('#email').val().trim();
        if (name === '') {
            $('#emailError').text('El email es obligatorio.');
        } else {
            $('#emailError').text('');
        }

    });


    $('#mostrar').click(function () {
        var mensaje = $('#mensaje').val();

        if (mensaje == '') {
            alert('Por favor ingresa el mensaje');
        }
        else {
            alert(mensaje);
        }

    });

});