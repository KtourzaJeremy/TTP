function checkUserNotExist() {
    var username = document.getElementById("username").value;
    var mdp = document.getElementById("mdp").value;
    var mdpconf = document.getElementById("mdpconf").value;

    if (mdp != mdpconf) {
        $("#errorMessage").text("Le mot de passe et le mot de passe de confirmation  ne sont pas similaire");
        $("#blockmdp").load(document.URL + "#blockmdp");
        return false;
    }

    $.ajax({
        method: "GET",
        async: false,
        url: "/Home/checkNotexistUserName",
        data: {
            userName: username
        },
        success: function (response) {
            console.log("yooo");
            console.log(response);
            if (response == "false") {
                $("#errorMessage").empty();
                $("#pass").empty();
                $("#errorMessage").text("Nom d'utilisateur déjà existant");
                $("#formNewUser").load(document.URL + "#formNewUser");
                console.log("tamere");
                return false;

            }
            
            else {
                saveNewUser();
                
              
            }

        },
        error: function (response, toto, tata) {
            console.log(response);
            console.log(toto);
            console.log();

        }

    });
}
function saveNewUser() {
    var username = document.getElementById("username").value;
    var firstname = document.getElementById("firstname").value;
    var lastname = document.getElementById("lastname").value;
    var email = document.getElementById("email").value;
    var mdp = document.getElementById("mdp").value;
    var mdpconf = document.getElementById("mdpconf").value;
    var Genre = document.getElementById("Genre").value;
    var Age = document.getElementById("Age").value;


    $.ajax({
        method: "POST",
        url: "/Home/saveNewUser",
        async : false,
        data: {
            username: username,
            firstname: firstname,
            lastname: lastname,
            email: email,
            mdp: mdp,
            Age: Age,
            Genre: Genre
        },
        success: function (response) {
            console.log("de je sais pas quoi");
            $("#confirmMessage").text(" votre inscription a été prise en compte");
            $(location).attr('href', '/UserSession/AccueilUser');
        }

    });
}