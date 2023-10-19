namespace Entidades
{
    public class Cliente
    {
        /// <summary>
        /// Declaracion de variables
        /// </summary>
        private string nombre;
        private int puesto;


        /// <summary>
        /// Constructor de la clase clientes
        /// </summary>
        /// <param name="nombre">Recibe el nombre del cliente</param>
        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// sobrecarga del constructor de la clase cliente
        /// </summary>
        /// <param name="puesto">Reciebe el numero del puesto</param>
        /// <param name="nombre">Recibe el nombre del cliente</param>
        public Cliente(int puesto, string nombre) : this(nombre)
        {
            this.puesto = puesto;
        }

        /// <summary>
        /// Propiedad del atributo 
        /// </summary>
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

        public int Numero
        {
            get
            {
                return this.puesto;
            }
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}