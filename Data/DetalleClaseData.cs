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
    public class DetalleClaseData
    {
        public List<DetalleClase> ObtenerDetalleClases()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString);
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT * FROM Detalle_Clase";
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<DetalleClase> lista = new List<DetalleClase>();
                        while (reader.Read())
                        {
                            DetalleClase dc = new DetalleClase
                            {
                                Id_Detalle_Clases = Convert.ToInt32(reader["Id_Detalle_Clases"]),
                                Dia = reader["Dia"].ToString(),
                                Horario_Inicio = (TimeSpan)reader["Horario_Inicio"],
                                Horario_Fin = (TimeSpan)reader["Horario_Fin"],
                                ID_Profesor = Convert.ToInt32(reader["ID_Profesor"]),
                                ID_Clase = reader["ID_Clase"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["ID_Clase"])
                            };
                            lista.Add(dc);
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
