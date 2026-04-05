using System;
using System.Collections.Generic;
using System.Linq;
using EjerciciosProgresivosLINQ.Domain.Entities;
using EjerciciosProgresivosLINQ.Infrastructure;

namespace EjerciciosProgresivosLINQ.Aplication.Services;

public class TeamService
{
    public void ShowTeam()
    {
        // Nivel 3 Ordenar equipos por puntos
        Console.WriteLine("Ordenar equipos por puntos");
        var Teams = TeamData.GetTeams();
        var tabla = Teams.OrderByDescending(puntos => puntos.Puntos);
        foreach (var Team in tabla)
        {
            Console.WriteLine($"{Team.Nombre}-{Team.Puntos} Pts");
        }
        // Nivel 4 Revisar si existe algún equipo con menos de 10 puntos
        Console.WriteLine("Revisar si existe algún equipo con menos de 10 puntos");
        bool existe = Teams.Any(exi => exi.Puntos < 10);
        Console.WriteLine(existe);
    }
}
