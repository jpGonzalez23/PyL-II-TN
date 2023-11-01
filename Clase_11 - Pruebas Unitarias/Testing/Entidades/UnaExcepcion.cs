namespace Entidades
{
    public class UnaExcepcion : Exception
    { 
        public UnaExcepcion(string message) : base(message) { }

        public UnaExcepcion(string message,  Exception inner) : base(message, inner) { }
    }
}