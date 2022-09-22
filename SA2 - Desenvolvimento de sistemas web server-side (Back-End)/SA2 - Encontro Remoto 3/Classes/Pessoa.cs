using SA2___Encontro_Remoto_2.Interfaces;

namespace SA2___Encontro_Remoto_2.Classes
{
    //classe pessoa. superclasse/abstrata
    public abstract class Pessoa : IPessoa
    {
       //atributos da classe pessoa
       public string? Nome { get; set; }
       public Endereço? Endereço { get; set; }    
       public float Rendimento { get; set; }

        public abstract float PagarImposto(float rendimento);
        
    }
}

//metodos acessores > get: leitura set: edição
//por padrao os metodos acessores sao publicos, mas podemos usar privado caso tenha necessidade.