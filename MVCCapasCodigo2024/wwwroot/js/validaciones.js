$(document).ready(function () {


    $('#contactForm').submit(function (event) {


        // Evitar que el formulario se envíe automáticamente
        event.preventDefault();

        let isValid = true;



        // Validar el campo de nombre
        var name = $('#name').val().trim();
        if (name === '') {
            $('#nameError').text('El nombre es obligatorio.');
            isValid = false;
        } else {
            $('#nameError').text('');
        }

        const email = $('#email').val().trim();
        const emailPattern = /^[^@]+@[^@]+\.[a-zA-Z]{2,}$/;
        if (email === '') {
            $('#emailError').text('El correo electrónico es obligatorio.');
            isValid = false;
        } else if (!emailPattern.test(email)) {
            $('#emailError').text('Por favor, ingrese un correo electrónico válido.');
            isValid = false;
        } else {
            $('#emailError').text('');
        }

        // Si el formulario es válido, se puede enviar
        if (isValid) {
            alert('Formulario enviado con éxito.');
            // Aquí puedes enviar el formulario usando AJAX o simplemente dejar que se envíe normalmente
            this.submit();
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