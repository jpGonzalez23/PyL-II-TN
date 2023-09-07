namespace Entidades
{
    public class Sumador
    {
        private int cantSuma;

        /// <summary>
        /// Constructor donde inicializa el atributo en 0
        /// </summary>
        public Sumador() : this(0) { }

        /// <summary>
        /// Sobrecarga del constructor donde incializa con la variable recibida
        /// </summary>
        /// <param name="canatSuma"></param>
        public Sumador(int canatSuma)
        {
            this.cantSuma = canatSuma;
        }

        /// <summary>
        /// Metodo donde se suman lo valores recibidos
        /// </summary>
        /// <param name="a">Primer parametros</param>
        /// <param name="b">Segundo parametro</param>
        /// <returns>Retorna la suma de los parametros sumados</returns>
        public long Sumar(long a, long b)
        {
            this.cantSuma += 1;

            return a + b;
        }

        /// <summary>
        /// Sobrecarga del metodo, concatena los variables 
        /// </summary>
        /// <param name="a">Primer parametro</param>
        /// <param name="b">Segundo parametro</param>
        /// <returns>Retorna una cadena de caracteres</returns>
        public string Sumar(string a, string b)
        {
            this.cantSuma += 1;

            return string.Format($"{a}{b}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        public static explicit operator int(Sumador s)
        {
            return s.cantSuma;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool flag = false;

            if ((int)s1 == (int)s2)
            {
                return flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Cantidad()
        {
            return this.cantSuma;
        }
    }
}