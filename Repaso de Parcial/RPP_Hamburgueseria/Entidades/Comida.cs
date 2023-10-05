using System.Text;

namespace Entidades
{
    public abstract class Comida
    {
        public enum EIngredientes
        {
            ADHERESO,
            QUESO,
            CEBOLLA,
            TOMATE,
            JAMON,
            HUEVO,
            PANCETA
        };

        protected List<EIngredientes> ingredientes;
        private string nombre;

        public double Costo
        {
            get 
            { 
                return this.CalcularCosto(); 
            }
        }

        public string Descripcion
        {
            get 
            { 
                return this.MostrarDatos(); 
            }
        }

        public string Nombre
        {
            get 
            { 
                return this.nombre; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
            }
        }

        protected Comida(string nombre) : this(nombre, new List<EIngredientes>())
        {

        }

        protected Comida(string nombre, List<EIngredientes> ingredientes)
        {
            this.nombre = nombre;
            this.ingredientes = ingredientes;
        }

        protected abstract string AgregarIngredientes(EIngredientes ingredientes);

        protected abstract double CalcularCosto();

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Costo: {this.Costo}");
            sb.AppendLine($"Ingresites: ");
            foreach (EIngredientes item in this.ingredientes)
            {
                sb.Append(item.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(Comida c, EIngredientes ingrediente)
        {
            return c.ingredientes.Contains(ingrediente) ? true : false;
        }

        public static bool operator !=(Comida c, EIngredientes ingrediente)
        {
            return !(c == ingrediente);
        }

        public static string operator +(Comida c, EIngredientes ingrediente)
        {
            return c.AgregarIngredientes(ingrediente);
        }
    }
}