
using PRJ_CONTAS_BANCARIAS.Classes;

// ATIVIDADE DO ENCONTRO REMOTO 5

Console.WriteLine(@$"
===============================================================================
|                 Bem vindo ao sistema de cadastro bancário de                |
|                       pessoas físicas e jurídicas                           |
===============================================================================
");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write($"{texto}");

    for (var contador = 0; contador < 23; contador++)
    {
        Console.Write(" > ");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}

BarraCarregamento("Carregando", 100);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
===============================================================================
|             Escolha o tipo da conta bancaria nas opções abaixo:             |
|_____________________________________________________________________________|
|                          1 - Pessoa Física                                  |
|                          2 - Pessoa Jurídica                                |
|                          0 - Sair                                           |
===============================================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "0":
            Console.Clear();
            Console.WriteLine($"O sistema de cadastro bancário será fechado");
            BarraCarregamento("Finalizando", 200);
            Console.WriteLine("");
            break;

        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEndereco = new Endereco();
            PessoaFisica metodoPf = new PessoaFisica();

            novaPf.nome = "Daniel";
            novaPf.dataNascimento = "23/03/1995";
            novaPf.cpf = "08807183756";
            novaPf.rendimento = 400.0f;
            novoEndereco.logradouro = "Rua do Contorno";
            novoEndereco.numero = 539;
            novoEndereco.complemento = "Senai";
            novoEndereco.endComercial = true;
            novaPf.endereco = novoEndereco;

            Console.WriteLine(@$"
                Nome: {novaPf.nome}
                Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
                Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
            ");

            Console.WriteLine($"Aperte a tecla 'Enter' para continuar");
            Console.ReadLine();
            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome de Pessoa Jurídica";
            novaPj.cnpj = "00000000000100";
            novaPj.razaoSocial = "Razao Social de Pessoa Jurídica";
            novaPj.rendimento = 8000.5f;
            novoEndPj.logradouro = "Rua do Contorno";
            novoEndPj.numero = 539;
            novoEndPj.complemento = "Senai";
            novoEndPj.endComercial = true;
            novaPj.endereco = novoEndPj;

            Console.WriteLine(@$"
                Nome: {novaPj.nome}
                Razao Social: {novaPj.razaoSocial}
                CNPJ: {novaPj.cnpj}
                CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
            ");

            Console.WriteLine($"Aperte a tecla 'Enter' para continuar");
            Console.ReadLine();
            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, digite uma outra opção");
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");

/*
ATIVIDADE DO ENCONTRO REMOTO 4

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "Nome de Pessoa Jurídica";
novaPj.cnpj = "00000000000100";
novaPj.razaoSocial = "Razao Social de Pessoa Jurídica";
novaPj.rendimento = 8000.5f;
novoEndPj.logradouro = "Rua do Contorno";
novoEndPj.numero = 539;
novoEndPj.complemento = "Senai";
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razao Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");



ATIVIDADE DO ENCONTRO REMOTO 3


PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndereco = new Endereco();

PessoaFisica metodoPf = new PessoaFisica();

novaPf.nome = "Daniel";
novaPf.dataNascimento = "23/03/1995";
novaPf.cpf = "08807183756";
novaPf.rendimento = 400.0f;

novoEndereco.logradouro = "Rua do Contorno";
novoEndereco.numero = 539;
novoEndereco.complemento = "Senai";
novoEndereco.endComercial = true;

novaPf.endereco = novoEndereco;

Console.WriteLine(@$"
    Nome: {novaPf.nome}
    Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
    Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");


ATIVIDADE DO ENCONTROS REMOTOS 1 e 2

PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.nome = "Daniel";

Console.WriteLine(novaPessoaFisica.nome);
Console.WriteLine("Nome: " + novaPessoaFisica.nome + " CADASTRADO");
Console.WriteLine($"Nome: {novaPessoaFisica.nome} ADICIONADO");

*/



