$(document).ready(function () {
    $.ajax({
        type: 'GET',
        url: '/api/Ore',
        dataType: 'json',
        success: function (data) {
            $.each(data, function (index, element) {

                console.log(element.Data + " " + element.InsegnanteDisposizione.UserName);
            });
        }
    });



});