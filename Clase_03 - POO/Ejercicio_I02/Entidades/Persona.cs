using System.Text;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre,  DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni; 
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre =value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return this.fechaDeNacimiento; }
            set { this.fechaDeNacimiento = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set
            {
                if (value > 0 && value < 7)
                {
                    this.dni = value;
                }
            }
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - this.FechaDeNacimiento.Year;

            if (fechaActual < this.FechaDeNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Fecha de nacimiento: {this.FechaDeNacimiento.ToString("dd/MMMM/yyyy")}");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            if (this.CalcularEdad() < 18)
            {
                return "Es menor de edad";
            }
            else
            {
                return "Es mayor edad";
            }
        }
    }
}