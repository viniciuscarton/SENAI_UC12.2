using UC12_CLAB.Interfaces;
using System.Text.RegularExpressions;

namespace UC12_CLAB.Classes;

    public class PessoaJuridica: Pessoa, IPessoaJuridica
    {
        public string ?cnpj {get;set;}
        public string ?razaoSoc {get;set;}

        public override float PagarImposto(float rendimento)
        {
             if (rendimento <= 1500)
            {
                return (rendimento / 100) * 3;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return (rendimento / 100) * 5;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento / 100) * 7;
            }
            else 
            {
                return (rendimento / 100) * 9;
            }
            throw new NotImplementedException();
        }

        public bool ValidarCNPJ(string cnpj)
        {
            if (Regex.IsMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)")){
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11,4) == "9012")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8,4) == "9012")
                    {
                        return true;
                    }
                }     
            }
            return false;
        }
    }
