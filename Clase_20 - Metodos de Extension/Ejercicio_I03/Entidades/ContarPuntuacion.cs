namespace Entidades
{
    public static class ContarPuntuacion
    {
        public static int ContarSignosDePuntuacion(this string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return 0;
            }

            int contador = 0;
            foreach (char caracter in texto)
            {
                if (caracter == '.' || caracter == ',' || caracter == ';')
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}