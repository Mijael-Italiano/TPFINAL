using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Configuration;
using Mapper;

namespace Data
{
    public class DetalleClaseData
    {
        ClaseData claseData = new ClaseData();
        ProfesorData profesorData = new ProfesorData();
        public List<DetalleClase> ObtenerDetalleClases()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString);
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT * FROM Detalle_Clase";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<DetalleClase> lista = new List<DetalleClase>();
                            while (reader.Read())
                            {
                                DetalleClase dc = new DetalleClase();
                                dc.Id_Detalle_Clases = Convert.ToInt32(reader["Id_Detalle_Clases"]);
                                dc.Dia = reader["Dia"].ToString();
                                dc.Horario_Inicio = (TimeSpan)reader["Horario_Inicio"];
                                dc.Horario_Fin = (TimeSpan)reader["Horario_Fin"];
                                dc.profesor = profesorData.GetProfesorById(Convert.ToInt32(reader["ID_Profesor"]));
                                dc.clase = claseData.GetClaseById(Convert.ToInt32(reader["ID_Clase"]));
                                lista.Add(dc);
                            }
                            return lista;
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
