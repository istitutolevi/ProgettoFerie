$(document).ready(function () {

    $("#btn").click(function () {
        var Id = document.getElementById('id').value;



        $.ajax({
            type: 'delete',
            url: '/api/Ore/'+Id,
            contentType: 'application/json',
            // dataType: 'json',
            success: function (data) {
                window.alert("ok");

            },
            error: function () {
                window.alert("errore");
            }
        });
    });
});