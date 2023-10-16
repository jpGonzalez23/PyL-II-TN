using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Execpciones
{
    public class CentralicaExcepciones : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CentralicaExcepciones(string message, string clase, string metodo) : base(message)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CentralicaExcepciones(string message, string clase, string metodo, Exception innerException) : base(message)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public string NombreClase { get => this.nombreClase; }
        public string NombreMetodo { get => this.nombreMetodo; }
    }
}
