// Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
// valor: dato a validar.
// min: mínimo valor incluido.
// max: máximo valor incluido.
// Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
// Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

using Entidades;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02 - Ejercico N°1";

            // Declaracion de variable
            int numero;
            int acumulador = 0;
            int max = 0;
            int min = 0;
            int bandera = 0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                // Ingreso de numero
                Console.Write("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numero);

                // Sentencia para validar el num ingresado
                if (Validador.Validar(numero, -100, 100))
                {
                    
                    if (bandera == 0)
                    {
                        max = numero;
                        min = numero;
                        bandera = 1;
                    }
                    else if (bandera == 0 || numero < min)
                    {
                        min = numero;
                    }
                    else
                    {
                        max = numero;
                    }

                    acumulador += numero;
                }
                else
                {
                    // Mensaje de error
                    Console.WriteLine("ERRO!\nIngrese un numero entre -100 y 100");
                }
            }

            // Calculo del promedio
            promedio = ((float)acumulador) / 10;

            // Muestro por pantalla el num. max. min. y promedio
            Console.WriteLine($"El numero maximo es: {max}");
            Console.WriteLine($"El numero minimo es: {min}");
            Console.WriteLine($"El promedio es: {promedio}");

            Console.ReadKey(); 
        }
    }
}