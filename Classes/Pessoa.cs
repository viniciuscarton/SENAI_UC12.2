using UC12_CLAB.Interfaces;

namespace UC12_CLAB
{
    public abstract class Pessoa: IPessoa
    {
        public string ?Nome {get;set;}
        public string ?Endereco {get;set;}
        public string ?rendimento { get; set;}

        public abstract float PagarImposto(float rendimento);
       
    }
}