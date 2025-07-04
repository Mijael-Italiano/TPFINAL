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
    public partial class FormAgregarProfesor : Form
    {
        DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness();
        ProfesorBusiness profesorBusiness = new ProfesorBusiness();
        public FormAgregarProfesor()
        {
            InitializeComponent();
            CargarComboDisciplinas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profesor nuevoProfesor = new Profesor();
            nuevoProfesor.Nombre = txtAgregarProfesorNombre.Text;
            nuevoProfesor.Apellido = txtAgregarProfesorApellido.Text;
            nuevoProfesor.DNI = Convert.ToInt32(txtAgregarProfesorDNI.Text);
            nuevoProfesor.Sueldo = Convert.ToInt32(txtAgregarProfesorSueldo.Text);
            nuevoProfesor.Disciplina = (Disciplina)cmbAgregarProfesorDisciplina.SelectedItem;

            profesorBusiness.AgregarProfesor(nuevoProfesor); // asumimos que existe
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CargarComboDisciplinas()
        {
            List<Disciplina> disciplinas = disciplinaBusiness.ObtenerDisciplinas();
            cmbAgregarProfesorDisciplina.DataSource = disciplinas;
            cmbAgregarProfesorDisciplina.DisplayMember = "Nombre_Disciplina";
            cmbAgregarProfesorDisciplina.ValueMember = "Id_Disciplina";
        }

    }
}
