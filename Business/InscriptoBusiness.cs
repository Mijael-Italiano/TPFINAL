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



        public void AddInscripto(Inscripto inscripto)
        {

            try
            {
                if (inscripto.Nombre == null)
                {
                    throw new Exception("Nombre requerido");
                }

                if (inscripto.Apellido == null)
                {
                    throw new Exception("Apellido requerido");
                }

                inscriptoData.AddInscripto(inscripto);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
