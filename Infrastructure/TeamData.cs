using System;
using System.Collections.Generic;
using System.Linq;
using EjerciciosProgresivosLINQ.Domain.Entities;

namespace EjerciciosProgresivosLINQ.Infrastructure;

public static class TeamData
{
    public static List<Team> GetTeams()
    {
        return new List<Team>
        {
                new Team { Nombre = "Tigres FC", Puntos = 15, GolesFavor = 12, GolesContra = 6 },
                new Team { Nombre = "Leones FC", Puntos = 22, GolesFavor = 18, GolesContra = 10 },
                new Team { Nombre = "Águilas FC", Puntos = 19, GolesFavor = 10, GolesContra = 5 },
                new Team { Nombre = "Toros FC", Puntos = 8, GolesFavor = 6, GolesContra = 14 }
        };
    }
}
