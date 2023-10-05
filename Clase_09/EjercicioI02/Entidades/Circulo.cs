using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Circulo : Figura
    {
        /// <summary>
        /// Declaracion de variable
        /// </summary>
        private float radio;

        /// <summary>
        /// Contructor de la clase Circulo
        /// </summary>
        /// <param name="radio">Recibe el radio de un circulo</param>
        public Circulo(float radio)
        {
            this.radio = radio;
        }

        /// <summary>
        /// Metodo para calcular el perimetro
        /// </summary>
        /// <returns>Retorna un decimal</returns>
        public override double CalcularPerimetro()
        {
            return Math.PI * this.radio * 2;
        }

        /// <summary>
        /// Metodo para Calcular la superficie
        /// </summary>
        /// <returns>Retorna un decimal</returns>
        public override double CalcularSuperficie()
        {
            return Math.PI + Math.Pow(this.radio, 2);
        }

        /// <summary>
        /// Metodo para mostrar que esta dibujando
        /// </summary>
        /// <returns>Retorna una cadena de string</returns>
        public override string Dibujar()
        {
            return "Dibujando Círculo...";
        }
    }
}
