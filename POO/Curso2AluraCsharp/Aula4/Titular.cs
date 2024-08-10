namespace Aula4;

public class Titular
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    
    public string Endereco { get; set; }

    public Titular(string nome, int idade, string endereco)
    {
        Nome = nome;
        Idade = idade;
        Endereco = endereco;
    }
}