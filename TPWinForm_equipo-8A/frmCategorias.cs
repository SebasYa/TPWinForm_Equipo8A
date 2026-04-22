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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                dgvCategorias.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria categoria;
            categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAltaCategoria modificar = new frmAltaCategoria(categoria);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            Categoria categoria;
            try
            {
                if (dgvCategorias.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona una Marca.");
                    return;
                }

                categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                if (categoriaNegocio.existeCategoria(categoria.Id))
                {
                    MessageBox.Show("No se puede eliminar una Categoria que esta asociada a uno o mas Articulos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resp = MessageBox.Show("¿Desea eliminar la categoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resp == DialogResult.Yes)
                {
                    categoriaNegocio.eliminar(categoria.Id);
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
