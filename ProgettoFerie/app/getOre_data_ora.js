$(document).ready(function () {

    $("#btn").click(function () {
        var Data = document.getElementById('date').value;
        var Ora = document.getElementById('Nora').value;



        $.ajax({
            type: 'GET',
            url: '/api/Ore?data='+Data+'&ora='+Ora,
            dataType: 'json',
            success: function (data) {
                $.each(data, function (index, element) {

                    $("#risultato").append(moment(element.Data).format('LLL') + " " + element.NumeroOra + " " + element.InsegnanteDisposizione.UserName + "<br>");
                });
            }
        });
    });
});