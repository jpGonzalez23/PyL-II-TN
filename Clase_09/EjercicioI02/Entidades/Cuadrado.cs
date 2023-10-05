using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuadrado : Rectangulo
    {
        /// <summary>
        /// Constructor de la clase Cuadrado
        /// </summary>
        /// <param name="longiBase">Recibe la longitud de la base</param>
        public Cuadrado(float longiBase) : base(longiBase, longiBase)
        {
        }

        /// <summary>
        /// Metodo par mostrar que se esta dibujando
        /// </summary>
        /// <returns>Retorna una cadena de string</returns>
        public override string Dibujar()
        {
            return "Dibujando un cuadrado";
        }
    }
}
