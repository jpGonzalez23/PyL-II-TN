using Entidades;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02 - Ejercicio_04";

            int numeroA;
            int numeroB;
            string opcion;

            Console.WriteLine($"Ingrese el numero uno: ");
            int.TryParse(Console.ReadLine(), out numeroA);

            Console.WriteLine($"Ingrese el numero dos: ");
            int.TryParse(Console.ReadLine(), out numeroB);

            Console.Write($"Selecciona una opcion:\n+\n-\n*\n/\n");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "+":
                    Console.WriteLine($"La suma es: {Calculadora.Calcular(numeroA, numeroB, '+')}");
                    break;
                case "-":
                    Console.WriteLine($"La resta es: {Calculadora.Calcular(numeroA, numeroB, '-')}");
                    break;
                case "*":
                    Console.WriteLine($"La multiplicacion es: {Calculadora.Calcular(numeroA, numeroB, '*')}");
                    break;
                case "/":
                    Console.WriteLine($"La division es: {Calculadora.Calcular(numeroA, numeroB, '/')}");
                    break;
            }
        }
    }
}