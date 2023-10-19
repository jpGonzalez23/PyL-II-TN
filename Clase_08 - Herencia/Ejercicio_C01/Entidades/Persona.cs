using System.Text;

namespace Entidades
{
    public class Persona
    {
        protected long dni;
        protected string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        public long Dni 
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value > 8)
                {
                    this.dni = value;
                }
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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"DNI: {this.Dni}");

            return sb.ToString();
        }
    }
}