// Ingresar un número y mostrar el cuadrado y el cubo del mismo.
// Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°2";

            int numero;
            double cuadrado = 0;
            double cubo = 0;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numero);

                if (numero <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (numero <= 0);

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine($"El cuadrado del numero {numero} es: {cuadrado}");
            Console.WriteLine($"El cubo del numero {numero} es: {cubo}");
        }
    }
}