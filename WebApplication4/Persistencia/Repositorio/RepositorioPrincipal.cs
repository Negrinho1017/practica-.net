using Backend.Dominio.Entidad;
using Backend.Dominio.Util;
using Backend.Persistencia.Builder;
using Backend.Persistencia.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Persistencia.Repositorio
{
    public class RepositorioPrincipal : IRepositorioPrincipal<Persona>
    {
        public static List<PersonaEntidad> personas = new List<PersonaEntidad>();

        void IRepositorioPrincipal<Persona>.Add(Persona entity)
        {
            personas.Add(PersonaBuilder.convertirDeDominioAEntidad(entity));
        }

        void IRepositorioPrincipal<Persona>.Delete(string id)
        {
            PersonaEntidad personaEntidad = personas.Find(p => p.cedula == id);
            personas.Remove(personaEntidad);
        }

        void IRepositorioPrincipal<Persona>.Edit(Persona entity)
        {
            PersonaEntidad personaEliminar = personas.Find(p => p.cedula == entity.cedula);
            personas.Remove(personaEliminar);
            personas.Add(PersonaBuilder.convertirDeDominioAEntidad(entity));
        }

        Persona IRepositorioPrincipal<Persona>.GetById(string id)
        {
            PersonaEntidad personaEntidad = personas.Find(p => p.cedula == id);
            return PersonaBuilder.convertirDeEntidadADominio(personaEntidad);
        }

        IEnumerable<Persona> IRepositorioPrincipal<Persona>.List()
        {
            return PersonaBuilder.convertirDeEntidadADominioLista(personas);
        }
    }
}
