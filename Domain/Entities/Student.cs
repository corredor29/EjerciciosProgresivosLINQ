using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosProgresivosLINQ.Domain.Entities;

public class Student
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Nota { get; set; }
    public string Curso { get; set; }
}
