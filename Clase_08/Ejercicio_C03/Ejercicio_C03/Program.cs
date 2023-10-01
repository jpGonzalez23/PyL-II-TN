using Entidades;

namespace Ejercicio_C03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_C03 - Clase_08";

            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas "Bernal", 30, "Rosario", 2.65f
            Local l1 = new Local("Bernal", "Rosario", 2.65f, 30);
            Provincial l2 = new Provincial("Morón", "Bernal", 21, Provincial.EFranja.Franja_1);
            Local l3 = new Local("Lanús", "San Rafael", 1.99f, 45);
            Provincial l4 = new Provincial(Provincial.EFranja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}