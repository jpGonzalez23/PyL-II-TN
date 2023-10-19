using Entidades;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_I02 - Metodos de Extensión";

            //long numero = 12345; // Cambia este número por el que desees contar
            long numero = 1000; // Cambia este número por el que desees contar


            int cantidadDigitos = numero.ContarCantidadDigitos();

            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Cantidad de dígitos: {cantidadDigitos}");
        }
    }
}