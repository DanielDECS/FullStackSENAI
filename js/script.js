
//Função de exibição do menu carrousel
function carrousel() {
    let product1 = document.getElementById("product1");
    let product2 = document.getElementById("product2");
    let product3 = document.getElementById("product3");
    let product4 = document.getElementById("product4");
    let slideAtual = 1;
    let listaSlides = [product1, product2, product3, product4];

    setInterval(changeProduct, 2000);

    function changeProduct() {
        console.log("Slide atual: " + slideAtual);
        // Remove o slide anterior
        if (slideAtual > 0) {
            listaSlides[slideAtual - 1].style.display = "none";
        } else if (slideAtual == 0) {
            listaSlides[(listaSlides.length) - 1].style.display = "none";
        }

        // Adiciona o  slide atual
        (listaSlides[slideAtual]).style.display = "flex";

        // Indica o side atual
        slideAtual++

        if(slideAtual > (listaSlides.length) - 1){
            slideAtual = 0
        }
    }
}

//Função de exibição do menu de barras para layout responsivo
function showMenu() {
    let menu = document.getElementById("menu");

    if (getComputedStyle(menu).display == "none") {
        menu.style.display = "flex";
    } else {
        menu.style.display = "none"
    }
}

// Função teste para registro de usuário
function registerUser() {
    let nome = document.getElementById("nome").value;
    let email = document.getElementById("email").value;
    alert("O Usuário: " + nome + " de email: " + email + " foi cadastrado com sucesso");
}