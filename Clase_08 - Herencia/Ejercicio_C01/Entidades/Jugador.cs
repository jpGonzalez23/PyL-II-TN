using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(long dni, string nombre) : base(dni, nombre)
        {
        }

        public Jugador(long dni, string nombre, int partidosJugados, int totalGoles)
            :this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados 
        { 
            get
            {
                return this.partidosJugados;
            }
            set 
            {
                if (value > 0)
                {
                    this.partidosJugados = value;
                }
            } 
        }
        public int TotalGoles 
        {  
            get { return this.totalGoles; }
            set
            {
                if (value > 0)
                {
                    this.totalGoles = value;
                }
            }
        }

        public float PromedioDeGoles
        {
            get { return (float)this.TotalGoles / this.PartidosJugados; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Total de goles: {this.TotalGoles}");
            sb.AppendLine($"Partidos Jugados: {this.PartidosJugados}");
            sb.AppendLine($"Promedio de goles: {this.PromedioDeGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni ? true : false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
