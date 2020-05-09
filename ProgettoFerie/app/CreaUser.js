$(document).ready(function () {


    $("#btn").click(function () {

        var Data = {
            Email: $("#txt_email").val(),
            Password: $("#txt_pw").val(),
            ConfirmPassword: $("#txt_cpw").val()
        };



        $.ajax({
            type: 'post',
            url: '/api/Account/Register',
            contentType: 'application/json',
            data: JSON.stringify(Data),
           // dataType: 'json',
            success: function (data) {
                window.alert(data);

            },
            error: function () {
                window.alert("errore");
            }
        });

    });

});

