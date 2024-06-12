using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFutbol.Models
{
    internal class Equipo
    {
        public string nombre { get; set; }

        public List<jugador> jugadores { get; set; }

        public string entrenador { get; set; }

        public Equipo (string nombre, string jugadores, string entrenador)
        {
            this.nombre = nombre;

            this.jugadores = new List<jugador>();

            this.entrenador = entrenador;
        }

        public void agregarJugador(jugador jugador)
        {
            jugadores.Add(jugador);
        }

        public void quitarJugador (jugador jugador)
        {
            jugadores.Remove(jugador);
        }

        public List<jugador> obtenerJugadores()
        {
            return jugadores;
        }

        public void cambiarEntrenador(string nuevoEntrenador)
        {
            entrenador = nuevoEntrenador;
        }

    }
}
