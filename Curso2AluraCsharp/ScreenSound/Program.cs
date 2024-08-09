using ScreenSound;

Musica musica1 = new Musica();
musica1.Nome = "Duality";
musica1.Artista = "Slipknot";
musica1.Duracao = 100;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

musica1.ExibirFichaTecnica();

/*
Musica musica2 = new Musica();
musica2.nome = "Lost";
musica2.artista = "Linkin Park";
musica2.duracao = 120;
musica2.disponivel = false;

musica2.ExibirFichaTecnica();
*/
