using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Persistencia.Entidad
{
    public class PersonaEntidad
    {
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string nacionalidad { get; set; }
        public int edad { get; set; }

        public PersonaEntidad(string nombre, string cedula, string nacionalidad, int edad)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.nacionalidad = nacionalidad;
            this.edad = edad;
        }

        public PersonaEntidad() { }
    }
}
