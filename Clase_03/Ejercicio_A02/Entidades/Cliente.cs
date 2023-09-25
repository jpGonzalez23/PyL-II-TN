using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private List<Mascota> mascotas;

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
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
                if (string.IsNullOrEmpty(value))
                {
                    this.apellido = value;
                }
            }
        }

        public string Domicilio
        {
            get { return this.domicilio; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.domicilio = value;
                }
            }
        
        }
        public string Telefono 
        {
            get { return this.telefono; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.telefono = value;
                }
            }
        }

        public List<Mascota> Mascotas
        {
            get { return this.mascotas; }
        }

        private Cliente()
        {
            this.mascotas = new List<Mascota>();
        }

        public Cliente(string nombre, string apellido, string domicilio,  string telefono) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.domicilio = domicilio;
        }

        public bool AgregarMascota(Mascota mascota)
        {
            if (this.mascotas.Contains(mascota))
            {
                this.mascotas.Add(mascota);
                return true;
            }
            return false;
        }

        public string MostrarClinte()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Domicilio: {this.Domicilio}");
            sb.AppendLine($"Telefono: {this.Telefono}");

            foreach (Mascota item in this.mascotas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}