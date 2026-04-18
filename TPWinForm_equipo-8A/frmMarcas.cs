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
using dominio;

namespace TPWinForm_equipo_8A
{
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            try
            {
                MarcaNegocio negocio = new MarcaNegocio();
                dgvMarcas.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaMarca alta = new frmAltaMarca();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAltaMarca modificar = new frmAltaMarca(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                if(dgvMarcas.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona una Marca.");
                    return;
                }

                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                if(negocio.existeMarcaEnArticulos(seleccionado.Id))
                {
                    MessageBox.Show("No se puede eliminar una Marca que esta asociada a uno o mas Articulos.", "ERROR POR REFERENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resp = MessageBox.Show("¿Eliminar marca? Esta acción es permanente y no se puede deshacer.", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resp == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
