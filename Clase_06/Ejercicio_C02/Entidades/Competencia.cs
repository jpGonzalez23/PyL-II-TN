using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadVueltas;
        private short cantidadCompetidores;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("--------COMPETENCIA------");
            sb.AppendLine("COMPETIDORES: " + this.cantidadCompetidores);
            
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine("----------------------");
                sb.AppendLine(auto.MostrarDatos());
                sb.AppendLine("----------------------");

            }
            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
            {
                if (item == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random random = new Random();
            
            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)random.Next(15, 100);
                return true;
            }
            return false;
        }
    }
}
