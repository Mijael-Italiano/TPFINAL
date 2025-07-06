using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class FormModificarInscripto : Form
    {
        InscriptoBusiness inscriptoBusiness = new InscriptoBusiness();
        public FormModificarInscripto()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                InscriptoSeleccionado.Inscripto.Nombre = txtModificarNombre.Text;
                InscriptoSeleccionado.Inscripto.Apellido = txtModificarApellido.Text;
                InscriptoSeleccionado.Inscripto.DNI = Convert.ToInt32(txtModificarDNI.Text);

                inscriptoBusiness.ModificarInscripto(InscriptoSeleccionado.Inscripto);

                MessageBox.Show("Inscripto modificado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el inscripto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
