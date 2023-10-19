using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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
			get { return this.competidores[i]; }
		}


		public ETipo TipoCompetencia
		{
			get { return this.tipo; }
			set { this.tipo = value; }
		}


		public short CantidadVueltas
		{
			get { return this.cantidadVueltas; }
			set { this.cantidadVueltas = value; }
		}


		public short CantidadCompetidores
		{
			get { return this.cantidadCompetidores; }
			set { this.cantidadCompetidores = value; }
		}

		private Competencia()
		{
			this.competidores = new List<VehiculoDeCarrera>();
		}

		public Competencia(short cantVueltas, short cantCombustible, ETipo tipo)
			:this()
		{
			this.cantidadVueltas = cantVueltas;
			this.cantidadVueltas = cantCombustible;
			this.tipo = tipo;
		}

		public string Mostrar()
		{
            StringBuilder returnAux = new StringBuilder();

            returnAux.AppendLine(("Cantidad de vueltas de la competencias: " + this.CantidadVueltas).ToString());
            returnAux.AppendLine(("Cantidad de competidores: " + this.CantidadCompetidores).ToString());
            
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
            if (c.competidores.Count() < c.cantidadCompetidores && (c != v))
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
            if (c.competidores.Count() > 0 && (c == v))
            {
                c.competidores.Remove(v);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = true;
            if ((c.TipoCompetencia == Competencia.ETipo.F1 && v.GetType() != typeof(AutoF1)) || (c.TipoCompetencia == Competencia.ETipo.MotoCross && v.GetType() != typeof(MotoCross)))
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
