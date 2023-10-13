﻿using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°I01 - Clase_10";

            try
            {
                var otraClase = new OtraClase();
                otraClase.Metodo();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine("Error en Main que captura MiExcepcion:");
                Console.WriteLine(ex.Message);

                var inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine("Inner exception:");
                    Console.WriteLine(inner.Message);
                    inner = inner.InnerException;
                }
            }

            Console.ReadLine();
        }
    }
}