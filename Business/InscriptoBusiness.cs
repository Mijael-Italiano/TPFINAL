using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
using System.Transactions;

namespace Business
{
    public class InscriptoBusiness
    {
        InscriptoData inscriptoData = new InscriptoData();
        ClaseBusiness claseBusiness = new ClaseBusiness();
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

        public void AsignarClaseAInscripto(int idInscripto, int idClase)
        {
            try
            {
                Inscripto inscriptoActual = inscriptoData.GetInscriptoById(idInscripto);

                if (inscriptoActual.clase != null && inscriptoActual.clase.Id_Clase != idClase)
                {
                    claseBusiness.DisminuirCantidadInscriptos(inscriptoActual.clase.Id_Clase);
                }

                using (TransactionScope scope = new TransactionScope())
                {
                    inscriptoData.AsociarClase(idInscripto, idClase);
                    claseBusiness.AumentarCantidadInscriptos(idClase);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar la clase al inscripto.", ex);
            }
        }
    }
}
