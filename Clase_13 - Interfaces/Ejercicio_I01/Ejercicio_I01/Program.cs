﻿using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("HOla");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();
        }
    }
}