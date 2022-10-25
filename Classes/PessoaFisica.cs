using UC12_CLAB.Interfaces;
namespace UC12_CLAB.Classes
{
    public class PessoaFisica: Pessoa, IPessoaFisica
    {
        public string ?cpf {get;set;}
        public string ?dataNascimento {get;set;}

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        internal object ValidarDataNascimento(DateTime? dataNascimento)
        {
            throw new NotImplementedException();
        }

        /*
            public bool ValidarDataNascimento(DateTime dataNasc)
            {
                DateTime dataAtual;
                dataAtual = DateTime.Now;
                double anos;
                anos = (dataAtual - dataNasc).TotalDays/365;
                if (anos >= 18){
                    return true;
                }
                    return false;
            }
            */

        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConv;
            if (DateTime.TryParse(dataNasc, out dataConv)){
                //Console.WriteLine($"{dataConv}");   
                DateTime dataAtual =  DateTime.Today;
                double anos = (dataAtual - dataConv).TotalDays/365;
                if (anos >= 18){
                    return true;
                }
                    return false;
            }
            return false;
        }
    }

}   