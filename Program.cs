using  System;
using EjerciciosProgresivosLINQ.Aplication.Services;

class Program
{
    static void Main(string[] args )
    {
        var VideoGameService = new VideoGameService();
        var multiplayerGames = VideoGameService.GetMultiplayerGames();
        foreach (var game in multiplayerGames)
        {
            Console.WriteLine(game.Nombre);
        }
    }
}