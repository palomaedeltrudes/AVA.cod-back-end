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

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Cadastro realizado com sucesso!");
                    Thread.Sleep(2000);
                    Console.ResetColor();
                                                                 
                        break;

                    case "2": //listar PF   

                    if (listaPF.Count > 0)
                    {
                        foreach (PessoaFisica pf in listaPF)
                        {                            
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(@$"
Nome: {pf.Nome}
CPF: {pf.Cpf}
Data de Nascimento: {pf.DataNascimento}
Endereço: {pf.Endereço.Logradouro}, {pf.Endereço.Numero}, {pf.Endereço.Bairro}, 
{pf.Endereço.Cidade}, {pf.Endereço.Estado}, {pf.Endereço.CEP}
Rendimento: {pf.Rendimento}
Imposto a pagar: {metodosPF.PagarImposto(pf.Rendimento)}
");
                            Console.ResetColor();                            
                        }                        
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Aperte ENTER para continuar.");
                        Console.ReadLine();
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Lista vazia!");
                        Console.ResetColor();                        
                    }
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

        
        Console.WriteLine(@$"
Nome Fantasia: {novaPessoaJuridica.Nome}
Razao Social: {novaPessoaJuridica.RazaoSocial}
Cnpj: {novaPessoaJuridica.Cnpj}
Cnpj valido: {(metodosPJ.ValidarCnpj(novaPessoaJuridica.Cnpj) ? "Cnpj no formato valido!" : "Cnpj fora do padrao esperado!")}
Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
Endereço: {novaPessoaJuridica.Endereço.Logradouro}, {novaPessoaJuridica.Endereço.Numero}, {novaPessoaJuridica.Endereço.Bairro}, {novaPessoaJuridica.Endereço.Estado}, {novaPessoaJuridica.Endereço.Cidade}, {novaPessoaJuridica.Endereço.CEP}, {novaPessoaJuridica.Endereço.Comercial}
Imposto a pagar: {metodosPJ.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Aperte a tecla ENTER para continuar");
            Console.ReadLine();
            Console.ResetColor();

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







































// Console.WriteLine(@$"
// Nome: {novaPessoaFisica.Nome}
// Cpf: {novaPessoaFisica.Cpf}
// Data de Nascimento: {novaPessoaFisica.DataNascimento}
// Rendimento: R$ {novaPessoaFisica.Rendimento}
// Imposto a pagar: {metodosPF.PagarImposto(novaPessoaFisica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
// Maior de Idade - datetime: {metodosPF.ValidarDataNascimento(novaPessoaFisica.DataNascimento)}
// Maior de Idade - datetime: {(metodosPF.ValidarDataNascimento(novaPessoaFisica.DataNascimento) ? "Sim" : "Nao")}
// Maior de Idade - string: {metodosPF.ValidarDataNascimento("00112/04/1992")}
// ");

//criamos um objeto do tipo Pessoa
// PessoaFisica novaPessoaFisica = new PessoaFisica();
//instaciamos um objeto to tipo pessoa fisica que servira para manipular os metodos
// PessoaFisica metodosPF = new PessoaFisica();

//atribuimos um valor para as propriedades
// novaPessoaFisica.Nome = "Paloma Edeltrudes";
// novaPessoaFisica.Cpf = "00000000070";
// novaPessoaFisica.DataNascimento = new DateTime(1992, 04, 12);
// novaPessoaFisica.Rendimento = 15000.55f;

//imprimimos os valores dos objetos no console utilizando a interpolação e quebra de linhas
// Console.WriteLine(@$"
// Nome: {novaPessoaFisica.Nome}
// Cpf: {novaPessoaFisica.Cpf}
// Data de Nascimento: {novaPessoaFisica.DataNascimento}
// Rendimento: R$ {novaPessoaFisica.Rendimento}
// Imposto a pagar: {metodosPF.PagarImposto(novaPessoaFisica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
// Maior de Idade - datetime: {metodosPF.ValidarDataNascimento(novaPessoaFisica.DataNascimento)}
// Maior de Idade - datetime: {(metodosPF.ValidarDataNascimento(novaPessoaFisica.DataNascimento) ? "Sim" : "Nao")}
// Maior de Idade - string: {metodosPF.ValidarDataNascimento("00112/04/1992")}
// ");


//Criamos um objeto do tipo endereco 
//atribuimos valores para os atributos do objeto endereco
// Endereço novoEndereco = new Endereço();
// novoEndereco.Logradouro = "Estrada de Piraja";novoEndereco.Numero = 30;
// novoEndereco.Bairro = "Piraja";
// novoEndereco.Estado = "BA";
// novoEndereco.Cidade = "Salvador";
// novoEndereco.CEP = "41290000";
// novoEndereco.Comercial = true;

//Criamos um objeto do tipo Pessoa Juridica
// PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

// //Atribuimos valores para as propriedades do objeto Pessoa Juridica
// novaPessoaJuridica.Nome = "Navegante Automotiva";
// novaPessoaJuridica.RazaoSocial = "Navegante Ltda";
// novaPessoaJuridica.Cnpj = "39558343000101";
// novaPessoaJuridica.Rendimento = 100000.99f;
// novaPessoaJuridica.Endereço = novoEndereco;

//instaciamos um objeto to tipo pessoa juridica que servira para manipular os metodos
// PessoaJuridica metodosPJ = new PessoaJuridica();

//imprimimos no console os valores do objeto utilizando interpolação e quebra de linhas
// Console.WriteLine(@$"
// Nome Fantasia: {novaPessoaJuridica.Nome}
// Razao Social: {novaPessoaJuridica.RazaoSocial}
// Cnpj: {novaPessoaJuridica.Cnpj}
// Cnpj valido: {(metodosPJ.ValidarCnpj(novaPessoaJuridica.Cnpj) ? "Cnpj no formato valido!" : "Cnpj fora do padrao esperado!")}
// Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
// Endereço: {novaPessoaJuridica.Endereço.Logradouro}, {novaPessoaJuridica.Endereço.Numero}, {novaPessoaJuridica.Endereço.Bairro}, {novaPessoaJuridica.Endereço.Estado}, {novaPessoaJuridica.Endereço.Cidade}, {novaPessoaJuridica.Endereço.CEP}, {novaPessoaJuridica.Endereço.Comercial}
// Imposto a pagar: {metodosPJ.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
// ");


//-----------------------------------------------------------------------------------------------------------------
//exemplo para validar um formato de data
// string data = "26/09/2022";
// bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
// Console.WriteLine(valido ? "Sim" : "Não");
//-----------------------------------------------------------------------------------------------------------------
//exemplo de substring com 2 argumentos (startindex e lenght)
// string nome = "Pindamonhagaba";
// string substring = nome.Substring(3, 5);
// Console.WriteLine(substring);
//-----------------------------------------------------------------------------------------------------------------
//imprimimos os valores dos objetos no console utilizando a concatenação
// Console.WriteLine("Nome: " + novaPessoaFisica.Nome);
// Console.WriteLine("Cpf: " + novaPessoaFisica.Cpf);
// Console.WriteLine("Data de Nascimento: " + novaPessoaFisica.DataNascimento);
// Console.WriteLine("Rendimento: R$" + novaPessoaFisica.Rendimento);
//-----------------------------------------------------------------------------------------------------------------
//imprimimos os valores dos objetos no console utilizando a interpolação
// Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
// Console.WriteLine($"Cpf: {novaPessoaFisica.Cpf}");
// Console.WriteLine($"Data de Nascimento: {novaPessoaFisica.DataNascimento}");
// Console.WriteLine($"Rendimento: R$ {novaPessoaFisica.Rendimento}");