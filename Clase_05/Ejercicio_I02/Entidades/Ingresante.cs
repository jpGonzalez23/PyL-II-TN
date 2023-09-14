using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string[] curso;
        private string direccion;
        private string nombre;
        private string pais;
        private string genero;
        private int edad;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] curso, int edad)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.pais = pais;
            this.curso = curso;
            this.direccion = direccion;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre y apellido: {this.nombre}");
            
            sb.AppendLine($"Direccion: {this.direccion}");
            
            sb.AppendLine($"Edad: {this.edad}");
            
            sb.AppendLine($"Género: {this.genero}");
            
            sb.AppendLine($"País: {this.pais}");
            
            sb.AppendLine($"Curso/s: {this.curso}");
            
            foreach (string item in curso)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }
}