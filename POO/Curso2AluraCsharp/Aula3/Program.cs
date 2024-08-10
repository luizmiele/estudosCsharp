using Aula3;

// 1- Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência,
// número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.

// 2- Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.

Conta conta1 = new();
Titular titular1 = new();

titular1.Nome = "Luiz Miele";
titular1.Idade = 31;

conta1.Titular = titular1;
conta1.Agencia = 1;
conta1.NumeroConta = 12345;
conta1.Saldo = 1000.0;
conta1.Limite = 10000.0;

/*
Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"Nome: {conta1.Titular.Nome}");
Console.WriteLine($"Idade: {conta1.Titular.Idade}");
*/

// 3- Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos
// produtos, e exibir todos os produtos no estoque.



