namespace Entidades
{
    public abstract class Figura
    {
        /// <summary>
        /// Metodo virtual, puede o no tener una implementacion en la clase heredada
        /// </summary>
        /// <returns></returns>
        public virtual string Dibujar()
        {
            return "Dibujando Forma...";
        }

        /// <summary>
        /// Metodo abstracto, debe tener una implementacion obligatoria en la clase heredada
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularSuperficie();

        /// <summary>
        /// Metodo abstracto, debe tener una implementacion obligatoria en la clase heredada
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularPerimetro();
    }
}