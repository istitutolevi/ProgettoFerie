$(document).ready(function () {
    $.ajax({
        type: 'GET',
        url: '/api/Ore',
        dataType: 'json',
        success: function (data) {
            $.each(data, function (index, element) {

                $("#risultato").append(element.Data + " " + element.InsegnanteDisposizione.UserName + " " + element.NumeroOra );
            });
        }
    });



});