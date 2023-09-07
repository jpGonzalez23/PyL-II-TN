using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°I01 - Clase 04";

            Sumador sum = new Sumador();
            Sumador sum2 = new Sumador(2);

            Console.WriteLine($"Suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum2.Sumar(100, 687)} Sumador {sum2.Cantidad()}");
            Console.WriteLine($"Suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum.Sumar("HOla ", "Munjjjjjdo")} Sumador {sum.Cantidad()}");
            
            if (sum | sum2)
            {
                Console.WriteLine("ES true");
            }
            Console.WriteLine($"Suma de objetos {sum + sum2}");
        }
    }
}