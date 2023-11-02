namespace Entidades.Modelos
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            this.id = id;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value > 0)
                {
                    this.id = value;
                }
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.apellido = value;
                }
            }
        }
    }
}