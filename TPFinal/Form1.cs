using Business;
using Entity;
using System.Data;

namespace TPFinal
{
    public partial class Form1 : Form
    {
        ClaseBusiness claseBusiness = new ClaseBusiness();
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();
        InscriptoBusiness inscriptoBusiness = new InscriptoBusiness();
        ProfesorBusiness profesorBusiness = new ProfesorBusiness();
        public Form1()
        {
            InitializeComponent();
            LlenarGrillaClase();
            LlenarGrillaInscripto();
            LlenarGrillaProfesor();
        }

        private void LlenarGrillaClase()
        {
            grillaClase.DataSource = null;
            grillaClase.DataSource = claseBusiness.GetLista();
        }

        private void LlenarGrillaProfesor()
        {
            grillaProfesor.DataSource = null;
            grillaProfesor.DataSource = profesorBusiness.GetLista();
        }

        private void LlenarGrillaInscripto()
        {
            List<Inscripto> inscriptos = inscriptoBusiness.GetLista();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Inscripto", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));
            tabla.Columns.Add("DNI", typeof(int));
            tabla.Columns.Add("ID_Clase", typeof(object));

            foreach (Inscripto i in inscriptos)
            {
                DataRow fila = tabla.NewRow();
                fila["ID_Inscripto"] = i.ID_Inscripto;
                fila["Nombre"] = i.Nombre;
                fila["Apellido"] = i.Apellido;
                fila["DNI"] = i.DNI;
                fila["ID_Clase"] = i.clase?.Id_Clase ?? (object)DBNull.Value;
                tabla.Rows.Add(fila);
            }

            grillaInscripto.DataSource = null;
            grillaInscripto.DataSource = tabla;
        }

        private void btnDetalleClase_Click(object sender, EventArgs e)
        {
            using (FormDetalleClase detalle = new FormDetalleClase())
            {
                detalle.ShowDialog();
            }

        }

        private void btnAgregarInscripto_Click(object sender, EventArgs e)
        {
            FormAgregarInscripto formAgregarInscripto = new FormAgregarInscripto();
            if (formAgregarInscripto.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaInscripto();
            }
        }

        private void BtnAsignarClase_Click(object sender, EventArgs e)
        {
            if (grillaInscripto.SelectedRows.Count == 0 || grillaClase.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un inscripto y una clase.");
                return;
            }
            else
            {
                int idInscripto = Convert.ToInt32(grillaInscripto.SelectedRows[0].Cells["ID_Inscripto"].Value);
                //               int idInscripto = ((Inscripto)grillaInscripto.SelectedRows[0].DataBoundItem).ID_Inscripto;
                int idClase = ((Clase)grillaClase.SelectedRows[0].DataBoundItem).Id_Clase;
                DataGridViewRow filaSeleccionada = grillaInscripto.SelectedRows[0];
                inscriptoBusiness.AsignarClaseAInscripto(idInscripto, idClase);
                LlenarGrillaInscripto();
                LlenarGrillaClase();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAgregarClase formAgregarClase = new FormAgregarClase();
            if (formAgregarClase.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaInscripto();
            }
        }
    }
}
