using System.Text;

namespace Entidades
{
    public enum ETipoLlamda
    {
        Local,
        Provincia,
        Todas,
    };

    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero de origen: {this.NroOrigen}");
            sb.AppendLine($"Numero de destino: {this.NroDestino}");
            sb.AppendLine($"Duración: {this.Duracion}");

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }
    }
}