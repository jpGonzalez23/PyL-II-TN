using System.Text;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get => this.colorTinta;
            set => this.colorTinta = value;
        }

        public float UnidadDeEscritura
        {
            get => this.tinta;
            set => this.tinta = value;
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.tinta = (float)texto.Length * 0.3f;
            return new EscrituraWrapper(ConsoleColor.Gray, texto);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Es Bolígrafo");
            sb.AppendLine($"Nivel de tinta: {this.UnidadDeEscritura}");
            sb.AppendLine($"Color de tinta: {this.Color}");

            return sb.ToString();
        }

    }
}