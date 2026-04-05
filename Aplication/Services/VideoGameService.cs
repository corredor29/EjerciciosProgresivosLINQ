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
        // Nivel 1 Filtrar solo juegos multijugador
        Console.WriteLine("Filtrar videojuegos multijugador");
        var multiplayerGames = videoGames.Where(game => game.EsMultijugador);
        foreach (var game in multiplayerGames)
        {
            Console.WriteLine(game.Nombre);
        }
        // Nivel 2 select Obtener solo los nombres de los videojuegos
        Console.WriteLine("lista con solo los nombres");
        var nameVideoGames = videoGames.Select(names => names.Nombre);
        foreach (var names in nameVideoGames)
        {
            Console.WriteLine(names);
        }
        // Nivel 4 Contar cuántos videojuegos tienen más de 90 puntos
        Console.WriteLine("Contar cuántos videojuegos tienen más de 90 puntos");
        int Cantidad = videoGames.Count(contar => contar.Puntos > 90);
        Console.WriteLine(Cantidad);
    }
}
