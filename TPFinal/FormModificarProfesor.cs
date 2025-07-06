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
    public partial class FormModificarProfesor : Form
    {
        ProfesorBusiness profesorBusiness = new ProfesorBusiness();
        public FormModificarProfesor()
        {
            InitializeComponent();
        }

        private void btnModificarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                ProfesorSeleccionado.Profesor.Nombre = txtNombreProfesor.Text;
                ProfesorSeleccionado.Profesor.Apellido = txtApellidoProfesor.Text;
                ProfesorSeleccionado.Profesor.DNI = Convert.ToInt32(txtDNIProfesor.Text);
                ProfesorSeleccionado.Profesor.Sueldo = Convert.ToInt32(txtSueldoProfesor.Text);

                profesorBusiness.ModificarProfesor(ProfesorSeleccionado.Profesor);

                MessageBox.Show("Profesor modificado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el profesor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
