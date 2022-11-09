using System.Text.RegularExpressions;
using SA2___Encontro_Remoto_2.Interfaces;

namespace SA2___Encontro_Remoto_2.Classes
{
    //classe Pessoa Juridica herda os atributos da superclasse Pessoa
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }
        public string? Caminho { get; private set; } = "Database/PessoaJuridica.csv";
    

        public override float PagarImposto(float rendimento)
        {
           if(rendimento <= 3000)
           {
            return rendimento*0.03f;
           }
           else if (rendimento >= 3001 && rendimento <= 6000)
           {
            return rendimento*0.05f;    
           }
           else if(rendimento  >= 6001 && rendimento <= 10000)
           {
            return rendimento*0.07f;
           }
           else 
           {
            return rendimento*0.09f;
           }
        }

        public bool ValidarCnpj(string Cnpj)
        {
            if(Regex.IsMatch(Cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if(Cnpj.Length == 18)
                {
                    if(Cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (Cnpj.Length == 14)
                {
                    if(Cnpj.Substring(8,4) == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Inserir(PessoaJuridica pj)
        {
            Uteis.VerificarPastaArquivo(Caminho);

            string[] pjStrings = {$"{pj.Nome}, {pj.Cnpj}, {pj.RazaoSocial}"};

            File.AppendAllLines(Caminho, pjStrings);
        }
        public List<PessoaJuridica> LerArquivo()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(Caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }
    }
}

// rendimentos ate 3000, 3%
// rendimentos entre 3001 e 6000, 5%
// rendimentos entre 6001 e 10000, 7%
// rendimentos acima de 10000, 9%

