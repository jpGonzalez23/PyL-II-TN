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

            sb.AppendLine($"Numero de origen: {this.NroOrigen}");
            sb.AppendLine($"Numero de destino: {this.NroDestino}");
            sb.AppendLine($"Duración: {this.Duracion}");

            return sb.ToString();
        }

        public static int OrdernarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int returnAux = 0;
            if (llamada1.duracion < llamada2.duracion)
            {
                returnAux = -1;
            }
            else if (llamada1.duracion > llamada2.duracion)
            {
                returnAux = 1;
            }
            return returnAux;
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