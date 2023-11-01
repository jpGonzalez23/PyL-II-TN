using Entidades.Interfaces;
using System.Text;

namespace Entidades.Modelos
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public decimal Impuestos
        {
            get 
            { 
                return costoEnvio * 0.35M;

            }
        }

        public abstract bool TienePrioridad { get; }


        public string ObtenerInformacionDelPaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Costo Envio: {this.costoEnvio}");
            sb.AppendLine($"Peso kg: {this.pesoKg}");

            if (this.TienePrioridad)
            {
                sb.AppendLine("Tiene prioridad");
            }
            else
            {
                sb.AppendLine("No tiene prioridad");
            }
            
            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos;
        }
    }
}