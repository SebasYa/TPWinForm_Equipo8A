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
            ImagenNegocio imagenN = new ImagenNegocio();

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
                    txtPrecioArticulo.Text = articulo.Precio.ToString();

                    cbxMarcaArticulo.SelectedValue = articulo.Marca.Descripcion;
                    cbxCategoriaArticulo.SelectedValue = articulo.Categoria.Descripcion;



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
                articulo.Precio = decimal.Parse(txtPrecioArticulo.Text);

                articulo.Marca = (Marca)cbxMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoriaArticulo.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente!");
                    this.Close();
                }
                else
                {
                    int idNuevoArticulo = negocio.agregar(articulo);

                    DialogResult respuesta = MessageBox.Show("El articulo fue creado exitosamente.\n\n¿Desea asignarle una imagen ahora?", "Asignar Imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(respuesta == DialogResult.Yes)
                    {
                        frmAltaImagen ventanaImagen = new frmAltaImagen(idNuevoArticulo);
                        ventanaImagen.ShowDialog();
                    }
                    this.Close();
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
