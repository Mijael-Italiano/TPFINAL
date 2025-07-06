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
    public partial class FormModificarClase : Form
    {
        ClaseBusiness claseBusiness = new ClaseBusiness();
        public FormModificarClase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nuevaCuota = Convert.ToInt32(txtModificarCuota.Text);
                int nuevoMaximo = Convert.ToInt32(txtModificarMaximoInscriptos.Text);

                ClaseSeleccionada.Clase.CuotaMensual = nuevaCuota;
                ClaseSeleccionada.Clase.Maximo_Alumnos = nuevoMaximo;

                claseBusiness.ModificarClase(ClaseSeleccionada.Clase);

                MessageBox.Show("Clase modificada correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la clase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
