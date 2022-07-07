
using PRJ_CONTAS_BANCARIAS.Classes;

//ATIVIDADE DO ENCONTRO REMOTO 2

/* 
PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.nome = "Daniel";

Console.WriteLine(novaPessoaFisica.nome);
Console.WriteLine("Nome: " + novaPessoaFisica.nome + " CADASTRADO");
Console.WriteLine($"Nome: {novaPessoaFisica.nome} ADICIONADO");
*/

// ATIVIDADE DO ENCONTRO REMOTO 3

/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndereco = new Endereco();

PessoaFisica metodoPf = new PessoaFisica();

novaPf.nome = "Daniel";
novaPf.dataNascimento = "23/03/2005";
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
*/

// ATIVIDADE DO ENCONTRO REMOTO 4

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