using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private float longitudBase;
        private float longitudAltura;

        public Rectangulo(float longiBase, float longiAltura)
        {
            this.longitudBase = longiBase;
            this.longitudAltura = longiAltura;
        }

        public override double CalcularPerimetro()
        {
            return (this.longitudAltura + this.longitudBase) * 2;
        }

        public override double CalcularSuperficie()
        {
            return this.longitudAltura * this.longitudBase;
        }

        public override string Dibujar()
        {
            return "Dibujado un Rectangulo";
        }
    }
}
