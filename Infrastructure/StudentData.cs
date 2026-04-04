using System;
using System.Collections.Generic;
using System.Linq;
using EjerciciosProgresivosLINQ.Domain.Entities;

namespace EjerciciosProgresivosLINQ.Infrastructure;

public static class StudentData
{
    public static List<Student> GetStudents()
    {
        return new List<Student>
        {
                new Student { Nombre = "Ana", Edad = 12, Nota = 4.8, Curso = "6A" },
                new Student { Nombre = "Luis", Edad = 13, Nota = 3.2, Curso = "6A" },
                new Student { Nombre = "Marta", Edad = 12, Nota = 4.5, Curso = "6B" },
                new Student { Nombre = "Carlos", Edad = 14, Nota = 2.9, Curso = "6B" },
                new Student { Nombre = "Sofía", Edad = 13, Nota = 5.0, Curso = "6A" }
        };
    }
}
