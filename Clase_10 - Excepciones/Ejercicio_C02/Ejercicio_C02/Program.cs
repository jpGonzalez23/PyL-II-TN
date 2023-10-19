using Entidades.Excepciones;

namespace Ejercicio_C02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Simular una excepción con un mensaje personalizado
                throw new CompetenciaNoDisponibleException("Competencia no disponible", "MiClase", "MiMetodo", null);
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}