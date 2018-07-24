using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using Domain.Academicos;

namespace Domain.Kardex
{
    //Implementar el Kardex en un modelo que intermedia Estudiantes y Cursos.
    public class Kardex
    {
        public Estudiante.Estudiante Alumno { get; private set; }
        public Curso.Curso Curso { get; private set; }
        public Profesor Profesor { get; private set; }
        public decimal Calificacion { get; set; }

        public bool Aprobado => Calificacion > 5.99m;

        public Kardex(Estudiante.Estudiante estudiante, Curso.Curso curso, Profesor profesor)
        {
            Alumno = estudiante;
            Curso = curso;
            Profesor = profesor;
        }

        public void CalificaCurso(decimal calificacion)
        {
            //TODO La hacemos de jamon para poner la calificacion
            this.Calificacion = calificacion;
        }
    }
}
