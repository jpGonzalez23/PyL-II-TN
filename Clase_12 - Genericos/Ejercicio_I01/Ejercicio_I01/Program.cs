using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("tBasquet");
            Torneo<EquipoFutbol> torneofutbol = new Torneo<EquipoFutbol>("tFutbol");

            EquipoBasquet e1 = new EquipoBasquet("e1", DateTime.Now);
            EquipoBasquet e2 = new EquipoBasquet("e2", DateTime.Now);

            EquipoFutbol f1 = new EquipoFutbol("f1", DateTime.Now);
            EquipoFutbol f2 = new EquipoFutbol("f2", DateTime.Now);

            _ = torneoBasquet + e1;
            _ = torneoBasquet + e2;

            _ = torneofutbol + f1;
            _ = torneofutbol + f2;



            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneofutbol.Mostrar());
        }
    }
}