using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFutbol.Models
{
    internal class EquipoLocal : Equipo, IPartido
    {
        public EquipoLocal(string nombre, string jugador, string entrenador)
            : base (nombre, jugador, entrenador) { } //Para poder heredar una clase hay que pasarle los atributos antes.

         public void simularPartido() //Para poder heredar la Interfaz hay que pasarle los metodos.
        {

        }
    }
}
