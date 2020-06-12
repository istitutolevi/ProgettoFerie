$(document).ready(function ()
{

    $("#btn").click(function () {

        var Array = {
            Id: $("#Nora").val(),
            NumeroOra: $("#Nora").val(),
            Data: $("#date").val(),
            InsegnanteDisposizione: {
                Id: $("#id").val(),
                UserName: $("#email").val()
            }
        };



        $.ajax({
            type: 'post',
            url: '/api/Ore',
            contentType: 'application/json',
            data: JSON.stringify(Array),
            success: function (data) {
                window.alert("Ora aggiunta");

            },
            error: function () {
                window.alert("errore");
            }
        });

    });




});