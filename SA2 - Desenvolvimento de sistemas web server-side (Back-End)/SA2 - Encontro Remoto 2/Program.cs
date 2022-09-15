using SA2___Encontro_Remoto_2.Classes;


//criamos um objeto do tipo Pessoa
PessoaFisica novaPessoaFisica = new PessoaFisica();

//atribuimos um valor para as propriedades
novaPessoaFisica.Nome = "Paloma Edeltrudes";
novaPessoaFisica.Cpf = "00000000070";
novaPessoaFisica.DataNascimento = new DateTime(1992, 04, 12);
novaPessoaFisica.Rendimento = 15000.55f;

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
");

//Criamos um objeto do tipo Pessoa Juridica
PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

//Atribuimos valores para as propriedades do objeto Pessoa Juridica
novaPessoaJuridica.Nome = "Navegante Automotiva";
novaPessoaJuridica.RazaoSocial = "Navegante Ltda";
novaPessoaJuridica.Cnpj = "39558343000101";
novaPessoaJuridica.Rendimento = 100000.99f;

//imprimimos no console os valores do objeto utilizando interpolação e quebra de linhas
Console.WriteLine(@$"
Nome Fantasia: {novaPessoaJuridica.Nome}
Razao Social: {novaPessoaJuridica.RazaoSocial}
Cnpj: {novaPessoaJuridica.Cnpj}
Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
");

