using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        /// <summary>
        /// Declaracion de variable
        /// </summary>
        private float longitudBase;
        private float longitudAltura;

        /// <summary>
        /// Declaracion de constructor de la clase Rectangulo
        /// </summary>
        /// <param name="longiBase">Recibe la longitud de la base</param>
        /// <param name="longiAltura">Recibe la longitud de la altura</param>
        public Rectangulo(float longiBase, float longiAltura)
        {
            this.longitudBase = longiBase;
            this.longitudAltura = longiAltura;
        }

        /// <summary>
        /// Metodo para calcular el perimetro
        /// </summary>
        /// <returns>Retorna un decimal</returns>
        public override double CalcularPerimetro()
        {
            return (this.longitudAltura + this.longitudBase) * 2;
        }

        /// <summary>
        /// Metodo para calcular la superficie
        /// </summary>
        /// <returns>Retrona un decimal</returns>
        public override double CalcularSuperficie()
        {
            return this.longitudAltura * this.longitudBase;
        }

        /// <summary>
        /// Metodo para Mostrar que figura se esta dibujando
        /// </summary>
        /// <returns></returns>
        public override string Dibujar()
        {
            return "Dibujado un Rectangulo";
        }
    }
}
