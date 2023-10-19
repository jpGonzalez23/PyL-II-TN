namespace Entidades
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            double respuesta;

            respuesta = Math.Pow(longitudLado, 2);

            return respuesta;
        }

        public static double CalcularAreaTriangulo(double @base, double altura) 
        {
            double respuesta;

            respuesta = (@base * altura) / 2;

            return respuesta;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            double respusta;

            respusta = Math.PI * Math.Pow(radio, 2);

            return respusta;
        }
    }
}