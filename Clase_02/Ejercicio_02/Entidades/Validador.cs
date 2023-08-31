namespace Entidades
{
    public class Validador
    {
        public static bool ValidarRespuesta(char caracter)
        {
            if (char.ToUpper(caracter) == 'S') 
            {
                return true;
            }
            return false;
        }
    }
}