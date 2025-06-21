using Business;

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
            grillaInscripto.DataSource = null;
            grillaInscripto.DataSource = inscriptoBusiness.GetLista();
        }

        /*   private void LlenarGrillaDetalleClase()
           {
               grillaClaseDetalle.DataSource = null;
               grillaClaseDetalle.DataSource = detalleClaseBusiness.GetLista();
           }*/

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
    }
}
