using Entidades;
using System.Drawing;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_I01 - Clase_08";

            Camion camioncito = new Camion(8, 2, VehiculoTerrestre.EColor.Azul, 8, 5000);
            Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}",camioncito.CantidadRuedas, camioncito.CantidadPuertas, camioncito.Color, camioncito.PesoCarga);
            Console.WriteLine("--------------");
            
            Automovil autito = new Automovil(4, 5, VehiculoTerrestre.EColor.Blanco, 8, 3);
            Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.CantidadRuedas, autito.CantidadPuertas, autito.Color, autito.CantidadMarchas, autito.CantidadPasajeros);
            Console.WriteLine("-----------");
            
            Moto motito = new Moto(2, 0, VehiculoTerrestre.EColor.Rojo, 1000);
            Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.CantidadRuedas, motito.CantidadPuertas, motito.Color, motito.Cilindrada);
        }
    }
}