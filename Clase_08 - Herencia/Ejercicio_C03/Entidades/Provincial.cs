using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        public enum EFranja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        };

        protected EFranja franja;

        public EFranja Franja
        {
            get { return this.franja; }
        }

        public Provincial(EFranja franja, Llamada llamada):this("", "", 0, franja)
        {
            this.franja = franja;
        }

        public Provincial(string origen, string destino, float duracion, EFranja franja):base(duracion,destino,origen)
        {

        }

        private float CalcularCosto()
        {
            if (this.franja == EFranja.Franja_1)
            {
                return 0.99f * base.Duracion;
            }
            else if (this.franja == EFranja.Franja_2)
            {
                return 1.25f * base.Duracion;
            }
            else
            {
                return 0.66f * base.Duracion;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo llamada: {this.CalcularCosto()}");
            sb.AppendLine($"Franja horario: {this.Franja}");

            return sb.ToString();
        }
    }
}
