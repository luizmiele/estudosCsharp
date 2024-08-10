using Aula1;

Conta conta1 = new Conta();
conta1.Id = 1;
conta1.Titular = "Jorge";
conta1.Saldo = 1000;
conta1.senha = "123";

//conta1.ExibirInfos();


// Carro 

Carro carro1 = new Carro();
carro1.fabricante = "Ford";
carro1.modelo = "Mustang";
carro1.ano = 2022;
carro1.quantidadePortas = 4;

carro1.exibirInformacoes();

Console.WriteLine($"Velocidade do carro: {carro1.velocidade}");
carro1.acelerar();
carro1.acelerar();
carro1.acelerar();
carro1.acelerar();
carro1.acelerar();
carro1.acelerar();
carro1.acelerar();

Console.WriteLine($"Velocidade do carro: {carro1.velocidade}");

carro1.frear();
carro1.frear();
carro1.frear();
Console.WriteLine($"Velocidade do carro: {carro1.velocidade}");

carro1.buzinar();
