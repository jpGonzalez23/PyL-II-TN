using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(float longiBase) : base(longiBase, longiBase)
        {
        }

        public override string Dibujar()
        {
            return "Dibujando un cuadrado";
        }
    }
}
