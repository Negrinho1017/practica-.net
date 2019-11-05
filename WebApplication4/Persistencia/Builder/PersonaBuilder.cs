using Backend.Dominio.Entidad;
using Backend.Persistencia.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Persistencia.Builder
{
    public static class PersonaBuilder
    {
        public static Persona convertirDeEntidadADominio(PersonaEntidad personaEntidad)
        {
            Persona persona = new Persona();
            persona.nombre = personaEntidad.nombre;
            persona.cedula = personaEntidad.cedula;
            persona.edad = personaEntidad.edad;
            persona.nacionalidad = personaEntidad.nacionalidad;
            return persona;
        }

        public static PersonaEntidad convertirDeDominioAEntidad(Persona persona)
        {
            PersonaEntidad personaEntidad = new PersonaEntidad();
            personaEntidad.nombre = persona.nombre;
            personaEntidad.cedula = persona.cedula;
            personaEntidad.edad = persona.edad;
            personaEntidad.nacionalidad = persona.nacionalidad;
            return personaEntidad;
        }

        public static List<Persona> convertirDeEntidadADominioLista(List<PersonaEntidad> personasEntidad)
        {
            List<Persona> personas = new List<Persona>();
            foreach(PersonaEntidad personaEntidad in personasEntidad)
            {
                personas.Add(convertirDeEntidadADominio(personaEntidad));
            }
            return personas;
        }

        public static List<PersonaEntidad> convertirDeDominioAEntidadLista(List<Persona> personas)
        {
            List<PersonaEntidad> personasEntidad  = new List<PersonaEntidad>();
            foreach (Persona persona in personas)
            {
                personasEntidad.Add(convertirDeDominioAEntidad(persona));
            }
            return personasEntidad;
        }
    }
}
