using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_8A
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            lblTituloAltaArticulo.Text = "Modificar Articulo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaN = new MarcaNegocio();
            CategoriaNegocio categoriaN = new CategoriaNegocio();
            try
            {
                cbxMarcaArticulo.DataSource = marcaN.listar();
                cbxMarcaArticulo.ValueMember = "Descripcion";
                cbxMarcaArticulo.DisplayMember = "Marca";

                cbxCategoriaArticulo.DataSource = categoriaN.listar();
                cbxCategoriaArticulo.ValueMember = "Descripcion";
                cbxCategoriaArticulo.DisplayMember = "Categoria";

                if(articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombreArticulo.Text = articulo.Nombre;
                    txtDescripcionArticulo.Text = articulo.Descripcion;
                    txtImagenArticulo.Text = articulo.ImagenUrl.ImagenUrl;
                    txtPrecioArticulo.Text = articulo.Precio.ToString();

                    cbxMarcaArticulo.SelectedValue = articulo.Marca.Descripcion;
                    cbxCategoriaArticulo.SelectedValue = articulo.Categoria.Descripcion;

                    pbxAltaArticulo.Load(txtImagenArticulo.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
