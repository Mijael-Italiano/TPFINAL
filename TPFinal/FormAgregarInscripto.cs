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
    public partial class FormAgregarInscripto : Form
    {
        InscriptoBusiness inscriptoBusiness = new InscriptoBusiness();

        public FormAgregarInscripto()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Inscripto nuevoInscripto = new Inscripto();
                nuevoInscripto.Nombre = txtNombre.Text;
                nuevoInscripto.Apellido = txtApellido.Text;
                nuevoInscripto.DNI = Convert.ToInt32(txtDNI.Text);
                inscriptoBusiness.AddInscripto(nuevoInscripto);
                MessageBox.Show("Inscripto guardado exitosamente");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
