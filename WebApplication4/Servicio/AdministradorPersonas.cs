using Backend.Dominio.Entidad;
using Backend.Dominio.Util;
using Backend.Persistencia.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Servicio
{
    public class AdministradorPersonas
    {

        public IRepositorioPrincipal<Persona> repositorioPrincipal { get; set; }

        public IEnumerable<Persona> obtenerTodasLasPersonas()
        {
            if (repositorioPrincipal.List().Count() == 0)
            {
                repositorioPrincipal.Add(new Persona("Camilo", "1", "Colombia", 24));
                repositorioPrincipal.Add(new Persona("Camila", "2", "Venezuela", 23));
                repositorioPrincipal.Add(new Persona("Eduardo", "3", "Chile", 23));
            }
            return repositorioPrincipal.List();
        }

        public Persona obtenerPersonaPorCedula(string cedula)
        {
            return repositorioPrincipal.GetById(cedula);
        }

        public void agregarPersona(Persona persona)
        {
            repositorioPrincipal.Add(persona);
        }

        public void actualizarPersona(string cedula, Persona persona)
        {
            repositorioPrincipal.Edit(persona);
        }

        public void eliminarPersona(string cedula)
        {
            repositorioPrincipal.Delete(cedula);
        }
    }
}
