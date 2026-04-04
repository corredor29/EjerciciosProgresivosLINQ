using System;
using System.Collections.Generic;
using System.Linq;
using EjerciciosProgresivosLINQ.Domain.Entities;
using EjerciciosProgresivosLINQ.Infrastructure;


namespace EjerciciosProgresivosLINQ.Aplication.Services;

public class StudentService
{
    public void ShowStudents()
    {
        var students = StudentData.GetStudents();
        var aprobados = students.Where(alumnos => alumnos.Nota >= 3.0);
        foreach (var alumnos in aprobados)
        {
            Console.WriteLine($"{alumnos.Nombre} - {alumnos.Nota}");
        }
    }
}
