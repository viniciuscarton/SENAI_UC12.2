using UC12_CLAB.Interfaces;

namespace UC12_CLAB.Classes
{
    public abstract class Pessoa: IPessoa
    {
        public string ?Nome {get;set;}
        public Endereco ?Endereco {get;set;}
        public float rendimento { get; set;}

        public abstract float PagarImposto(float rendimento);
       
    }
}