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
        //private static SqlConnection connection;
        private static string path;

        static PersonaDAO()
        {
            PersonaDAO.path = "Server=.;Database=Ejer_I01_Persona;Trusted_Connection=True;";
        }

        public void Guardar(Persona persona)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(PersonaDAO.path))
                {
                    string query = "INSERT INTO personas (nombre,apellido,) values (@nombre,@apellido)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("nombre", persona.Nombre);
                    command.Parameters.AddWithValue("apellido", persona.Apellido);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.GetInt32(0);
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw new ExceptionPersonaDAO("Error al guardar", ex);
            }
        }

        //public List<Persona> Leer()
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(PersonaDAO.path))
        //        {
                    
        //        }
        //    }
        //    catch (System.Exception)
        //    {

        //        throw;
        //    }
        //}

        //public Persona LeerPorId (int id)
        //{
        //}

        //public void Modificar(Persona persona)
        //{
        //}

        //public void Eliminar(int id)
        //{
        //}
    }
}
