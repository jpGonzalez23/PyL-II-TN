using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        private string nombre;
        private string raza;
        private DateTime fechaNacimiento;
        private List<Vacuna> vacunas;

        private Mascota()
        {
            this.vacunas = new List<Vacuna>();
        }

        public Mascota(string nombre, string raza, DateTime fechaNacimiento) : this()
        {
            this.nombre = nombre;
            this.raza = raza;
            this.fechaNacimiento = fechaNacimiento;
        }

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

        public string Raza
        {
            get { return this.raza; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.raza = value;
                }
            }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }


        public bool AgregarVacuna (Vacuna vacuna)
        {
            if (!this.vacunas.Contains(vacuna))
            {
                this.vacunas.Add(vacuna);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre de mascota: {this.Nombre}");
            sb.AppendLine($"Raza: {this.Raza}");
            sb.AppendLine($"Fecha de nacimiento: {this.FechaNacimiento}");
            sb.AppendLine($"Vacunas: ");

            foreach (Vacuna item in this.vacunas)
            {
                sb.AppendLine($"{item}");
            }

            return sb.ToString();
        }
    }
}
