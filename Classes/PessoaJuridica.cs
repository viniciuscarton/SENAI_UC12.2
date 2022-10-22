using UC12_CLAB.Interfaces;
namespace UC12_CLAB
{
    public class PessoaJuridica: Pessoa, IPessoaJuridica
    {
        public string ?cnpj {get;set;}
        public string ?razaoSoc {get;set;}

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCNPJ(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}