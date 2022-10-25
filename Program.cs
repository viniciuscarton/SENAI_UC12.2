using  UC12_CLAB.Classes;

Console.WriteLine(@$"
--------------------------------------------------------------------
|                            Bem vindo!                            |
|                      Sistema de cadastro de                      |
|                   Pessoas Físicas e Jurídicas                    |                                                 
--------------------------------------------------------------------
");

barraCarregar("Carregando", 50);
string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
--------------------------------------------------------------------
|                 Escolha uma das opções a seguir:                 |
|__________________________________________________________________|
|                         1 - Pessoa física                        |
|                         2 - Pessoa jurídica                      |
|                         0 - Sair                                 |                                                 
--------------------------------------------------------------------
");  

opcao = Console.ReadLine();

switch (opcao)
    {
        case "1": 
            PessoaFisica metodopf = new PessoaFisica();
            PessoaFisica pf1 = new PessoaFisica();
            Endereco novoEnd = new Endereco();
            pf1.Nome = "Marcelo";
            pf1.cpf = "123.456.789.01";
            pf1.dataNascimento = "01/01/2010";
            pf1.rendimento = 600;
            novoEnd.logradouro = "Rua Machado de Assis";
            novoEnd.numero = 1000;
            novoEnd.complemento = "Terceiro jazigo entrando no Cemitério";
            novoEnd.endComercial = true;
            pf1.Endereco = novoEnd;
            Console.WriteLine(@$"
                Pessoa física
                Nome: {pf1.Nome}
                CPF: {pf1.cpf}
                Data de nascimento: {pf1.dataNascimento}
                Maior de idade: {metodopf.ValidarDataNascimento(pf1.dataNascimento)}
                Endereço: {pf1.Endereco.logradouro}, {pf1.Endereco.numero}. {pf1.Endereco.complemento}
                ");
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;
        case "2": 
            PessoaJuridica metodopj = new PessoaJuridica();
            PessoaJuridica pj1 = new PessoaJuridica();
            Endereco novoEndPJ = new Endereco();
            pj1.Nome = "Fábrica de Chocolates";
            pj1.cnpj = "12.345.678/9012-34";
            pj1.razaoSoc = "Willy Wonka LTDA";
            pj1.rendimento = 8000;
            novoEndPJ.logradouro = "Rua 30 de Fevereiro";
            novoEndPJ.numero = 1322;
            novoEndPJ.complemento = "Perto de Ratanabá";
            novoEndPJ.endComercial = true;
            pj1.Endereco = novoEndPJ;
            Console.WriteLine(@$"
                Pessoa jurídica
                Nome: {pj1.Nome}
                Razão social: {pj1.razaoSoc}
                CNPJ: {pj1.cnpj}
                CNPJ válido: {metodopj.ValidarCNPJ(pj1.cnpj)}
                Endereço: {pj1.Endereco.logradouro}, {pj1.Endereco.numero}. {pj1.Endereco.complemento}
                ");
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;
        case "0": 
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema :D");
            barraCarregar("Finalizando", 100);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Por favor, selecione uma das opções do menu");
            for (int a = 5; a >= 0; a--)
            {
                Console.Write("\r Retornando ao menu em {0:00}", a);
                System.Threading.Thread.Sleep(1000);
            } 
            break;
    }  
} while (opcao != "0");

static void barraCarregar(string texto, int tempo){
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write($"{texto}");
    for (var contador = 0; contador < 28; contador ++)
        {
        Console.Write(". ");
        Thread.Sleep(tempo);
        }
    Console.ResetColor();
}
