namespace ScreenSound;

public class Episodio
{
    public int Ordem { get; }
    public string Titulo { get;}
    public int Duracao { get; }
    
    public string Resumo => $" {Ordem}. {Titulo} ({Duracao} minutos) - " +
                            $"{string.Join(", ", convidados)} ";
    
    private List<string> convidados = new List<string>();
    

    public Episodio(int  ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionaConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}