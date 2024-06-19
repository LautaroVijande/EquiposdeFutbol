using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFutbol.Models
{
    public class Entrenadores
    {

        public int Id { get; set; }
        public string Nombre { get; set; }


        public Entrenadores(string nombre)
        {
            this.Nombre = nombre;
        }
      

        public string Buscar (string nombre)
        {
            return Nombre;
        }

    }

   
}
