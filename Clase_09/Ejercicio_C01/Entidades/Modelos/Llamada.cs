using System.Text;

namespace Entidades.Modelos
{
    public abstract class Llamada
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
            get { return duracion; }
        }

        public string NroOrigen
        {
            get { return nroOrigen; }
        }

        public string NroDestino
        {
            get { return nroDestino; }
        }

        public abstract float CostoLlamada { get; }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero de origen: {NroOrigen}");
            sb.AppendLine($"Numero de destino: {NroDestino}");
            sb.AppendLine($"Duración: {Duracion}");

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            return llamada1 is not null && llamada2 is not null && llamada1.GetType() == llamada2.GetType();
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }
    }
}