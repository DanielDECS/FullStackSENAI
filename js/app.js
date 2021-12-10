//App de contato
function selectId(id) {
    return document.getElementById(id);
}

function empty(input) {
    return input.value.trim() === "";
}

function errorMessage(message) {
    errorListUl.innerHTML += "<li>" + message + "</li>";
}

let form = selectId('contato-form');
let nome = selectId('nome');
let email = selectId('email');

let errorListUl = document.querySelector('#error-list ul');
let errorList = selectId('error-list');


form.addEventListener("submit", function(evento) {
    errorListUl.innerHTML = "";
    if (empty(nome)) {
        errorMessage("Campo <b>nome</b> não preenchido");
    } else if (empty(email)) {
        errorMessage("Campo <b>email</b> não preenchido");
    } else if (empty(mensagem)) {
        errorMessage("Campo <b>mensagem</b> não preenchido");
    } else {
        alert("Prezado " + nome.value + " o seu email: " + email.value + " foi cadastrado, entraremos em contato!");
    };

    if (errorList.querySelectorAll('li').length > 0) {
        evento.preventDefault();
        errorList.hidden = "";
    };

});


function filter() {
    var input, filter, ul, li, a, i, txtValue;
    input = document.getElementById("input-search");
    filter = input.value.toUpperCase();
    divCurso = document.getElementById("div-curso");
    div = divCurso.getElementsByTagName("div");
    for (i = 0; i < div.length; i++) {
        h2 = div[i].getElementsByTagName("h2")[0];
        txtValue = h2.textContent || h2.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            div[i].style.display = "";
        } else {
            div[i].style.display = "none";
        }
    }
}


    