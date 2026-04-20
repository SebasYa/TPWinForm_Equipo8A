using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

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
                imagenesArticuloActual = new List<Imagen>();
                indiceImagenActual = 0;

                if(listaArticulos.Count > 0)
                {
                    Articulo seleccionado = listaArticulos[0];
                    cargarImagenesDelArticulo(seleccionado.Id);
                }
                else
                {
                    cargarImagen("");
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
            if(imagenesArticuloActual == null || imagenesArticuloActual.Count == 0)
            {
                cargarImagen("");
                return;
            }
            cargarImagen(imagenesArticuloActual[indiceImagenActual].ImagenUrl);
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
                //lblErrorImagen.Text = "Error al cargar la imagen";
                lblErrorImagen.Text = "";
                pbxImagen.Load(placeholder);
            }
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargarDatos();
            pnlFiltroAvanzado.Visible = false;
            btnFiltroAvanzado.Text = "+ Filtro Avanzado";
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
                //cargarImagen(seleccionado.ImagenUrl.ImagenUrl);
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

