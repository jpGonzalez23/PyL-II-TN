using Entidades;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02 - Ejercicio N°2";

            // Declaracion de variable
            int numero;
            int acumulador = 0;
            char caracter;

            do
            {
                // Ingreso de numero
                Console.WriteLine("Ingrese un numero");
                
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    acumulador += numero;
                }

                // Pregunta de si quiere continuar
                Console.WriteLine("¿Desea continuar ingresando numero? s/n");
                char.TryParse(Console.ReadLine(), out caracter);
                
            } while (Validador.ValidarRespuesta(caracter)); // Valida si el caracter ingresado es correcto

            // Muestra la suma 
            Console.WriteLine($"El resultado de la suma es: {acumulador}");
        }
    }
}