using System;

namespace Domain.Curso
{
    public class Curso
    {
        public int NRC { get; }
        public string Nombre { get; }
        public string Periodo { get; set; }
        public Curso(int nrc , string nombre)
        {
            NRC = nrc;
            Nombre = nombre;

            //TODO: Validar inicialización
        }
    }
}
