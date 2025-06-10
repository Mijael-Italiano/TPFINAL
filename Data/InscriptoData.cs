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
    public class InscriptoData
    {
        public List<Inscripto> ObtenerInscriptos()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString);
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT * FROM Inscriptos";
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Inscripto> lista = new List<Inscripto>();
                        while (reader.Read())
                        {
                            Inscripto i = new Inscripto
                            {
                                ID_Inscripto = Convert.ToInt32(reader["ID_Inscripto"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                DNI = Convert.ToInt32(reader["DNI"]),
                                ID_Clase = reader["ID_Clase"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["ID_Clase"])
                            };
                            lista.Add(i);
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
