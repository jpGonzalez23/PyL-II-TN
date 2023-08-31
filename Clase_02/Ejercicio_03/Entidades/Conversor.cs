namespace Entidades
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int entero)
        {
            string valorBinario = string.Empty;
            int resultDiv = entero;
            int restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;
                } while (resultDiv > 0);
            }

            return valorBinario;
        }

        public static int ConveritBinarioAEntero(string entero)
        {
            int resultado = 0;
            int cantidadCaracteres = entero.Length;
            foreach (char caracter in entero)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }
    }
}