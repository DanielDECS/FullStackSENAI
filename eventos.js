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

        alert("Verificação inicial para cadastro de participantes!");
        let menores = prompt("Entre os participantes há alguém menor de 18 anos, sim ou não?")
        if (menores.trim().toUpperCase() != "SIM") {
            let nomeParticipantes = prompt("Escreva o nome dos participantes separados por vírgula:")
            alert(`A lista com o nome dos palestrantes é: ${nomePalestrantes}.`)
            alert(`A lista com o nome dos participantes é: ${nomeParticipantes}.`)
        } else {
            alert("Não são permitidos menores de 18 anos no evento!");
        }
    } else {
        alert("A data do evento não é válida!");
    }
} else {
    alert("Não é possivel cadastrar um evento sem um nome!")
}
alert("Fim do cadastro de eventos.")

