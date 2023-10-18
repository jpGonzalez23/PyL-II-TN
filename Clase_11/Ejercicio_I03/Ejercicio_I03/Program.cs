using Entidades;

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercio_I03";

            Console.WriteLine("Ingresa un texto:");

            string texto = Console.ReadLine();

            int cantidadPuntuacion = texto.ContarSignosDePuntuacion();

            Console.WriteLine($"La cantidad de signos de puntuación en el texto es: {cantidadPuntuacion}");
        }
    }
}