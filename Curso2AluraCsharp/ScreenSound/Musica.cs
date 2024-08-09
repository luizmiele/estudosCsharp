namespace ScreenSound;

public class Musica
{
    public string Nome { get; set; }
    public  string Artista { get; set; }
    public  int Duracao { get; set; }
    public   bool Disponivel { get; set; }

    public string DescricaoResumida => $"A musica {Nome} pertence á banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista:{Artista} ");
        Console.WriteLine($"Duração em segundos: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no seu plano!\n");
        }
        else
        {
            Console.WriteLine("Não esta disponivel\n");
        }
    }
}