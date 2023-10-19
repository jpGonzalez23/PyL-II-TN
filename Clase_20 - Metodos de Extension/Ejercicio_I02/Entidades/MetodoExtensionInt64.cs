namespace Entidades
{
    public static class MetodoExtensionInt64
    {
        public static int ContarCantidadDigitos(this long numero)
        {
            int cantidadDigitos = numero == 0 ? 1 : (int)Math.Floor(Math.Log10(Math.Abs(numero)) + 1);
            return cantidadDigitos;
        }
    }
}