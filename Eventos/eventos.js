alert("Bem vindo ao sistema de cadastro de eventos!")

let nomeEvento = prompt("Escreva o nome do evento:")
if (nomeEvento != "") {
    alert(`Vamos iniciar o cadastro das informações do evento ${nomeEvento}!`)
    let dataEvento = prompt("Escreva a data do evento no formato conforme exemplo: 01/01/2021")

    let partesData = dataEvento.split("/");
    let data = new Date(partesData[2], partesData[1] - 1, partesData[0]);
    if (data > new Date()) {
        alert(`A data: ${dataEvento} para o evento é válida, seguindo com o cadastro...`);
        alert("Cadastro de palestrantes!");
        let nomePalestrantes = prompt("Escreva o nome dos palestrantes separados por vírgula:")

        let listaParticipantes = ["Danilo", "Marcelo", "Alan"];
        if (listaParticipantes.length <= 100) {
            alert("Verificação inicial para cadastro de participante!");
            let idadeParticipante = parseInt(prompt("Entre com a idade do participante"))
            if (idadeParticipante >= 18) {
                let novoParticipante = prompt("Escreva o nome do participante")
                listaParticipantes.push = novoParticipante;
            } else {
                alert("Não são permitidos menores de 18 anos no evento!");
            }
        } else {
            alert("O total de participantes excedeu o limite permitido");
        }
        alert(`A lista com o nome dos palestrantes é: ${nomePalestrantes}.`)
        alert('Os participantes cadastrados são:');
        for(let i = 0; i < listaParticipantes.length; i++) {
           alert(listaParticipantes[i]); 
        }
    } else {
        alert("A data do evento não é válida!");
    }
} else {
    alert("Não é possivel cadastrar um evento sem um nome!")
}
alert("Fim do cadastro de eventos.")

