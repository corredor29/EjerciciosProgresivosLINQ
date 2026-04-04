using System;
using System.Collections.Generic;
using System.Linq;
using EjerciciosProgresivosLINQ.Domain.Entities;
using EjerciciosProgresivosLINQ.Infrastructure;

namespace EjerciciosProgresivosLINQ.Aplication.Services;

public class VideoGameService
{
    public void ShowMultiplayerGames()
    {
        var videoGames = VideoGameData.GetVideoGames();
        var multiplayerGames = videoGames.Where(game => game.EsMultijugador);
        foreach (var game in multiplayerGames)
        {
            Console.WriteLine(game.Nombre);
        }
    }
}
