using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entity;

namespace TPFinal
{
    public partial class FormDetalleClase : Form
    {
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();

        /*private void LlenarGrillaDetalleClase()
        {
            grillaClaseDetalle.DataSource = null;
            grillaClaseDetalle.DataSource = detalleClaseBusiness.GetLista();
        }*/

        private void LlenarGrillaDetalleClase()
        {
            try
            {
                List<DetalleClase> detalles = detalleClaseBusiness.GetPorClase(ClaseSeleccionada.Clase);

                DataTable tabla = new DataTable();
                tabla.Columns.Add("ID_Clase", typeof(int));
                tabla.Columns.Add("Nombre_Profesor", typeof(string));
                tabla.Columns.Add("Apellido_Profesor", typeof(string));
                tabla.Columns.Add("Dia", typeof(string));
                tabla.Columns.Add("Horario_Inicio", typeof(string));
                tabla.Columns.Add("Horario_Fin", typeof(string));

                foreach (DetalleClase detalle in detalles)
                {
                    DataRow fila = tabla.NewRow();
                    fila["ID_Clase"] = detalle.clase.Id_Clase;
                    fila["Nombre_Profesor"] = detalle.profesor.Nombre;
                    fila["Apellido_Profesor"] = detalle.profesor.Apellido;
                    fila["Dia"] = detalle.Dia;
                    fila["Horario_Inicio"] = detalle.Horario_Inicio.ToString(@"hh\:mm");
                    fila["Horario_Fin"] = detalle.Horario_Fin.ToString(@"hh\:mm");
                    tabla.Rows.Add(fila);
                }

                grillaClaseDetalle.DataSource = null;
                grillaClaseDetalle.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de la clase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public FormDetalleClase()
        {
            InitializeComponent();
            LlenarGrillaDetalleClase();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarTurno formAgregarTurno = new FormAgregarTurno();
            if (formAgregarTurno.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaDetalleClase();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
