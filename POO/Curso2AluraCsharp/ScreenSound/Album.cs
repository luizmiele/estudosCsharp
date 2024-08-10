namespace ScreenSound;

public class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public int duracaoTotal => musicas.Sum(music => music.Duracao);

    public void adicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public Album(string nome)
    {
        Nome = nome;
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de musicas do Album: {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"{musica.Nome} - {musica.Duracao} segundos");
        }
        Console.WriteLine($"\nDuracao total do album: {duracaoTotal} segundos");
    }
}