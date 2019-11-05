using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Dominio.Entidad
{
    public class Persona
    {
        public string nombre;
        public string cedula;
        public string nacionalidad;
        public int edad;

        public Persona(string nombre, string cedula, string nacionalidad, int edad)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.nacionalidad = nacionalidad;
            this.edad = edad;
        }

        public Persona() { }

        public string getNombre()
        {
            return nombre;
        }

        public string getCedula()
        {
            return cedula;
        }

        public string getNacionalidad()
        {
            return nacionalidad;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setCedula(string cedula)
        {
            this.cedula = cedula;
        }

        public void setNacionalidad(string nacionalidad)
        {
            this.nacionalidad = nacionalidad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
