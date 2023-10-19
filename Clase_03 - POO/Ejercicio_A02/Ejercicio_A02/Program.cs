using Entidades;

namespace Ejercicio_A02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Pepe", "Gomez", "calle false 123", "544-566");
            Mascota perro = new Mascota("Perro", "Fido", new DateTime(2019, 5, 15));
            
            cliente1.AgregarMascota(perro);

            Console.WriteLine("Datos del cliente:");
            Console.WriteLine(cliente1.MostrarClinte());

            Console.WriteLine("Datos de la mascota:");
            Console.WriteLine(perro.Mostrar());


        }
    }
}