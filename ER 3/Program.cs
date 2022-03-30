// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodoPf = new PessoaFisica();
Endereco novoEnd = new Endereco();



//Console.WriteLine("Nome: " + novaPf.nome); // concatenacao
//Console.WriteLine($"Nome: {novaPf.nome}"); // interpolacao

novaPf.nome = "Raissa";
novaPf.dataNascimento = "01/02/1999";
novaPf.cpf = "123456790";
novaPf.rendimento = 15000.5f; // f converte o tipo de retorno para float (8 casas decimais)
novoEnd.Logradouro = "Rua a";
novoEnd.Numero = 0123;
novoEnd.Complemento = "Rua, 0000";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;


//Console.WriteLine($"Nome:  {novaPf.nome}");
//Console.WriteLine($"Endereco : {novaPf.endereco.Logradouro}, {novaPf.endereco.Numero}" );

Console.WriteLine(@$"
Nome:  {novaPf.nome}
Endereco : {novaPf.endereco.Logradouro}, {novaPf.endereco.Numero}
Maior de idade : {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");

