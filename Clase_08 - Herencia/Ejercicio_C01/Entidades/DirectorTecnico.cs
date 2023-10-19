using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre) { }
       
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento}");
            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1,  DirectorTecnico dt2)
        {
            return dt1.fechaNacimiento == dt2.fechaNacimiento ? true : false;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
