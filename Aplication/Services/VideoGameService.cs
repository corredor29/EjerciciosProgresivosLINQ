using System;
using System.Collections.Generic;
using System.Linq;
using EjerciciosProgresivosLINQ.Domain.Entities;
using EjerciciosProgresivosLINQ.Infrastructure;

namespace EjerciciosProgresivosLINQ.Aplication.Services;

public class VideoGameService
{
    public IEnumerable<VideoGame> GetMultiplayerGames()
    {
        var videoGames = VideoGameData.GetVideoGames();
        return videoGames.Where(game => game.EsMultijugador);
    }
}
