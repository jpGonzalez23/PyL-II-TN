using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exception
{
    public class ExceptionPersonaDAO : System.Exception
    {
        public ExceptionPersonaDAO(string? message) : base(message)
        {
        }

        public ExceptionPersonaDAO(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }
    }
}
