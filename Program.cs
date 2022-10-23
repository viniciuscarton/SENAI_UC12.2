using  UC12_CLAB.Classes;


PessoaFisica pf1 = new PessoaFisica();
Endereco novoEnd = new Endereco();
PessoaFisica metodopf = new PessoaFisica();

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

Console.WriteLine(@$"
Nome: {pf1.Nome}
CPF: {pf1.cpf}
Data de nascimento: {pf1.dataNascimento}
Maior de idade: {metodopf.ValidarDataNascimento(pf1.dataNascimento)}
Endereço: {pf1.Endereco.logradouro}, {pf1.Endereco.numero}
");







