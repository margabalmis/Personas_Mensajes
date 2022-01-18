using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas_Mensajes
{
    class Persona
    {
        private string nombre;
        private string edad;
        private string nacionalidad;
        public Persona(string nombre, string edad, string nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }

    }
}