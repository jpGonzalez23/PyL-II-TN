namespace Entidades
{
    public class ParametroVacioException : Exception
    {
        public ParametroVacioException(string message) : base(message) { }

        public ParametroVacioException(string message, Exception innerException) : base(message, innerException) { }
    }
}