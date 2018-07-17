using System;
using System.IO;
using Domain.Persona;

namespace Domain.Estudiante
{
    public class Estudiante : Domain.Persona.Persona
    {
        public string Matricula { get; private set; }
        public string Carrera { get; private set; }
        public bool StatusInscripcion { get; private set; }

        public Estudiante(string nombre, DateTime fechaNacimiento, int genero, int nacionalidad, string curp) : base(nombre, fechaNacimiento, genero, nacionalidad, curp)
        {

        }
    }



}
