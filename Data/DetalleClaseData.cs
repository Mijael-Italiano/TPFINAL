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
                                int idProfesor = Convert.ToInt32(reader["ID_Profesor"]);
                                int idClase = Convert.ToInt32(reader["ID_Clase"]);
                                Profesor profesor = profesorData.GetProfesorById(idProfesor);
                                Clase clase = claseData.GetClaseById(idClase);
                                lista.Add(DetalleClaseMapper.Map(reader, profesor, clase));
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
