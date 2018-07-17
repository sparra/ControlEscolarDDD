using System;
using System.Collections.Generic;
using System.Text;
using Domain.Academicos;
using Domain.Kardex;

namespace Domain.Curso
{
    //La ubicación de este servicio de dominio podría ser temporal en función de la arquitectura del espacio solución.
    public class CursoDomainService
    {
        public CursoDomainService()
        {
            //Inicializar y validar propiedades y campos.
        }
        public void EvaluaCurso(Curso curso, Profesor profesor, Estudiante.Estudiante estudiante,  decimal calificacion)
        {
            //TODO : Evaluar el Curso a través del Kardex
            var kardex = new Kardex.Kardex();
        }
    }
}
