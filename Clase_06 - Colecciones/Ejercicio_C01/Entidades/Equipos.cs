namespace Entidades
{
    public class Equipos
    {
        private string nombre;
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;

        private Equipos()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipos(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipos e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        return false;
                    }

                }
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}