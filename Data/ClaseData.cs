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
    public class ClaseData
    {
        public List<Clase> ObtenerClases()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString);
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT * FROM Clases";
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Clase> lista = new List<Clase>();
                        while (reader.Read())
                        {
                            Clase clase = new Clase
                            {
                                Id_Clase = Convert.ToInt32(reader["Id_Clase"]),
                                Nombre_Clase = reader["Nombre_Clase"].ToString(),
                                Cantidad_Inscriptos = Convert.ToInt32(reader["Cantidad_Inscriptos"]),
                                CuotaMensual = reader["CuotaMensual"].ToString()
                            };
                            lista.Add(clase);
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
