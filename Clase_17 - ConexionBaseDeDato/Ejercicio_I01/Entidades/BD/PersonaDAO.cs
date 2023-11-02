using Entidades.Exception;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.BD
{
    public class PersonaDAO
    {
        private static SqlConnection connection;
        private static string path;

        static PersonaDAO()
        {
            PersonaDAO.path = "Server=.;Database=Ejer_I01_Persona;Trusted_Connection=True;";
        }

        public void Guardar(Persona persona)
        {
        }

        public List<Persona> Leer()
        {
        }

        public Persona LeerPorId (int id)
        {
        }

        public void Modificar(Persona persona)
        {
        }

        public void Eliminar(int id)
        {
        }
    }
}
