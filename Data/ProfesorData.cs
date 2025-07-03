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
    public class ProfesorData
    {
        DisciplinaData disciplinaData = new DisciplinaData();
        public List<Profesor> ObtenerProfesores()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
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
 
                                profe.Disciplina = disciplinaData.GetDisciplinaById(Convert.ToInt32(reader["Id_Disciplina"]));
                                profe.DNI = Convert.ToInt32(reader["DNI"]);
                                lista.Add(profe);
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


        public Profesor GetProfesorById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Gimnasio"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Profesores WHERE ID_Profesor = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Profesor profe = new Profesor();
                                profe.ID_Profesor = Convert.ToInt32(reader["ID_Profesor"]);
                                profe.Nombre = reader["Nombre"].ToString();
                                profe.Apellido = reader["Apellido"].ToString();
                                profe.Sueldo = Convert.ToInt32(reader["Sueldo"]);
                                profe.Disciplina = disciplinaData.GetDisciplinaById(Convert.ToInt32(reader["Id_Disciplina"]));
                                profe.DNI = Convert.ToInt32(reader["DNI"]);
                                return profe;
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
