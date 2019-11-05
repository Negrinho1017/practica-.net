using Frontend.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class ProductList : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var a = "jaja";
  
        }

        public List<Persona> GetPersonas()
        {
            Persona persona1 = new Persona() { nombre = "Camilo", cedula = "1234", nacionalidad = "Colombia", edad = 24 };
            Persona persona2 = new Persona() { nombre = "Alex", cedula = "12345", nacionalidad = "Colombia", edad = 21 };
            List<Persona> personas = new List<Persona>();
            personas.Add(persona1);
            personas.Add(persona2);
            return personas;
        }
    }
}