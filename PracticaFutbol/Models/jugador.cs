using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFutbol.Models
{
    public class jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public int EquipoId { get; set; }  // Aseguramos que esta propiedad esté presente

        public jugador(string nombre, int numero, int equipoId)
        {
            this.Nombre = nombre;
            this.Numero = numero;
            this.EquipoId = equipoId;
        }

        public override string ToString()
        {
            return $"{Nombre} - Número: {Numero}";
        }
    }
}