using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get { return caballosDeFuerza; }
            set
            {
                if (value > 0)
                {
                    caballosDeFuerza = value;
                }
            }
        }

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia) { }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Caballos de Fuerza: {CaballosDeFuerza}");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.CaballosDeFuerza == a2.CaballosDeFuerza ? true : false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
