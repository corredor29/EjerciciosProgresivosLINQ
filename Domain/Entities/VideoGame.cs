using System;

namespace EjerciciosProgresivosLINQ.Domain.Entities;

public class VideoGame
{
    public string Nombre { get; set; }
    public string Genero { get; set; }
    public int Puntos { get; set; }
    public bool EsMultijugador { get; set; }
}
