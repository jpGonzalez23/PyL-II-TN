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

        public int Dni 
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value < 8)
                {
                    this.dni = value;
                }
            } 
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }

        public int TotalGoles 
        { 
            get
            {
                return this.totalGoles;
            }

        }

        public int PartidosJugados 
        { 
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles 
        { 
            get
            {
                return this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
            } 
        }

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

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Partidos Jugados: {this.PartidosJugados}");
            sb.AppendLine($"Total de goles: {this.TotalGoles}");
            sb.AppendLine($"Promedio de Goles: {this.PromedioGoles}");

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
