using System.Text;

namespace Entidades.Modelos
{
    public abstract class VehiculoDeCarrera
    {
        private short numero;
        private short vueltasRestantes;
        private short cantidadCombustible;
        private string escuderia;
        private bool enCompetencia;

        public short Numero
        {
            get { return numero; }
            set
            {
                if (value > 0)
                {
                    numero = value;
                }
            }
        }

        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set
            {
                if (value > 0)
                {
                    vueltasRestantes = value;
                }
            }
        }

        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set
            {
                if (value > 0)
                {
                    cantidadCombustible = value;
                }
            }
        }

        public string Escuderia
        {
            get { return escuderia; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    escuderia = value;
                }
            }
        }

        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Escuderia: {Escuderia}");
            sb.AppendLine($"Numero: {Numero}");
            sb.AppendLine($"Cantidad de combustible: {CantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {VueltasRestantes}");

            sb.AppendLine(EnCompetencia == true ? "Esta en competencia" : "No esta en competencia");

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