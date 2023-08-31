namespace Entidades
{
    public class Validador
    {
        public static bool Validar(int valor, int max, int min)
        {
            while (valor < min && valor > max)
            {
                return true;
            }

            return false;
        }
    }
}