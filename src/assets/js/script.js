
// Função de exibição do menu de barras para layout responsivo
$(document).ready(function() {
    $("#bars").click(function() {
        // Menu carousel
        // let cardActual = 1;
        // let listCard = ["product1", "product2", "product3", "product4"]
        
        // setInterval(changeProduct, 1000)

        // function changeProduct() {

        //     // Remove o card anterior
        //     if (cardActual > 0) {
        //         $("#cardlist").remove(listCard[cardActual - 1])
        //     } else if (cardActual == 0) {
        //         $("#cardlist").remove(listCard[(listCard.length) - 1])
        //     }

        //     // Adiciona o card atual
        //     $("#cardlist").add(listCard[cardActual]);

        //     // Indica o card atual
        //     cardActual++
        //     if (cardActual > (listCard.length) - 1) {
        //         cardActual = 0;
        //     }
        // }
            
        
        
        
        // Toggle Jquery
        $("#menu").toggleClass("menu-active")
        
        // Toggle manual
        // if($("#menu").hasClass("menu-active")) {
        //     $("#menu").removeClass("menu-active");
        // } else {
        //     $("#menu").addClass("menu-active");
        // }
    })
})

// function showMenu() {
//     let menu = document.getElementById("menu");

//     if(getComputedStyle(menu).display == "none") {
//         menu.style.display = "flex";
//     } else {
//         menu.style.display = "none"
//     }
// }

// Função teste para registro de usuário
function registerUser() {
    let nome = document.getElementById("nome").value;
    let email = document.getElementById("email").value;
    alert("O Usuário: " + nome + " de email: " + email + " foi cadastrado com sucesso");
}