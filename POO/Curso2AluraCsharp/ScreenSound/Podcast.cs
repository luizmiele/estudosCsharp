namespace ScreenSound;

public class Podcast
{
    public string Nome { get;}
    public string Host { get;}
    public int TotalEpisodios => Episodios.Count;
    
    private List<Episodio>  Episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}, Host: {Host}\n");
        
        foreach (var episodio in Episodios.OrderBy(ep => ep.Ordem))
        {
            Console.WriteLine($"Episódio: {episodio.Resumo}");
        }
        Console.WriteLine($"\n\nTotal de Episódios: {TotalEpisodios}");
    }
}