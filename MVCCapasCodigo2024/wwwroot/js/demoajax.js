$(document).ready(function () {


    $('#contactForm').submit(function (event) {


        // Evitar que el formulario se envíe automáticamente
        event.preventDefault();

        let isValid = true;

        // Validar el campo de nombre
        var nameinput = $('#name').val().trim();

        if (nameinput === '') {
            $('#nameError').text('El nombre es obligatorio.');
            isValid = false;
        } else {
            $('#nameError').text('');
        }

        const emailinput = $('#email').val().trim();

        const emailPattern = /^[^@]+@[^@]+\.[a-zA-Z]{2,}$/;
        if (emailinput === '') {
            $('#emailError').text('El correo electrónico es obligatorio.');
            isValid = false;
        } else if (!emailPattern.test(emailinput)) {
            $('#emailError').text('Por favor, ingrese un correo electrónico válido.');
            isValid = false;
        } else {
            $('#emailError').text('');
        }



        // Si el formulario es válido, se puede enviar
        if (isValid) {
            // Aquí puedes enviar el formulario usando AJAX o simplemente dejar que se envíe normalmente

            //alert('Paso la validación');
            alert(nameinput);
            alert(emailinput);
            $.ajax({
                type: "POST",
                url: "/Home/SubmitForm",
                data: {
                    name: nameinput,
                    email: emailinput
                },
                success: function (response) {

                    alert(response.message);
                    $('#message').val(response.message);                    

                },
                error: function () {
                    alert('Hubo un error al enviar el formulario.');
                }
            });


            alert('Despues del ajax');

                     
        }

    });   

});