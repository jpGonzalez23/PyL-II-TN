using Entidades;
namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02 - Ejercicio N°3";

            int opcion;
            int ingresoDecimal;
            string ingresoBinario;
            string binario;
            int numeroDecimal;

            Console.Write("Ingrese que opción quiere para convertir:\n1-Decimal a Binario\n2-Binario a Decimal\nSu opción es: ");
            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el numero en Decimal: ");
                    int.TryParse(Console.ReadLine(), out ingresoDecimal);

                    binario = Conversor.ConvertirDecimalABinario(ingresoDecimal);

                    Console.WriteLine($"El resultado en Binario es: {binario}");
                    break;

                case 2:
                    Console.WriteLine("ingrese el numero en Binario: ");

                    ingresoBinario = Console.ReadLine();
                    numeroDecimal = Conversor.ConveritBinarioAEntero(ingresoBinario);

                    Console.WriteLine($"El resultado en Decimal es: {numeroDecimal}");
                    break;
            }

            Console.ReadKey();

        }
    }
}