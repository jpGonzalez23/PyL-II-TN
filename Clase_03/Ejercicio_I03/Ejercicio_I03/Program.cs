using Entidades;

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio - I03 - Clase 03";

            Estudiante estudiante = new Estudiante("pepe", "lalala", "133222");

            estudiante.SetNotaPrimerParcial(5);
            estudiante.SetNotaSegundoParcial(6);

            Console.WriteLine(estudiante.Mostrar());

            Console.ReadKey();
        }
    }
}