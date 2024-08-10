using ScreenSound;
/*
Banda slipknot = new Banda("Slipknot");

Album albumSlipknot = new Album("All Hope Is Gone");

Musica musica1 = new Musica(slipknot, "Psychosocial")
{
    Duracao = 250,
    Disponivel = true,
};
Musica musica2 = new Musica(slipknot, "Snuff")
{
    Duracao = 200,
    Disponivel = true,
};

Musica musica3 = new Musica(slipknot, "Dead Memories")
{
    Duracao = 350,
    Disponivel = true,
};

Musica musica4 = new Musica(slipknot, "Sulfur")
{
    Duracao = 250,
    Disponivel = true,
};

Musica musica5 = new Musica(slipknot,"All Hope Is Gone")
{
    Duracao = 450,
    Disponivel = true,
};

albumSlipknot.adicionarMusica(musica1);
albumSlipknot.adicionarMusica(musica2);
albumSlipknot.adicionarMusica(musica3);
albumSlipknot.adicionarMusica(musica4);
albumSlipknot.adicionarMusica(musica5);
slipknot.AdicionaAlbum(albumSlipknot);


musica1.ExibirFichaTecnica();
albumSlipknot.ExibirMusicasAlbum();
slipknot.ExibirDiscografia();
*/

// PODCASTS 

Episodio ep1 = new(1,"Pilot", 60);
ep1.AdicionaConvidado("Jorge");
ep1.AdicionaConvidado("Paulo");

Episodio ep2 = new(2,"Ep 2", 200);
ep2.AdicionaConvidado("Ale");
ep2.AdicionaConvidado("Carlos");
ep2.AdicionaConvidado("Claudia");

Podcast podcast = new("PodNome", "Miele");
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep1);
podcast.ExibirDetalhes();
