using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_8A
{
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }
        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                if (categoria == null) categoria = new Categoria();

                if (string.IsNullOrWhiteSpace(textBoxCategoria.Text))
                {
                    MessageBox.Show("Debe ingresar una Categoria.");
                    return;
                }
                categoria.Descripcion = textBoxCategoria.Text;

                if (categoria.Id != 0)
                {
                    categoriaNegocio.modificar(categoria);
                    MessageBox.Show("Categoria modificada exitosamente!");
                }
                else
                {
                    categoriaNegocio.agregar(categoria);
                    MessageBox.Show("Categoria agregada exitosamente!");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {
                    textBoxCategoria.Text = categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
