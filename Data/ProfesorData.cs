using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Configuration;

namespace Data
{
    public class ProfesorData
    {
        public List<Profesor> ObtenerProfesores()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString);
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT * FROM Profesores";
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Profesor> lista = new List<Profesor>();
                        while (reader.Read())
                        {
                            Profesor profe = new Profesor
                            {
                                ID_Profesor = Convert.ToInt32(reader["ID_Profesor"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Sueldo = Convert.ToInt32(reader["Sueldo"]),
                                Disciplina = reader["Disciplina"].ToString()
                            };
                            lista.Add(profe);
                        }
                        return lista;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
