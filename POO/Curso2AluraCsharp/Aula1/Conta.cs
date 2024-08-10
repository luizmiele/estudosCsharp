namespace Aula1;

public class Conta
{
    public int Id;
    public string Titular;
    public double Saldo;
    public string senha;
    
    public void ExibirInfos()
    { 
       Console.WriteLine($"ID: {Id}");
       Console.WriteLine($"Titular: {Titular}");
       Console.WriteLine($"Saldo: {Saldo}");
    }
}