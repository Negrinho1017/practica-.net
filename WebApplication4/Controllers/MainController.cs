using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Dominio.Entidad;
using Backend.Dominio.Util;
using Backend.Persistencia.Repositorio;
using Backend.Servicio;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    public class MainController : Controller
    {
        AdministradorPersonas administradorPersonas;

        public MainController()
        {
            administradorPersonas = new AdministradorPersonas();
            administradorPersonas.repositorioPrincipal = new RepositorioPrincipal();
        }

        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return administradorPersonas.obtenerTodasLasPersonas();
        }


        [HttpGet("{cedula}")]
        public Persona Get(string cedula)
        {
            return administradorPersonas.obtenerPersonaPorCedula(cedula);
        }

        [HttpPost]
        public void Post([FromBody]Persona persona)
        {
            administradorPersonas.agregarPersona(persona);
        }

        [HttpPut("{cedula}")]
        public void Put(string cedula, [FromBody]Persona persona)
        {
            administradorPersonas.actualizarPersona(cedula, persona);
        }

        [HttpDelete("{cedula}")]
        public void Delete(string cedula)
        {
            administradorPersonas.eliminarPersona(cedula);
        }
    }
}
