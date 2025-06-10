using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Business
{
    public class InscriptoBusiness
    {
        InscriptoData inscriptoData = new InscriptoData();
        public List<Inscripto> GetLista()
        {
            
            try
            {
                return inscriptoData.ObtenerInscriptos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener inscriptos", ex);
            }
        }
    }
}
