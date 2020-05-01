($(document).ready(function () {


    $("#but").click(function () {

        var email = $("#txt_email").val();
        var pwd = $("#txt_pw").val();
        var Cpwd = $("#txt_cpw").val();
        
        



        $.ajax({
            type: "POST",
            url: "http://localhost:52642/api/Account/Register",
            data: { txt_email:email, txt_pw:pwd, txt_cpw:Cpwd },
            dataType: "json",
            success: function (data) {
                window.alert("registrazione avvenuta con successo");
            } else {
                window.alert("registrazione fallita");
            }
        });






    });


}));

