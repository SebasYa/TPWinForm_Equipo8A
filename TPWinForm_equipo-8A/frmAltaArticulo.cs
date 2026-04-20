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

        private void btnCancelarAltaArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAltaArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null) articulo = new Articulo();
                if (articulo.ImagenUrl == null) articulo.ImagenUrl = new Imagen();

                if (string.IsNullOrWhiteSpace(txtCodigoArticulo.Text))
                {
                    MessageBox.Show("Debe ingresar un Codigo.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNombreArticulo.Text))
                {
                    MessageBox.Show("Debe ingresar un Nombre.");
                    return;
                }
                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombreArticulo.Text;
                articulo.Descripcion = txtDescripcionArticulo.Text;
                articulo.ImagenUrl.ImagenUrl = txtImagenArticulo.Text;
                articulo.Precio = decimal.Parse(txtPrecioArticulo.Text);

                articulo.Marca = (Marca)cbxMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoriaArticulo.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente!");
                }
                else
                {
                    //negocio.agregar(articulo);
                    //MessageBox.Show("Agregado Exitosamente!!!");
                }
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnImagenArticulo_Click(object sender, EventArgs e)
        {

        }
    }
}
