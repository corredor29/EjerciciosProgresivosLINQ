using  System;
using EjerciciosProgresivosLINQ.Aplication.Services;

class Program
{
    static void Main(string[] args )
    {
        var VideoGameService = new VideoGameService();
        VideoGameService.ShowMultiplayerGames();

        var StudentService = new StudentService();
        StudentService.ShowStudents();

        var TeamService = new TeamService();
        TeamService.ShowTeam();
    }
}