using  UC12_CLAB.Classes;


PessoaFisica metodopf = new PessoaFisica();
PessoaFisica pf1 = new PessoaFisica();
Endereco novoEnd = new Endereco();

pf1.Nome = "Marcelo";
pf1.cpf = "123.456.789.01";
pf1.dataNascimento = "01/01/2010";
pf1.rendimento = 600;

novoEnd.logradouro = "Rua Machado de Assis";
novoEnd.numero = 1000;
novoEnd.complemento = "Cemitério";
novoEnd.endComercial = true;
pf1.Endereco = novoEnd;

//Console.WriteLine("Nome: " + pf1.Nome + "\nCPF: " + pf1.cpf + "\nData de nascimento: " );

PessoaJuridica metodopj = new PessoaJuridica();
PessoaJuridica pj1 = new PessoaJuridica();
//Endereco novoEnd = new Endereco();

pj1.Nome = "Fábrica de Chocolates";
pj1.cnpj = "12.345.678/9012-34";
pj1.razaoSoc = "Willy Wonka LTDA";
pj1.rendimento = 8000;

/*
novoEnd.logradouro = "Rua 30 de Fevereiro";
novoEnd.numero = 1322;
novoEnd.complemento = "Perto de Ratanabá";
novoEnd.endComercial = true;
*/

Console.WriteLine(@$"
Pessoa física
Nome: {pf1.Nome}
CPF: {pf1.cpf}
Data de nascimento: {pf1.dataNascimento}
Maior de idade: {metodopf.ValidarDataNascimento(pf1.dataNascimento)}
Endereço: {pf1.Endereco.logradouro}, {pf1.Endereco.numero}

Pessoa jurídica
Nome: {pj1.Nome}
Razão social: {pj1.razaoSoc}
CNPJ: {pj1.cnpj}
CNPJ válido: {metodopj.ValidarCNPJ(pj1.cnpj)}
");









