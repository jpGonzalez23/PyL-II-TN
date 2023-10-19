using Entidades.Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
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
            get { return franja; }
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(EFranja franja, Llamada llamada) : this("", "", 0, franja)
        {
            this.franja = franja;
        }

        public Provincial(string origen, string destino, float duracion, EFranja franja) : base(duracion, destino, origen)
        {

        }

        private float CalcularCosto()
        {
            if (franja == EFranja.Franja_1)
            {
                return 0.99f * Duracion;
            }
            else if (franja == EFranja.Franja_2)
            {
                return 1.25f * Duracion;
            }
            else
            {
                return 0.66f * Duracion;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo llamada: {this.CalcularCosto()}");
            sb.AppendLine($"Franja horario: {this.Franja}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is ETipoLlamda.Provincia;
        }
    }
}
