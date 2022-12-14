# Sistema de cadastro de **pessoas físicas** e **jurídicas**
![versão](https://img.shields.io/badge/vers%C3%A3o-1.1-blue)

## Novidades
* Os dados dos usuários agora são salvos em dois arquivos .csv.
## Features
* Cadastro de pessoas físicas ou jurídicas;
  
🚶 **Pessoas físicas:** nome, CPF, data de nascimento, endereço (logradouro, número e complemento) e rendimento (mensal). 

🏢  **Pessoas jurídicas:** nome, CNPJ, razão social, endereço (logradouro, número e complemento) e rendimento (mensal).
*  Cálculo do imposto devido do usuário com base no rendimento mensal. Esse cálculo foi implementado de acordo com a seguinte alíquota: 

|Pessoa  | Faixa 1 | Faixa 2| Faixa 3 | Faixa 4 |
|------  | --------| -------|-------- |---------|
|Física  |0%       | 2%     |3,5%     |5%       |
|Jurídica|5%       | 5%     |7%       |9%       |

💸 **Faixa 1:** menos de R$ 1500,00 por mês;<br />
💸 **Faixa 2:** entre R$ 1501,00 e R$ 3.500,00;<br />
💸 **Faixa 3:** entre R$ 3501,00 e R$ 6.000,00;<br />
💸 **Faixa 4:** acima de R$ 6.001,00. 


Os dados dos usuários são salvos nos arquivos *PessoaFisica.csv* e *PessoaJuridica.csv* (📂\UC12_CLAB_v2\Database).

## Tecnologias utilizadas
* C#;
* .NET SDK v. 6.0.402;
*  Virtual Studio Code v. 1.70.0;
*  OS: Windows 11 x64.
## Pré-requisitos
* .NET 6 ou superior.
## Execução da aplicação
* Execute o arquivo *UC12_CLAB.exe*.
## Erros comuns
Os campos CPF, CNPJ, número (do endereço) e data de nascimento são obrigatoriamente numéricos. Qualquer outro tipo de input não será reconhecido pela aplicação.   

A data de nascimento admite os formatos DD/MM/AAAA e DD-MM-AAAA.
O CPF admite os formatos XXXXXXXXXXX, XXX.XXX.XXX.XX e XXX.XXX.XXX-XX.
O CNPJ **apenas** o formato XX.XXX.XXX/0001-XX.

## Contribuidores
    Vinicius Antonio Scarton das Neves: https://github.com/viniciuscarton

    Professor Luiz Lozano: https://github.com/professorlozano

    SENAI: https://sp.senai.br/


