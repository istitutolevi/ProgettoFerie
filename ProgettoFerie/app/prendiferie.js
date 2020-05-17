$(document).ready(function ()
{

    $("#btn").click(function () {

        var Array = {
            Id: $("#Nora").val(),
            NumeroOra: $("#Nora").val(),
            Data: $("#date").val()
        };



        $.ajax({
            type: 'post',
            url: '/api/Account/Ore',
            contentType: 'application/json',
            data: JSON.stringify(Array),
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