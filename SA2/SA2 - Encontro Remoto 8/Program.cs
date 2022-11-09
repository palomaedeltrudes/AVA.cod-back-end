using System.Globalization;
using System.Text.RegularExpressions;
using SA2___Encontro_Remoto_2.Classes;

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkCyan;

Console.WriteLine(@$"
===============================================
|    Bem vindo ao Sistema de Cadastro de      |                             
|        Pessoas Fisicas e Juridicas          |
===============================================
");

Console.ResetColor();

Uteis.BarraCarregamento("Iniciando", 500, 3);

//lista para armazenar as pessoas fisicas cadastradas
List<PessoaFisica> listaPF = new List<PessoaFisica>();

string? opcao;

do
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.DarkBlue;

    Console.WriteLine(@$"
===============================================
|    Escolha uma das opções abaixo:           |
|---------------------------------------------|                             
|      1 - Pessoa Fisica                      |
|      2 - Pessoas Juridica                   |
|      0 - Sair                               |
===============================================
");
    Console.ResetColor();

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPF;

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(@$"
===============================================
|    Escolha uma das opções abaixo:           |
|---------------------------------------------|                             
|      1 - Cadastrar Pessoa Fisica            |
|      2 - Listar Pessoas Fisicas             |
|      0 - Voltar ao menu anterior            |
===============================================
");
                Console.ResetColor();

                opcaoPF = Console.ReadLine();
                
                PessoaFisica metodosPF = new PessoaFisica();

                switch (opcaoPF)
                {
                   case "1":
                   //cadastrar PF
                    PessoaFisica novaPessoaFisica = new PessoaFisica();
                    Endereço novoEnderecoPF = new Endereço();

                    Console.WriteLine(@$"Digite o nome completo: ");
                    novaPessoaFisica.Nome = Console.ReadLine();

                    Console.WriteLine(@$"Digite o numero do CPF: ");
                    novaPessoaFisica.Cpf = Console.ReadLine();

                    bool dataValida;

                    do
                    {
                        Console.WriteLine(@$"Digite a data de nascimento: ex: DD/MM/YYYY");
                        string? dataNascimento = Console.ReadLine();

                        dataValida = metodosPF.ValidarDataNascimento(dataNascimento);

                        if (dataValida)
                        {
                            DateTime dataConvertida;

                            DateTime.TryParse(dataNascimento, out dataConvertida);
                            
                            novaPessoaFisica.DataNascimento = dataConvertida;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Data invalida! Favor digitar uma data valida.");
                            Console.ResetColor();
                        }
                    } while (dataValida == false);


                    Console.WriteLine($"Informe o rendimento mensal - (apenas numeros): "); 

                    novaPessoaFisica.Rendimento = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o logradouro: ");
                    novoEnderecoPF.Logradouro = Console.ReadLine();

                    Console.WriteLine($"Digite o numero: ");
                    novoEnderecoPF.Numero = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o bairro: ");
                    novoEnderecoPF.Bairro = Console.ReadLine();

                     Console.WriteLine($"Digite a cidade: ");
                    novoEnderecoPF.Cidade = Console.ReadLine();

                     Console.WriteLine($"Digite o estado: ");
                    novoEnderecoPF.Estado = Console.ReadLine();

                     Console.WriteLine($"Digite o CEP: ");
                    novoEnderecoPF.CEP = Console.ReadLine();

                    Console.WriteLine($"O endereço é comercial? S para sim ou N para nao: ");
                    string? endCom = Console.ReadLine().ToUpper();

                    if (endCom == "S")
                    {
                       novoEnderecoPF.Comercial = true; 
                    }
                    else
                    {
                       novoEnderecoPF.Comercial = false; 
                    }

                    novaPessoaFisica.Endereço = novoEnderecoPF;

                    //add a pessoa cadastrada dentro da lista
                    listaPF.Add(novaPessoaFisica);


                    // StreamWriter SW = new StreamWriter($"{novaPessoaFisica.Nome}.txt");
                    // SW.WriteLine(novaPessoaFisica.Nome);
                    // SW.Close();

                    using (StreamWriter SW = new StreamWriter($"{novaPessoaFisica.Nome}.txt"))
                    {
                       SW.WriteLine(novaPessoaFisica.Nome); 
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Cadastro realizado com sucesso!");
                    Thread.Sleep(2000);
                    Console.ResetColor();
                                                                 
                        break;

                    case "2": //gerar arquivo txt   

                        using (StreamReader SR = new StreamReader("Paloma Edeltrudes.txt"))
                        {
                          string? linha;

                          while ((linha = SR.ReadLine()) != null)
                          {
                            Console.WriteLine($"{linha}");                            
                          }  
                        }

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Aperte a tecla ENTER para continuar");
                        Console.ReadLine();
                        Console.ResetColor();

                        break;

                    case "0": //voltar ao menu anterior 

                        Console.Clear();
                        break; 

                  default:
                  
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Opção inválida! Por favor digite outra opção.");  
                    Console.ResetColor();                 
                    break;
                }      
                
            } while (opcaoPF != "0");         
                       
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Aperte a tecla ENTER para continuar");
            Console.ReadLine();
            Console.ResetColor();

        break;

        case "2":

            Endereço novoEndereco = new Endereço();
            novoEndereco.Logradouro = "Estrada de Piraja";novoEndereco.Numero = 30;
            novoEndereco.Bairro = "Piraja";
            novoEndereco.Estado = "BA";
            novoEndereco.Cidade = "Salvador";
            novoEndereco.CEP = "41290000";
            novoEndereco.Comercial = true;

            PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
            novaPessoaJuridica.Nome = "Navegante Automotiva";
            novaPessoaJuridica.RazaoSocial = "Navegante Ltda";
            novaPessoaJuridica.Cnpj = "39558343000101";
            novaPessoaJuridica.Rendimento = 100000.99f;
            novaPessoaJuridica.Endereço = novoEndereco;

            PessoaJuridica metodosPJ = new PessoaJuridica();

            metodosPJ.Inserir(novaPessoaJuridica);

            List<PessoaJuridica> listaPj = metodosPJ.LerArquivo();

            foreach (PessoaJuridica cadaItem in listaPj)
            {
                Console.WriteLine(@$"
                Nome Fantasia: {cadaItem.Nome}
                Cnpj: {cadaItem.Cnpj}
                Razao Social: {cadaItem.RazaoSocial}
                ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Aperte a tecla ENTER para continuar");
                Console.ReadLine();
                Console.ResetColor();
                
            }
              
        break;

        case "0":

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigada por utilizar nosso sistema!");
            Console.ResetColor();

            Uteis.BarraCarregamento("Sistema Finalizando", 500, 3);

        break;
        
        default:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Opção inválida! Tente novamente.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Aperte a tecla ENTER para continuar");
            Console.ReadLine();
            Console.ResetColor();

        break;
    }
} 
while (opcao != "0");
