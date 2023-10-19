using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia)
        {
        }

        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get { return cilindrada; }
            set
            {
                if (value > 0)
                {
                    cilindrada = value;
                }
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Cilindrada: {Cilindrada}");

            return sb.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return m1.Cilindrada == m2.Cilindrada ? true : false;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
