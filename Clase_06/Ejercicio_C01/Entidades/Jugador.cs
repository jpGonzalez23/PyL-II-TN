using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private int totalGoles;
        private int partidosJugados;
        private string nombre;
        private float promedioGoles;

        private Jugador()
        {
            this.totalGoles = 0;
            this.partidosJugados = 0;
            this.promedioGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        public float GetPromedioGoles()
        {
            return this.promedioGoles = totalGoles / partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Partidos Jugados: {this.partidosJugados}");
            sb.AppendLine($"Total de goles: {this.totalGoles}");
            sb.AppendLine($"Promedio de Goles: {this.GetPromedioGoles()}");

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
