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


        public void AgregarProfesor(Profesor profesor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    ValidarProfesor(profesor);
                    profesorData.AgregarProfesor(profesor);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarProfesor(Profesor profesor)
        {
            if (string.IsNullOrWhiteSpace(profesor.Nombre))
            {
                throw new Exception("Debe ingresar un nombre.");
            }

            if (string.IsNullOrWhiteSpace(profesor.Apellido))
            {
                throw new Exception("Debe ingresar un apellido.");
            }

            if (profesor.DNI <= 0)
            {
                throw new Exception("El DNI debe ser un número válido mayor a cero.");
            }

            if (profesor.Disciplina == null)
            {
                throw new Exception("Debe seleccionar una disciplina.");
            }

            if (profesor.Sueldo < 0)
            {
                throw new Exception("El sueldo debe ser mayor o igual a cero.");
            }

        }






    }
}
