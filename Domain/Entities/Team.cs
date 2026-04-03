using System;

namespace EjerciciosProgresivosLINQ.Domain.Entities;

public class Team
{
    public string Nombre { get; set; }
    public int Puntos { get; set; }
    public int GolesFavor { get; set; }
    public int GolesContra { get; set; }
}
