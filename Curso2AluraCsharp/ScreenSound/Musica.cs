namespace ScreenSound;

public class Musica
{
    public string Nome { get; }
    public  Banda Artista { get; }
    public  int Duracao { get; set; }
    public   bool Disponivel { get; set; }

    public string DescricaoResumida => $"A musica {Nome} pertence á banda {Artista}";
    

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome} ");
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