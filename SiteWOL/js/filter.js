//Filtro de busca no site
function filter() {
    var input, filter, divCurso, div, h2, i, txtValue, cont;
    input = document.getElementById("input-search");
    filter = input.value.toUpperCase();
    divCurso = document.getElementById("div-curso");
    div = divCurso.getElementsByTagName("div");
    for (i = 0; i < div.length; i++) {
        h2 = div[i].getElementsByTagName("h2")[0];
        txtValue = h2.textContent || h2.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            div[i].style.display = "";
            cont++;
        } else {
            div[i].style.display = "none";
        }
    }

}


