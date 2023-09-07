using Entidades;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", new DateTime(1990, 5, 15), 12345678);
            Persona persona2 = new Persona("María", new DateTime(2005, 8, 20), 87654321);
            Persona persona3 = new Persona("Pedro", new DateTime(2002, 3, 10), 98765432);

            Console.WriteLine("Personas:");
            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());

            Console.WriteLine("¿Son mayores de edad?");
            Console.WriteLine($"{persona1.Nombre}: {persona1.EsMayorDeEdad()}");
            Console.WriteLine($"{persona2.Nombre}: {persona2.EsMayorDeEdad()}");
            Console.WriteLine($"{persona3.Nombre}: {persona3.EsMayorDeEdad()}");
        }
    }
}