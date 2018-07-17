using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Linq;
using Domain.Contracts;

namespace Domain.Academicos
{
    public class Profesor: Persona.Persona
    {
        public IEnumerable<GradoAcademico> GradosAcademicos { get; private set; }

        public GradoAcademico UltimoGradoObtenido
        {
            get { return GradosAcademicos.OrderBy(p => p.FechaObtencion).FirstOrDefault(); }
        }

        public Profesor(string nombre, DateTime fechaNacimiento, int genero, int nacionalidad, string curp, IEnumerable<GradoAcademico> gradosAcademicos) : base(nombre, fechaNacimiento, genero, nacionalidad, curp)
        {
            var banderita = true;
            foreach (var grado in gradosAcademicos)
                banderita = banderita && grado.esVigente();
            if (banderita)
            {
                GradosAcademicos = gradosAcademicos;
            }
            else throw new Exception("No sea chochino.");
        }
    }
}
