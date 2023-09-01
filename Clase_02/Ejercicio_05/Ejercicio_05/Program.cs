using Entidades;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02 - Ejercicio_05";

            int opcion;
            double ladoCuadrado;
            double alturaTriangulo;
            double baseTriangulo;
            double radioCirculo;

            Console.Write("Seleccione una opcion:\n1)Calculo del area del cuadrado\n2)Calculo del area del triangulo\n3)Calculo del area del circulo\n");
            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el lado del cuadrado: ");
                    
                    double.TryParse(Console.ReadLine(), out  ladoCuadrado);

                    Console.WriteLine($"El resultado es: {CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado)}");
                    break;
                
                case 2:
                    Console.WriteLine("Ingrese la altura del triangulo: ");
                    double.TryParse(Console.ReadLine(), out alturaTriangulo);

                    Console.WriteLine("Ingrese la base del triangulo: ");
                    double.TryParse(Console.ReadLine(), out baseTriangulo);

                    Console.WriteLine($"El resultado es: {CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo)}");
                    break;
                
                case 3:
                    Console.Write("Ingrese el radio: ");

                    double.TryParse(Console.ReadLine(), out radioCirculo);

                    Console.WriteLine($"El resultado es: {CalculadoraDeArea.CalcularAreaCirculo(radioCirculo)}");
                    break;
            }
        }
    }
}