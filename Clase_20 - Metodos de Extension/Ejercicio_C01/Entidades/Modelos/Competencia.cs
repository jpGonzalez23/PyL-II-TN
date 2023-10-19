using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Competencia
    {
        public enum ETipo
        {
            F1,
            MotoCross
        };

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private ETipo tipo;
        private List<VehiculoDeCarrera> competidores;

        public VehiculoDeCarrera this[int i]
        {
            get { return competidores[i]; }
        }


        public ETipo TipoCompetencia
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public short CantidadVueltas
        {
            get { return cantidadVueltas; }
            set { cantidadVueltas = value; }
        }


        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set { cantidadCompetidores = value; }
        }

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantVueltas, short cantCombustible, ETipo tipo)
            : this()
        {
            cantidadVueltas = cantVueltas;
            cantidadVueltas = cantCombustible;
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();

            returnAux.AppendLine(("Cantidad de vueltas de la competencias: " + CantidadVueltas).ToString());
            returnAux.AppendLine(("Cantidad de competidores: " + CantidadCompetidores).ToString());

            foreach (AutoF1 auto in competidores)
            {
                returnAux.AppendLine(auto.Mostrar());
            }

            return returnAux.ToString();
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            Random combusRandom = new Random();
            bool returnAux = false;
            if (c.competidores.Count() < c.cantidadCompetidores && c != v)
            {
                v.EnCompetencia = true;
                v.VueltasRestantes = c.cantidadVueltas;
                v.CantidadCombustible = (short)combusRandom.Next(15, 100);
                c.competidores.Add(v);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = false;
            if (c.competidores.Count() > 0 && c == v)
            {
                c.competidores.Remove(v);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = true;
            if (c.TipoCompetencia == ETipo.F1 && v.GetType() != typeof(AutoF1) || c.TipoCompetencia == ETipo.MotoCross && v.GetType() != typeof(MotoCross))
            {
                returnAux = false;
            }
            else
            {
                foreach (VehiculoDeCarrera vehiculo in c.competidores)
                {
                    if (vehiculo == v)
                    {
                        returnAux = false;
                        break;
                    }
                }
            }
            return returnAux;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

    }
}
