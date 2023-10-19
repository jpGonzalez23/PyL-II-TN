namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_I01 - Clase-06";

            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            Console.WriteLine("Array Original");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}, {1}", i, array[i]);
            }

            Console.WriteLine("positivos ordenados en forma decreciente.");
            Array.Sort(array, Program.OrdenDescendente);
           
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > 0)
                    Console.WriteLine("{0} : {1}", i, array[i]);
            }
           
            Console.WriteLine("negativos ordenados en forma creciente.");
            Array.Sort(array);
            
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < 0)
                    Console.WriteLine("{0} : {1}", i, array[i]);
            }



            Console.ReadKey();
        }

        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}