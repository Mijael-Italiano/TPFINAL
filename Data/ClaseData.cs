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
    public class ClaseData
    {
        DisciplinaData disciplinaData = new DisciplinaData();
        public List<Clase> ObtenerClases()
        {
            try
            {
                List<Clase> clases = new List<Clase>();

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT Id_Clase, Cantidad_Inscriptos, CuotaMensual, Id_Disciplina, Maximo_Inscriptos FROM Clases";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idDisciplina = Convert.ToInt32(reader["Id_Disciplina"]);
                                Disciplina disciplina = disciplinaData.GetDisciplinaById(idDisciplina);
                                clases.Add(ClaseMapper.Map(reader, disciplina));
                            }
                        }
                    }
                }

                return clases;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public Clase GetClaseById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Clases WHERE Id_Clase = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idDisciplina = Convert.ToInt32(reader["Id_Disciplina"]);
                                Disciplina disciplina = disciplinaData.GetDisciplinaById(idDisciplina);
                                return ClaseMapper.Map(reader, disciplina);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void IncrementarCantidadInscriptos(int idClase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Clases SET Cantidad_Inscriptos = Cantidad_Inscriptos + 1 WHERE Id_Clase = @IdClase";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClase", idClase);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DecrementarCantidadInscriptos(int idClase)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Clases SET Cantidad_Inscriptos = Cantidad_Inscriptos - 1 WHERE Id_Clase = @IdClase";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdClase", idClase);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
