using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFutbol.Models
{
    class EquipoVisitante : Equipo
    {
        public EquipoVisitante(string nombre, string jugador, string entrenador)
            : base(nombre, jugador, entrenador) { }
    }
}
