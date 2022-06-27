
// Função de exibição do menu de barras para layout responsivo
// $(document).ready(function() {
//         // Toggle manual
//         if($("#menu").hasClass("menu-active")) {
//             $("#menu").removeClass("menu-active");
//         } else {
//             $("#menu").addClass("menu-active");
//         }

// })

// setInterval(changeProduct, 1000);

function changeProduct() {
    let product1 = document.getElementById("product1");
    getComputedStyle(product1).visibility = "hidden";
}

//     if(getComputedStyle(product1).display == "none" && 
//     getComputedStyle(product2).display == "none") {
//     product1.style.display = "flex";
//     product2.style.display = "flex";
//     product3.style.display = "none";
//     product4.style.display = "none";
// } 
    

function showMenu() {
    let menu = document.getElementById("menu");

    if(getComputedStyle(menu).display == "none") {
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