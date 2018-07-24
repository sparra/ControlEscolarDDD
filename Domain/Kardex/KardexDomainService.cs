using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Kardex
{
    public class HistoriaAcademicaDomainService
    {
        private readonly HistoriaAcademica _historiaAcademica;
        public HistoriaAcademicaDomainService(HistoriaAcademica historiaAcademica)
        {
            this._historiaAcademica = historiaAcademica;
        }
        
        public string GetNombreEstudiante()
        {
            //return _kardex.Alumno.Nombre;
            throw new NotImplementedException();
        }

        public decimal GetPromedio()
        {
            var promedio = 0.0m;
            foreach (var kardex in _historiaAcademica.ListaCursos)
            {
                promedio += kardex.Calificacion;
            }
            //TODO: Invocar una funcion ad-hoc para el cálculo del numero de cursos aprobados.
            return promedio / _historiaAcademica.ListaCursos.Count();
        }
    }
}
