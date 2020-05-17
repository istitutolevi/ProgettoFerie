$(document).ready(function () {
    $.ajax({
        type: 'GET',
        url: '/api/Ore',
        dataType: 'json',
        success: function (data) {
            $.each(data, function (index, element) {

                $("#risultato").append(moment(element.Data).format('LLL')  + " " + element.InsegnanteDisposizione.UserName + " " + element.NumeroOra + "<br>" );
            });
        }
    });



});