namespace SA2___Encontro_Remoto_2.Classes
{
    //classe pessoa. superclasse/abstrata
    public abstract class Pessoa
    {
       //atributos da classe pessoa
       public string? Nome { get; set; }
       public string? Endereço { get; set; }    
       public float Rendimento { get; set; }
    }
}

//metodos acessores > get: leitura set: edição