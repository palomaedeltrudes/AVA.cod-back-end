namespace SA2___Encontro_Remoto_2.Classes
{
    //classe Pessoa Fisica herda os atributos da superclasse Pessoa
    public class PessoaFisica : Pessoa
    {
       public string? Cpf { get; set; } 
       public DateTime DataNascimento { get; set; }
    }
}