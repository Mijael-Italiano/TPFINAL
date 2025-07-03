using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entity;
using Mapper;

namespace Data
{
    public class DisciplinaData
    {
        public Disciplina GetDisciplinaById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Disciplina WHERE Id_Disciplina = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Disciplina disciplina = new Disciplina
                                {
                                    Id_Disciplina = Convert.ToInt32(reader["Id_Disciplina"]),
                                    Nombre_Disciplina = reader["Nombre_Disciplina"].ToString()
                                };
                                return disciplina;
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
    }
}
