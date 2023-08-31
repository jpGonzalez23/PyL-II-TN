// Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
// Validar que el dato ingresado por el usuario sea un número.
// Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
// Si ingresa "salir", cerrar la consola.
// Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar.
// De lo contrario, cerrar la consola.

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°3";

            int numero;
            int contador = 0;
            int j = 0;
            int i;
            int k;
            int[] lista = new int[100];

            Console.WriteLine("Ingrese numeros de 0 a 100!");
           
            numero = Convert.ToInt32(Console.ReadLine());
            
            for (k = 1; k <= numero; k++)
            {
                contador = 0;
                for (i = 1; i <= k; i++)
                {
                    if (k % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    lista[j] = k;
                    j++;
                }
            }
           
            Console.WriteLine("Los numeros primos q ingreso son");
            
            for (i = 0; i < j; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}