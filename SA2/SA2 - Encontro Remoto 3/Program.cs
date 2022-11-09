using System.Globalization;
using SA2___Encontro_Remoto_2.Classes;


//criamos um objeto do tipo Pessoa
PessoaFisica novaPessoaFisica = new PessoaFisica();

//atribuimos um valor para as propriedades
novaPessoaFisica.Nome = "Paloma Edeltrudes";
novaPessoaFisica.Cpf = "00000000070";
novaPessoaFisica.DataNascimento = new DateTime(1992, 04, 12);
novaPessoaFisica.Rendimento = 15000.55f;

//instaciamos um objeto to tipo pessoa fisica que servira para manipular os metodos
PessoaFisica metodosPF = new PessoaFisica();

//imprimimos os valores dos objetos no console utilizando a concatenação
// Console.WriteLine("Nome: " + novaPessoaFisica.Nome);
// Console.WriteLine("Cpf: " + novaPessoaFisica.Cpf);
// Console.WriteLine("Data de Nascimento: " + novaPessoaFisica.DataNascimento);
// Console.WriteLine("Rendimento: R$" + novaPessoaFisica.Rendimento);

//imprimimos os valores dos objetos no console utilizando a interpolação
// Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
// Console.WriteLine($"Cpf: {novaPessoaFisica.Cpf}");
// Console.WriteLine($"Data de Nascimento: {novaPessoaFisica.DataNascimento}");
// Console.WriteLine($"Rendimento: R$ {novaPessoaFisica.Rendimento}");

//imprimimos os valores dos objetos no console utilizando a interpolação e quebra de linhas
Console.WriteLine(@$"
Nome: {novaPessoaFisica.Nome}
Cpf: {novaPessoaFisica.Cpf}
Data de Nascimento: {novaPessoaFisica.DataNascimento}
Rendimento: R$ {novaPessoaFisica.Rendimento}
Imposto a pagar: {novaPessoaFisica.PagarImposto(novaPessoaFisica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
");

//Criamos um objeto do tipo endereco 
//atribuimos valores para os atributos do objeto endereco
Endereço novoEndereco = new Endereço();
novoEndereco.Logradouro = "Estrada de Piraja";novoEndereco.Numero = 30;
novoEndereco.Bairro = "Piraja";
novoEndereco.Estado = "BA";
novoEndereco.Cidade = "Salvador";
novoEndereco.CEP = "41290000";
novoEndereco.Comercial = true;

//Criamos um objeto do tipo Pessoa Juridica
PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

//Atribuimos valores para as propriedades do objeto Pessoa Juridica
novaPessoaJuridica.Nome = "Navegante Automotiva";
novaPessoaJuridica.RazaoSocial = "Navegante Ltda";
novaPessoaJuridica.Cnpj = "39558343000101";
novaPessoaJuridica.Rendimento = 100000.99f;
novaPessoaJuridica.Endereço = novoEndereco;

//instaciamos um objeto to tipo pessoa juridica que servira para manipular os metodos
PessoaJuridica metodosPJ = new PessoaJuridica();


//imprimimos no console os valores do objeto utilizando interpolação e quebra de linhas
Console.WriteLine(@$"
Nome Fantasia: {novaPessoaJuridica.Nome}
Razao Social: {novaPessoaJuridica.RazaoSocial}
Cnpj: {novaPessoaJuridica.Cnpj}
Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
Endereço: {novaPessoaJuridica.Endereço.Logradouro}, {novaPessoaJuridica.Endereço.Numero}, {novaPessoaJuridica.Endereço.Bairro}, {novaPessoaJuridica.Endereço.Estado}, {novaPessoaJuridica.Endereço.Cidade}, {novaPessoaJuridica.Endereço.CEP}, {novaPessoaJuridica.Endereço.Comercial}
Imposto a pagar: {metodosPJ.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}

");

