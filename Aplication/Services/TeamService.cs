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
    }
}
