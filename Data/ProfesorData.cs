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
                            profe.ID_Clase = Convert.ToInt32(reader["ID_Clase"]);
                            profe.DNI = reader["DNI"] != DBNull.Value ? Convert.ToInt32(reader["DNI"]) : 0;
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
