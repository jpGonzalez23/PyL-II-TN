using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Comida;

namespace Entidades
{
    public class Guarnicion : Comida
    {
        public enum ETipo
        {
            PAPAS_FRITAS = 100,
            ENSALADA_RUSA = 750,
            ENSALADA_MIXTA = 500
        };

        private ETipo tipo;

        public Guarnicion():this(ETipo.PAPAS_FRITAS)
        {

        }

        public Guarnicion(ETipo tipo):base(tipo.ToString())
        {
            this.tipo = tipo;
        }

        protected override string AgregarIngredientes(EIngredientes ingrediente)
        {
            if ((Comida)this != ingrediente && this == ingrediente)
            {
                base.ingredientes.Add(ingrediente);

                return $"Se agrego {ingrediente} a su guarnición";
            }
            return $"No se pudo agregar {ingrediente} a su guarnicion";
        }

        protected override double CalcularCosto()
        {
            double costo = (int)this.tipo;

            base.ingredientes.ForEach(i => costo += (costo * (int)i / 100));

            return costo;
        }

        public static explicit operator Guarnicion(ETipo tipo)
        {
            return new Guarnicion(tipo);
        }

        public static bool operator ==(Guarnicion g, EIngredientes ingrediente)
        {
            if (ingrediente is EIngredientes.ADHERESO || ingrediente is EIngredientes.PANCETA || ingrediente is EIngredientes.QUESO)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Guarnicion g, EIngredientes ingrediente)
        {
            return !(g == ingrediente);
        }

        public override string ToString()
        {
            return $"Guarnicion de tipo - {this.tipo}";
        }
    }
}
