using SA2___Encontro_Remoto_2.Interfaces;

namespace SA2___Encontro_Remoto_2.Classes
{
    //classe Pessoa Fisica herda os atributos da superclasse Pessoa
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
       public string? Cpf { get; set; } 
       public DateTime DataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {
              if(rendimento <= 1500)
           {
            return 0;
           }
           else if (rendimento >= 1501 && rendimento <= 3500)
           {
            return rendimento*0.02f;    
           }
           else if(rendimento  >= 3501 && rendimento <= 6000)
           {
            return rendimento*0.035f;
           }
           else 
           {
            return rendimento*0.05f;
           }
        }

        public bool ValidarCpf(string Cpf)
        {
            throw new NotImplementedException();
        }
    }


}

// rendimentos ate 1500, isento
// rendimentos entre 1501 e 3500, 2%
// rendimentos entre 3501 e 6000, 3,5%
// rendimentos acima de 6000, 5%