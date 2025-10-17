//Script de noticias via API
window.addEventListener("load", function () {

    let conteudo = document.querySelector(".caixa-individual-noticia");


    var url = 'http://newsapi.org/v2/everything?' +
        'q=ead-e-o-futuro&' +
        'apiKey=f3bd2143cba04424a31245ae208cccf7';
    var req = new Request(url);


    fetch(url, {
        method: 'GET',


    }
    )

        .then(reponse => reponse.json())
        .then(reponse => {
            console.log(reponse);

            conteudo.innerHTML += "<a href='" + reponse.articles[0].url + "'><h2 class='noticia_link'>" + reponse.articles[0].title + "</h2></a>" + "<p>" + reponse.articles[0].description + "</p>";
            conteudo.innerHTML += "<a href='" + reponse.articles[5].url + "'><h2 class='noticia_linki'>" + reponse.articles[5].title + "</h2></a>" + "<p>" + reponse.articles[5].description + "</p>";

            document.querySelector(".noticia_link").style.color = "black";
            document.querySelector(".noticia_linki").style.color = "black";
        }

        )

})

function myFunction() {
    var input, filter, ul, li, a, i, txtValue;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    ul = document.getElementById("myUL");
    li = ul.getElementsByTagName("li");
    for (i = 0; i < li.length; i++) {
        a = li[i].getElementsByTagName("a")[0];
        txtValue = a.textContent || a.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";
        }
    }
}
