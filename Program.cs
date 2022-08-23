
using PRJ_CONTAS_BANCARIAS.Classes;

// ATIVIDADE DO ENCONTRO REMOTO 5 , 6 , 7 e 8

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
List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
===============================================================================
|             Escolha o tipo da conta bancaria nas opções abaixo:             |
|_____________________________________________________________________________|
|                                                                             |
|                          1 - Pessoa Física                                  |
|                          2 - Pessoa Jurídica                                |
|                                                                             |
|                          0 - Sair                                           |
===============================================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {

        case "1":
            PessoaFisica metodoPf = new PessoaFisica();

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir:                         |
|_____________________________________________________________________________|
|                                                                             |
|                          1 - Cadastrar Pessoa Física                        |
|                          2 - Mostrar Pessoa Física                          |
|                                                                             |
|                          0 - Sair                                           |
===============================================================================
");
                opcaoPf = Console.ReadLine();
                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndereco = new Endereco();
                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();
                        
                        
                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de Nascimento Ex.: DD/MM/AAAA");
                            string dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);

                            if (dataValida)
                            {
                                novaPf.dataNascimento = dataNasc;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada é inválida, por favor digite uma data válida");
                                Console.ResetColor();
                            }

                        } while (dataValida == false);

                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndereco.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEndereco.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte ENTER para vazio");
                        novoEndereco.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndereco.endComercial = true;
                        }
                        else
                        {
                            novoEndereco.endComercial = false;
                        }
                        novaPf.endereco = novoEndereco;

                        
                        using (StreamWriter sw = new StreamWriter($"CC_PF_{novaPf.nome}.txt"))
                        {
                            sw.WriteLine("Informações de conta corrente de pessoa física");
                            sw.WriteLine($"Nome: {novaPf.nome}");
                            sw.WriteLine($"CPF: {novaPf.cpf}");
                            sw.WriteLine($"Data de nascimento: {novaPf.dataNascimento}");
                            sw.WriteLine($"Rendimento mensal: {novaPf.rendimento}");
                            sw.WriteLine($"Endereço: Rua {novoEndereco.logradouro}, {novoEndereco.numero}, {novoEndereco.complemento}");
                        }

                        listaPf.Add(novaPf);
                        
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;

                    case "2":
                        Console.Clear();

                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                Endereco: {cadaPessoa.endereco.numero}, {cadaPessoa.endereco.numero}
                                Data de Nascimento: {cadaPessoa.dataNascimento}
                                Data é válida: {(metodoPf.ValidarDataNascimento(cadaPessoa.dataNascimento)?"Sim":"Não")}
                                Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                ");
                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista Vazia!!!");
                            Thread.Sleep(3000);
                        }
                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opcaoPf != "0");

            break;


        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            string? opcaoPj;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================================================
|                    Escolha uma das opções a seguir:                         |
|_____________________________________________________________________________|
|                                                                             |
|                          1 - Cadastrar Pessoa Jurídica                      |
|                          2 - Mostrar Pessoa Jurídica                        |
|                                                                             |
|                          0 - Sair                                           |
===============================================================================
");
                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa jurídica que deseja cadastrar");
                        novaPj.nome = Console.ReadLine();

                        Console.WriteLine($"Digite o nome da razão social");
                        novaPj.razaoSocial = Console.ReadLine();

                        bool cnpjValido;
                        do
                        {
                            Console.WriteLine($"Digite o número do CNPJ");
                            string cnpj = Console.ReadLine();

                            cnpjValido = metodoPj.ValidarCnpj(cnpj);

                            if (cnpjValido)
                            {
                                novaPj.cnpj = cnpj;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"O CNPJ digitado é inválido, por favor digite um CNPJ válido");
                                Console.ResetColor();
                            }

                        } while (cnpjValido == false);

                        Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte ENTER para vazio");
                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPj.endComercial = true;
                        }
                        else
                        {
                            novoEndPj.endComercial = false;
                        }
                        novaPj.endereco = novoEndPj;


                        using (StreamWriter sw = new StreamWriter($"CC_PJ_{novaPj.nome}.txt"))
                        {
                            sw.WriteLine("Informações de conta corrente de pessoa jurídica");
                            sw.WriteLine($"Nome: {novaPj.nome}");
                            sw.WriteLine($"CNPJ: {novaPj.cnpj}");
                            sw.WriteLine($"Razão Social: {novaPj.razaoSocial}");
                            sw.WriteLine($"Rendimento mensal: {novaPj.rendimento}");
                            sw.WriteLine($"Endereço: Rua {novoEndPj.logradouro}, {novoEndPj.numero}, {novoEndPj.complemento}");
                        }

                        listaPj.Add(novaPj);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;

                    case "2":
                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPessoa in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                Razao Social: {cadaPessoa.razaoSocial}
                                CNPJ: {cadaPessoa.cnpj}
                                CNPJ é válido: {(metodoPj.ValidarCnpj(cadaPessoa.cnpj)?"Sim":"Não")}
                                Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                ");
                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista Vazia!!!");
                            Thread.Sleep(3000);
                        }
                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opcaoPj != "0");
            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"O sistema de cadastro bancário será fechado");
            BarraCarregamento("Finalizando", 200);
            Console.WriteLine("");
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



