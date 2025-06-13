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

namespace TPFinal
{
    public partial class FormDetalleClase : Form
    {
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();
        private void LlenarGrillaDetalleClase()
        {
            grillaClaseDetalle.DataSource = null;
            grillaClaseDetalle.DataSource = detalleClaseBusiness.GetLista();
        }
        public FormDetalleClase()
        {
            InitializeComponent();
            LlenarGrillaDetalleClase();
        }
    }
}
