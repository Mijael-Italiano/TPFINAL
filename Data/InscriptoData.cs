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
        ClaseData claseData = new ClaseData();
        public List<Inscripto> ObtenerInscriptos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
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
                                Inscripto i = new Inscripto();
                                i.ID_Inscripto = Convert.ToInt32(reader["ID_Inscripto"]);
                                i.clase = claseData.GetClaseById(Convert.ToInt32(reader["ID_Inscripto"]));
                                i.Nombre = reader["Nombre"].ToString();
                                i.Apellido = reader["Apellido"].ToString();
                                i.DNI = Convert.ToInt32(reader["DNI"]);
                                lista.Add(i);
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

        public void AddInscripto(Inscripto inscripto)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO INSCRIPTOS (NOMBRE, APELLIDO, DNI) VALUES(@Nombre, @Apellido, @DNI)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", inscripto.Nombre);
                        command.Parameters.AddWithValue("@Apellido", inscripto.Apellido);
                        command.Parameters.AddWithValue("@DNI", inscripto.DNI);
                        command.ExecuteNonQuery();
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
