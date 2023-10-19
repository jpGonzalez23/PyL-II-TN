using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidaDeJuagadores, string nombre)
            : this()
        {
            this.cantidadDeJugadores = cantidaDeJuagadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool result = false;
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        return result;
                    }

                }
                e.jugadores.Add(j);
                result = true;
            }

            return result;
        }
    }
}
