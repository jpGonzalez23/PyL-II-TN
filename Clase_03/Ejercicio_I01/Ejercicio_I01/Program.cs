using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("lalala", 4000);

            Console.Write(cuenta.Mostrar());
            
            cuenta.Ingresar(1000);
            Console.Write(cuenta.Mostrar());

            cuenta.Retirar(2000);
            Console.Write(cuenta.Mostrar());

        }
    }
}