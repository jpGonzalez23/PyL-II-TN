using Entidades;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_I02 - Clase_13 - Genericos";

            Recibo recibo1 = new Recibo();
            Factura factura1 = new Factura(123);
            Factura factura2 = new Factura(456);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += recibo1;
            contabilidad += factura1;
            contabilidad += factura2;

            foreach (Documento item in contabilidad.egresos)
            {
                Console.WriteLine(item.Numero);
            }
            foreach (Documento item in contabilidad.ingresos)
            {
                Console.WriteLine(item.Numero);
            }
        }
    }
}