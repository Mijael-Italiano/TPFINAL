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
            List<Clase> clases = claseBusiness.GetLista();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Clase", typeof(int));
            tabla.Columns.Add("Cantidad_Inscriptos", typeof(int));
            tabla.Columns.Add("CuotaMensual", typeof(string));
            tabla.Columns.Add("Disciplina", typeof(string));
            tabla.Columns.Add("Maximo_Inscriptos", typeof(int));

            foreach (Clase c in clases)
            {
                DataRow fila = tabla.NewRow();
                fila["ID_Clase"] = c.Id_Clase;
                fila["Cantidad_Inscriptos"] = c.Cantidad_Inscriptos;
                fila["CuotaMensual"] = c.CuotaMensual;
                fila["Disciplina"] = c.Disciplina.Nombre_Disciplina;
                fila["Maximo_Inscriptos"] = c.Maximo_Alumnos;
                tabla.Rows.Add(fila);
            }

            grillaClase.DataSource = null;
            grillaClase.DataSource = tabla;
        }

        private void LlenarGrillaProfesor()
        {
            List<Profesor> profesores = profesorBusiness.GetLista();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Profesor", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));
            tabla.Columns.Add("DNI", typeof(int));
            tabla.Columns.Add("Disciplina", typeof(string));
            tabla.Columns.Add("Sueldo", typeof(decimal)); // 

            foreach (Profesor p in profesores)
            {
                DataRow fila = tabla.NewRow();
                fila["ID_Profesor"] = p.ID_Profesor;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;
                fila["DNI"] = p.DNI;
                fila["Disciplina"] = p.Disciplina.Nombre_Disciplina;
                fila["Sueldo"] = p.Sueldo;
                tabla.Rows.Add(fila);
            }

            grillaProfesor.DataSource = null;
            grillaProfesor.DataSource = tabla;
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
            if (grillaClase.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una clase de la grilla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idClaseSeleccionada = Convert.ToInt32(grillaClase.SelectedRows[0].Cells["ID_Clase"].Value);
            ClaseSeleccionada.Clase = claseBusiness.GetById(idClaseSeleccionada);

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
                int idClase = Convert.ToInt32(grillaClase.SelectedRows[0].Cells["ID_Clase"].Value);

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
                LlenarGrillaClase();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAgregarProfesor formAgregarProfesor = new FormAgregarProfesor();
            if (formAgregarProfesor.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaProfesor();
            }
        }

        private void btnEliminarInscripto_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaInscripto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int idInscripto = Convert.ToInt32(grillaInscripto.SelectedRows[0].Cells["ID_Inscripto"].Value);
                inscriptoBusiness.DeleteById(idInscripto);
                LlenarGrillaInscripto();
                MessageBox.Show("Inscripto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar inscripto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProfesor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un profesor para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int idProfesor = Convert.ToInt32(grillaProfesor.SelectedRows[0].Cells["ID_Profesor"].Value);
                profesorBusiness.DeleteById(idProfesor);
                LlenarGrillaProfesor(); 
                MessageBox.Show("Profesor eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar profesor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
