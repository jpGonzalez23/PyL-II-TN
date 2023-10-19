using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_I01 - Metodo de Extension";

            DateTime fechaActual = DateTime.Today;

            foreach (EEstacion estacion in Enum.GetValues(typeof(EEstacion)))
            {
                string mensaje = fechaActual.ObtenerPlacaCronicaTV(estacion);
                Console.WriteLine(mensaje);
            }
        }
    }
}