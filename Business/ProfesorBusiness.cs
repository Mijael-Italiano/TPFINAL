using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;


namespace Business
{
    public class ProfesorBusiness
    {
        ProfesorData profesorData = new ProfesorData();

        public List<Profesor> GetLista()
        {
            try
            {
                return profesorData.ObtenerProfesores();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener profesores", ex);
            }
        }
    }
}
