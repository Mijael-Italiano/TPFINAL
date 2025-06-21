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
                            Profesor profe = new Profesor();
                            profe.ID_Profesor = Convert.ToInt32(reader["ID_Profesor"]);
                            profe.Nombre = reader["Nombre"].ToString();
                            profe.Apellido = reader["Apellido"].ToString();
                            profe.Sueldo = Convert.ToInt32(reader["Sueldo"]);
                            profe.Disciplina = reader["Disciplina"].ToString();
                            profe.DNI = Convert.ToInt32(reader["DNI"]);
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


        public Profesor GetProfesorById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Profesores WHERE ID_Profesor = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Profesor profe = new Profesor();
                            profe.ID_Profesor = Convert.ToInt32(reader["ID_Profesor"]);
                            profe.Nombre = reader["Nombre"].ToString();
                            profe.Apellido = reader["Apellido"].ToString();
                            profe.Sueldo = Convert.ToInt32(reader["Sueldo"]);
                            profe.Disciplina = reader["Disciplina"].ToString();
                            profe.DNI = Convert.ToInt32(reader["DNI"]);
                            return profe;
                        }
                        else
                        {
                            return null; // No se encontró el profesor
                        }
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
