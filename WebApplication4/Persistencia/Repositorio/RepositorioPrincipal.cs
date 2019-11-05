﻿using Backend.Dominio.Entidad;
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
        PersonaEntidad camilo = new PersonaEntidad("Camilo", "1", "Colombia", 24);
        PersonaEntidad camila = new PersonaEntidad("Camila", "2", "Venezuela", 23);
        PersonaEntidad eduardo = new PersonaEntidad("Eduardo", "3", "Chile", 23);

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
            if (personas.Count() == 0)
            {
                ListaUtil.AddMany(personas, camilo, camila, eduardo);
            }
            return PersonaBuilder.convertirDeEntidadADominioLista(personas);
        }
    }
}