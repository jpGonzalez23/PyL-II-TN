// Ingresar 5 números por consola, guardándolos en una variable escalar.
// Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Titulo 
            Console.WriteLine("Ejercicio N°1");

            // Declaracion de variables 
            int numero;
            int numMaximo = 0;
            int numMinimo = 0;
            int bandera = 0;
            int acumulador = 0;
            float promedio = 0;

            // Sentencia de For
            for (int i = 0; i < 5; i++)
            {
                // Ingreso de numero
                Console.WriteLine($"Ingrese el {i} numero: ");
                // Parseo de string a int
                int.TryParse(Console.ReadLine(), out numero);

                // Sentencia if para el ingreso del primer 1
                if (bandera == 0)
                {
                    numMaximo = numero;
                    numMinimo = numero;
                    bandera = 1;
                }
                else if (numero > numMaximo)
                {
                    numMaximo = numero;
                }
                else
                {
                    numMinimo = numero;
                }

                acumulador += numero;
            }

            // Calculo del promedio
            promedio = acumulador / 5;

            // Bloque de imprimir por pantalla 
            Console.WriteLine($"El numero maximo es: {numMaximo}");
            Console.WriteLine($"El numero minimo es: {numMinimo}");
            Console.WriteLine($"El promedio es: {promedio}");

            Console.ReadKey();
        }
    }
}