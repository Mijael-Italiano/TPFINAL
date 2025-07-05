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
    public class ClaseBusiness
    {
        ClaseData claseData = new ClaseData();
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();
        //      InscriptoBusiness inscriptoBusiness = new InscriptoBusiness();

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

        public Clase GetById(int id)
        {
            try
            {
                return claseData.GetClaseById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la clase por ID", ex);
            }
        }

        public void DisminuirCantidadInscriptos(int idClase)
        {
            claseData.DecrementarCantidadInscriptos(idClase);
        }




        public void AgregarClase(Clase clase)
        {
            try
            {
                List<Clase> clasesExistentes = GetLista();
                using (TransactionScope scope = new TransactionScope())
                {
                    Clase claseGimnasioExistente = clasesExistentes.Find(c => c.Disciplina.Nombre_Disciplina == "Gimnasio");
                    if (clase.Disciplina.Nombre_Disciplina == "Gimnasio" && claseGimnasioExistente != null)
                    {
                        throw new Exception("Ya existe una clase para la disciplina 'Gimnasio'.");
                    }
                    ValidarClase(clase);
                    claseData.AgregarClase(clase);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarClase(Clase clase)
        {
            if (clase.CuotaMensual <= 0)
            {
                throw new Exception("La cuota mensual debe ser mayor a cero.");
            }

            if (clase.Maximo_Alumnos <= 0)
            {
                throw new Exception("El máximo de inscriptos debe ser mayor a cero.");
            }

            if (clase.Disciplina == null)
            {
                throw new Exception("Debe seleccionar una disciplina.");
            }
        }

        public void DeleteById(int idClase)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    detalleClaseBusiness.EliminarPorClase(idClase);
                    claseData.DeleteById(idClase);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la clase: " + ex.Message, ex);
            }
        }



        public void AumentarCantidadInscriptos(int idClase)
        {
            claseData.IncrementarCantidadInscriptos(idClase);
        }
    }
}
