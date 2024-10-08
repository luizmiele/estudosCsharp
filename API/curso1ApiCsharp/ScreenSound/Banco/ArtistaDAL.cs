﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class ArtistaDAL : DAL<Artista>
{
    private readonly ScreenSoundContext context;

    public ArtistaDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public override void Adicionar(Artista artista)
    {
        context.Artistas.Add(artista);
        context.SaveChanges();
    }

    public override IEnumerable<Artista> Listar()
    {
        return context.Artistas.ToList();
    }

    public Artista? RecuperarPeloNome(string nome)
    {
        return context.Artistas.FirstOrDefault(artista => artista.Nome.Equals(nome));
    }

    
    public override void Atualizar(Artista artista)
    {
        context.Artistas.Update(artista);
        context.SaveChanges();
    }

    public override void Deletar(Artista artista)
    {
        context.Artistas.Remove(artista);
        context.SaveChanges();
    }
    
}
