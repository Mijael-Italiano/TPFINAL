using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Business
{
    public class DetalleClaseBusiness
    {
        public List<DetalleClase> GetLista()
        {
            DetalleClaseData detalleClaseData = new DetalleClaseData();
            try
            {
                return detalleClaseData.ObtenerDetalleClases();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalle de clases", ex);
            }
        }

    }
}
