function checkUserjs()
{
    var pswd = document.getElementById("pass").value;
    var username = document.getElementById("logID").value;

    $.ajax({
        method: "GET",
        url: "/Home/checkUser",
        async : false,
        data: {
            pswd: pswd,
            username: username
        },
        success: function (response) {
            console.log(response);
            document.focus();
            if (response == true) {
               
                $(window).attr('location', '/UserSession/AccueilUser');
            }

            else {
                $("#errorMessage").empty();
                $("#pass").empty();
                $("#errorMessage").text("vous avez saisie un mauvais mot de passe");
            }
        }

    });

}