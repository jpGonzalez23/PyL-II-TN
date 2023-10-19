namespace Entidades
{
    public class Calculadora
    {
        public static double Calcular(double a, double b, char operacion)
        {
            double repuesta = 0;

            if (operacion == '+')
            {
                repuesta = a + b;
            }
            
            if (operacion == '-')
            {
                repuesta = a - b;
            }
            
            if (operacion == '*')
            {
                repuesta = a * b;
            }

            if (operacion == '/')
            {
                if (Validar(b))
                {
                    repuesta = a / b;
                }
            }

            return repuesta;
        }

        private static bool Validar(double b)
        {
            if (b != 0)
            {
                return true;
            }
            return false;
        }
    }
}