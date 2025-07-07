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
    public partial class FormModificarDetalleClase : Form
    {
        ProfesorBusiness profesorBusiness = new ProfesorBusiness();
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();
        public FormModificarDetalleClase()
        {
            InitializeComponent();
            CargarDiasDeLaSemana();
            CargarProfesoresPorDisciplinaSeleccionada();
        }


        private void CargarProfesoresPorDisciplinaSeleccionada()
        {
            try
            {
                int idDisciplina = DetalleClaseSeleccionada.DetalleClase.clase.Disciplina.Id_Disciplina;
                List<Profesor> profesores = profesorBusiness.GetPorDisciplina(idDisciplina) ?? new List<Profesor>();
                cmbProfesorModificar.DataSource = profesores;
                cmbProfesorModificar.DisplayMember = "Apellido"; // o "NombreCompleto"
                cmbProfesorModificar.ValueMember = "ID_Profesor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los profesores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void CargarDiasDeLaSemana()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            cmbModificarDia.Items.AddRange(dias);
            cmbModificarDia.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
