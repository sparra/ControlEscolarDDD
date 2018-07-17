using System;
using Domain.Contracts;

namespace Domain.Persona
{
    public abstract class Persona : Entity
    {
        public string Nombre { get; set; }
        public int Genero { get; set; }
        public int Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CURP { get; set; }

        public Persona(string nombre, DateTime fechaNacimiento, int genero, int nacionalidad, string curp)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
            Nacionalidad = nacionalidad;
            CURP = curp;

            //TODO: validar inicialización
        }
    }
}
