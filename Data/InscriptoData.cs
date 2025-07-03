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
                                i.clase = reader["ID_Clase"] == DBNull.Value
                                    ? null
                                    : claseData.GetClaseById(Convert.ToInt32(reader["ID_Clase"]));
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


        public Inscripto GetInscriptoById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Inscriptos WHERE ID_Inscripto = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Inscripto inscripto = new Inscripto
                                {
                                    ID_Inscripto = Convert.ToInt32(reader["ID_Inscripto"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    DNI = Convert.ToInt32(reader["DNI"]),
                                    clase = reader["ID_Clase"] == DBNull.Value
                                        ? null
                                        : claseData.GetClaseById(Convert.ToInt32(reader["ID_Clase"]))
                                };
                                return inscripto;
                            }
                            else
                            {
                                return null;
                            }
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

        public void AsociarClase(int idInscripto, int idClase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Inscriptos SET ID_Clase = @IdClase WHERE ID_Inscripto = @IdInscripto";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClase", idClase);
                    command.Parameters.AddWithValue("@IdInscripto", idInscripto);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
