using System.Text;

namespace Entidades
{
    public class AutoF1
    {
        private short numero;
        private short vueltasRestantes;
        private short cantidadCombustible;
        private string escuderia;
        private bool enCompetencia;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public short VueltasRestantes { set => this.vueltasRestantes = value; }
        public short CantidadCombustible { set => this.cantidadCombustible = value; }
        public bool EnCompetencia { set => this.enCompetencia = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");

            sb.AppendLine(this.enCompetencia == true ? "Esta en competencia" : "No esta en competencia");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.escuderia == a2.escuderia && a1.numero == a2.numero;
        }


        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}