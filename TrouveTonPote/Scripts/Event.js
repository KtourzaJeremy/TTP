function newEvent() {
    var titre = document.getElementById("titre").value;
    var localisation = document.getElementById("localisation").value;
    var date = document.getElementById("date").value;
    var etat = document.getElementById("etat").value;
    var nbmax = document.getElementById("nbmax").value;
    var photo = document.getElementById("photo").value;

    
    $.ajax({
        method: "POST",
        url: "/Home/saveNewEvent",
        data: {
            titre: titre,
            localisation: localisation,
            etat: etat,
            date: date,
            nbmax: nbmax,
            photo: photo,

        },
        success: function (response) {

            $("#confirmMessage").append("<h2> votre évenement  a été enregistré </h2>");
        }
    });
}

function recupListEvent() {
    $.ajax({
        method: "GET",
        url: "/Home/ListEvent",
        success: function (response) {
            console.log(response);
            for (i = 0; i < response.length; i++) {
                $("#showevent").append("<div>" + response[i] + "</div>");
            }
           
        }
    });

}