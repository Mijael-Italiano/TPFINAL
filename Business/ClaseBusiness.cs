using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Business
{
    public class ClaseBusiness
    {
        ClaseData claseData = new ClaseData();
        public List<Clase> GetLista()
        {
            try
            {
                return claseData.ObtenerClases();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clases", ex);
            }
        }
    }
}
