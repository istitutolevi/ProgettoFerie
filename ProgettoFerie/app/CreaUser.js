($(document).ready(function () {


    $("#btn").click(function () {

        var Data = {};
        Data.email = $("#txt_email").val();
        Data.pwd = $("#txt_pw").val();
        Data.Cpwd = $("#txt_cpw").val();
        
        



        $.ajax({
            type: "POST",
            url: '/api/Account/Register',
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify(Data)
            
           }).done(function (data) {
                windows.alert("registrazione avvenuta con successo!");
}).fail(showError);






    });


}));

