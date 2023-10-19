using Entidades;

namespace Ejecicio_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercico_C01 - Clase_08";

            Jugador jugador1 = new Jugador(1234567, "Pepe", 2, 3);
            Equipo equipo = new Equipo(5, "A puralo que no sabe");

            if (equipo + jugador1)
            {
                Console.WriteLine("Se agrego el jugador");
            }

            Console.WriteLine($"{jugador1.Mostrar()}");
            
        }
    }
}