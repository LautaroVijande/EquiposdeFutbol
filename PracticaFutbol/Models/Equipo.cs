using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFutbol.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public List<jugador> Jugadores { get; set; }

        public Equipo(string nombre, string entrenador)
        {
            this.Nombre = nombre;
            this.Entrenador = entrenador;
            Jugadores = new List<jugador>();
        }

        public void AgregarJugador(jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public bool BuscarJugador(string nombre)
        {
            return Jugadores.Exists(j => j.Nombre == nombre);
        }

        public void BorrarJugador(jugador jugador)
        {
            Jugadores.Remove(jugador);
            Console.WriteLine($"Se eliminó el jugador {jugador} correctamente");
        }
    }
}