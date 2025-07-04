using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Business;

namespace TPFinal
{
    public partial class FormAgregarClase : Form
    {
        DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness();
        ClaseBusiness claseBusiness = new ClaseBusiness();
        public FormAgregarClase()
        {
            InitializeComponent();
            CargarComboDisciplinas();
        }

        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
            try
            {
                Clase nuevaClase = new Clase();
                nuevaClase.Cantidad_Inscriptos = 0; 
                nuevaClase.CuotaMensual = Convert.ToInt32(txtAgregarCuotaMensual.Text);
                nuevaClase.Maximo_Alumnos = Convert.ToInt32(txtAgregarMaximoInscriptos.Text);
                nuevaClase.Disciplina = (Disciplina)cmbAgregarClase.SelectedItem;
                List<Clase> clasesExistentes = claseBusiness.GetLista();
                claseBusiness.AgregarClase(nuevaClase);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarComboDisciplinas()
        {
            List<Disciplina> disciplinas = disciplinaBusiness.ObtenerDisciplinas();
            cmbAgregarClase.DataSource = disciplinas;
            cmbAgregarClase.DisplayMember = "Nombre_Disciplina";
            cmbAgregarClase.ValueMember = "Id_Disciplina";
        }
    }
}
