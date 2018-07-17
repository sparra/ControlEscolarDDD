using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Domain.Contracts;

namespace Domain.Academicos
{
    public class GradoAcademico: ValueObject<GradoAcademico>
    {
        public string NombreGrado { get; set; }
        public DateTime FechaObtencion { get; private set; }
        public bool esVigente()
        {
            return true;
        }

        public GradoAcademico(string nombreGrado, DateTime fecha)
        {
            this.FechaObtencion = fecha;
            this.NombreGrado = nombreGrado;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new object[] { NombreGrado };
        }
    }
}
