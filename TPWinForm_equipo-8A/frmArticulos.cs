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
using static System.Net.Mime.MediaTypeNames;

namespace TPWinForm_equipo_8A
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
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

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
           

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvListaArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl.ImagenUrl);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvListaArticulos.Columns["Id"].Visible = false;
            dgvListaArticulos.Columns["IdMarca"].Visible = false;
            dgvListaArticulos.Columns["IdCategoria"].Visible = false;
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
            cargar();
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

        private void dgvListaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl.ImagenUrl);
            }
        }

       
    }
}
