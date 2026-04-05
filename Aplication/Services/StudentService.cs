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
        // Nivel 3 Ordenar estudiantes por nota y luego por nombre
        Console.WriteLine("Ordenar estudiantes por nota y luego por nombre");

        var notaStudent =students.OrderByDescending(nota => nota.Nota).ThenBy(nota => nota.Nombre);
        foreach ( var notas in notaStudent)
        {
            Console.WriteLine($"{notas.Nombre} - {notas.Nota}");
        }
        // Nivel 5 Buscar el mejor estudiante
        Console.WriteLine("Buscar el mejor estudiante");

        var bestStudent = students.OrderByDescending(best => best.Nota).FirstOrDefault();
        Console.WriteLine($"{bestStudent?.Nombre}-{bestStudent?.Nota}");

        // Nivel 5 Agrupar estudiantes por curso
        Console.WriteLine("Agrupar estudiantes por curso");

        var grupos =students.GroupBy(e => e.Curso);
        foreach (var grupo in grupos)
        {
            Console.WriteLine($"Curso:{grupo.Key}");
            foreach (var student in grupo)
            {
                Console.WriteLine($"-{student.Nombre}");
            }
        }

    }

}
