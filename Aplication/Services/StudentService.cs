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
        // nivel 1 Filtrar estudiantes aprobados
        Console.WriteLine("Filtrar estudiantes aprobados");
        var students = StudentData.GetStudents();
        var aprobados = students.Where(alumnos => alumnos.Nota >= 3.0);
        foreach (var alumnos in aprobados)
        {
            Console.WriteLine($"{alumnos.Nombre} - {alumnos.Nota}");
        }
        // Nivel 2 nombre y curso de cada estudiante
        Console.WriteLine("nombre y curso de cada estudiante");
        var nameStudent = students.Select(name => $"{name.Nombre} - {name.Curso}");
        foreach ( var name in nameStudent)
        {
            Console.WriteLine(name);
        } 
    }

}
