using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPWinForm_equipo_8A
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        private List<Imagen> listaImagenes;
        private List<Imagen> imagenesArticuloActual;
        private int indiceImagenActual = 0;
        private int imagenActual = 0;
        private int cantidadDeImagenes = 0;

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarDatos();
        }
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvListaArticulos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un Articulo.");
                return;
            }
            Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
           
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if (dgvListaArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un Articulo.");
                    return;
                }

                seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;

                if (negocio.existeArticulosEnImagenes(seleccionado.Id))
                {
                    MessageBox.Show("No se puede eliminar un Articulo que esta asociada a Imagenes.", "ERROR POR REFERENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resp = MessageBox.Show("¿Eliminar Articulo? Esta acción es permanente y no se puede deshacer.", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resp == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.Id);
                    cargarDatos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvListaArticulos.Columns["Id"].Visible = false;
        }
        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                listaArticulos = negocio.listar();
                listaImagenes = imagenNegocio.listar();

                dgvListaArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                indiceImagenActual = 0;

                if (listaArticulos.Count > 0)
                {
                    Articulo seleccionado = listaArticulos[0];
                    cargarImagenesDelArticulo(seleccionado.Id);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void cargarImagenesDelArticulo(int idArticulo)
        {
            imagenesArticuloActual = new List<Imagen>();

            foreach (var img in listaImagenes)
            {
                if(img.IdArticulo == idArticulo)
                {
                    imagenesArticuloActual.Add(img);
                }
            }

            indiceImagenActual = 0;
            mostrarImagenActual();
        }

        private void mostrarImagenActual()
        {
            cantidadDeImagenes = imagenesArticuloActual.Count;
            if(imagenesArticuloActual == null || cantidadDeImagenes == 0)
            {
                cargarImagen("");
                imagenActual = 0;
                lblQImagenes.Text = imagenActual + "/" + cantidadDeImagenes;
                return;
            }
            cargarImagen(imagenesArticuloActual[indiceImagenActual].ImagenUrl);

            imagenActual = indiceImagenActual + 1;

            lblQImagenes.Text = imagenActual + "/" + cantidadDeImagenes;
        }

        private void cargarImagen(string imagenUrl)
        {
            string placeholder = "https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png";

            try
            {
                lblErrorImagen.Text = "";
                pbxImagen.Load(imagenUrl);
            }
            catch (System.Net.WebException)
            {
                lblErrorImagen.Text = "No se puede cargar imagen por problemas con la web";
                pbxImagen.Load(placeholder);
            }
            catch (Exception)
            {
                lblErrorImagen.Text = "Articulo sin Imagen";
                pbxImagen.Load(placeholder);
            }
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargarDatos();
            pnlFiltroAvanzado.Visible = false;
            btnFiltroAvanzado.Text = "+ Filtro Avanzado";
            cboCampo.Items.Add("SKU");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");


        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            if(btnFiltroAvanzado.Text == "+ Filtro Avanzado")
            {
                pnlFiltroAvanzado.Visible = true;
                btnFiltroAvanzado.Text = "- Filtro Avanzado";
            }
            else
            {
                pnlFiltroAvanzado.Visible = false;
                btnFiltroAvanzado.Text = "+ Filtro Avanzado";
            }
        }


        private void dgvListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                cargarImagenesDelArticulo(seleccionado.Id);
            }
        }

        private void btnAnteriorImagen_Click(object sender, EventArgs e)
        {
            if (imagenesArticuloActual == null || imagenesArticuloActual.Count == 0) return;
            if(indiceImagenActual > 0)
            {
                indiceImagenActual--;
                mostrarImagenActual();
            }
        }


        private void btnSiguienteImagen_Click(object sender, EventArgs e)
        {
            if (imagenesArticuloActual == null || imagenesArticuloActual.Count == 0) return;
            if (indiceImagenActual<imagenesArticuloActual.Count - 1)
            {
                indiceImagenActual++;
                mostrarImagenActual();
            }
        }
    }
}

