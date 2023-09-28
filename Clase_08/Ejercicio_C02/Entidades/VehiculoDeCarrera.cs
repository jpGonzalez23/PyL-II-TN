using System.Text;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short numero;
        private short vueltasRestantes;
        private short cantidadCombustible;
        private string escuderia;
        private bool enCompetencia;

        public short Numero 
        { 
            get { return this.numero; } 
            set
            {
                if (value > 0)
                {
                    this.numero = value;
                }
            }
        }

        public short VueltasRestantes 
        { 
            get { return this.vueltasRestantes; } 
            set
            {
                if (value > 0)
                {
                    this.vueltasRestantes = value;
                }
            } 
        }

        public short CantidadCombustible 
        { 
            get { return this.cantidadCombustible; } 
            set
            {
                if (value > 0)
                {
                    this.cantidadCombustible = value;
                }
            } 
        }

        public string Escuderia 
        { 
            get { return this.escuderia; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.escuderia = value;
                }
            } 
        }

        public bool EnCompetencia 
        { 
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; } 
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Escuderia: {this.Escuderia}");
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");

            sb.AppendLine(this.EnCompetencia == true ? "Esta en competencia" : "No esta en competencia");

            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia ? true : false;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}