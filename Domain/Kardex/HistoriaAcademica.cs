using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Kardex
{
    public class HistoriaAcademica
    {
        public IEnumerable<Kardex> ListaCursos { get; private set; }

        public HistoriaAcademica(IEnumerable<Kardex> listaCursos)
        {
            this.ListaCursos = listaCursos;
        }

        public HistoriaAcademica()
        {
        }
    }
}
