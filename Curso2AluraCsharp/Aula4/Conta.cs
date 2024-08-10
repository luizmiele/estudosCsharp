namespace Aula4;

public class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public Conta(Titular titular, int agencia, int numeroConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Saldo = saldo;
        Limite = limite;
    }

    public void ExibeDetalhes()
    {
        Console.WriteLine($"Nome: {Titular.Nome}");
        Console.WriteLine($"Idade: {Titular.Idade}");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Número da Conta: {NumeroConta}");
    }
}