using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)  
            : this("", "", 0f, 0f)
        {

        }

        public Local(string origen, string destino, float duracion, float costo) :
            base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return costo * base.Duracion;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de la llamda: {this.CostoLlamada}");

            return sb.ToString();
        }
    }
}
