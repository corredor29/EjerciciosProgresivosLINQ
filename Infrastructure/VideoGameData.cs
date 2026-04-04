using System;
using System.Collections.Generic;
using System.Linq;
using EjerciciosProgresivosLINQ.Domain.Entities;

namespace EjerciciosProgresivosLINQ.Infrastructure;

public static class VideoGameData
{
    public static List<VideoGame> GetVideoGames()
    {
        return new List<VideoGame>
        {
                new VideoGame { Nombre = "Minecraft", Genero = "Sandbox", Puntos = 95, EsMultijugador = true },
                new VideoGame { Nombre = "FIFA", Genero = "Deportes", Puntos = 88, EsMultijugador = true },
                new VideoGame { Nombre = "Celeste", Genero = "Plataformas", Puntos = 92, EsMultijugador = false },
                new VideoGame { Nombre = "Mario Kart", Genero = "Carreras", Puntos = 90, EsMultijugador = true },
                new VideoGame { Nombre = "Hollow Knight", Genero = "Aventura", Puntos = 94, EsMultijugador = false }
        };
    }
}
