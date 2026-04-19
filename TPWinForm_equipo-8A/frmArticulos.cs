using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace TPWinForm_equipo_8A
{
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                dgvListaArticulos.DataSource = negocio.lista();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
