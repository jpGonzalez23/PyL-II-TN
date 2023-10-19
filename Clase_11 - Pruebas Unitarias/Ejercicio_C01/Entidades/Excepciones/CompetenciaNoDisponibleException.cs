using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) 
            : this(mensaje, clase, metodo, null)
        {

        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) 
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            string formattedMessage = $"Excepción en el método {this.nombreMetodo} de la clase {this.nombreClase}:\n{Message}";
            Exception innerException = InnerException;
            while (innerException != null)
            {
                formattedMessage += $"\n\t{innerException.Message}";
                innerException = innerException.InnerException;
            }
            return formattedMessage;
        }
    }
}
