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
           dgvListaArticulos.Columns["Precio"].Visible = false;
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
                lblQImagenes.Text = "0";
                btnAnteriorImagen.Visible = false;
                btnSiguienteImagen.Visible = false;
                return;
            }
            else
            {
                btnAnteriorImagen.Visible = true;
                btnSiguienteImagen.Visible = true;
            }
            cargarImagen(imagenesArticuloActual[indiceImagenActual].ImagenUrl);

            imagenActual = indiceImagenActual + 1;
            lblQImagenes.Text = imagenActual + "/" + cantidadDeImagenes;
            if (imagenActual == 1)
            {
                btnAnteriorImagen.Enabled = false;
            }
            else
            {
                btnAnteriorImagen.Enabled = true;
            }

            if (imagenActual == cantidadDeImagenes)
            {
                btnSiguienteImagen.Enabled = false;
            }
            else
            {
                btnSiguienteImagen.Enabled = true;
            }
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
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Precio");


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
            if (imagenesArticuloActual == null || imagenesArticuloActual.Count == 0) 
            {
                btnAnteriorImagen.Visible = false;
            };
            if(indiceImagenActual > 0)
            {
                indiceImagenActual--;
                mostrarImagenActual();
            }
        }


        private void btnSiguienteImagen_Click(object sender, EventArgs e)
        {
            if (imagenesArticuloActual == null || imagenesArticuloActual.Count == 0)
            {
                btnSiguienteImagen.Visible = false;
            }
            ;
            if (indiceImagenActual < imagenesArticuloActual.Count - 1)
            {
                indiceImagenActual++;
                mostrarImagenActual();
            }
        }
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo para filtrar");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                //MessageBox.Show("Seleccione un criterio para filtrar");
                labelCriterio.ForeColor = Color.Red;
                labelCriterio.Visible= true;

                return true;
            }
            else
            {
                labelCriterio.Visible = false;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(textBoxBuscar.Text))
                {
                    MessageBox.Show("Debes cargar el filtro numérico");
                    return true;
                }
                if (!(NumerosDecimales(textBoxBuscar.Text)))
                {
                    MessageBox.Show("Solo debe escribir números");
                    return true;
                }
            }
            return false;
        }
        private bool NumerosDecimales(string cadena)
        {
            int coma = 0;
            foreach (char caracter in cadena)
            {
                {
                    if (!(char.IsNumber(caracter)))
                    {
                        if (caracter == '.')
                            coma++;
                        else
                            return false;
                    }
                }
            }
            if (coma > 1)
                return false;
            else
                return true;
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;
            if (filtro.Length > 1)
            {
                listaFiltrada = listaArticulos.FindAll(x => 
                                        x.Codigo.ToUpper().Contains(filtro.ToUpper()) ||
                                        x.Nombre.ToUpper().Contains(filtro.ToUpper()) || 
                                        x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || 
                                        x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || 
                                        x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper())
                                        );
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvListaArticulos.DataSource = null;
            dgvListaArticulos.DataSource = listaFiltrada;
    
            ocultarColumnas();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                {
                    return;
                }
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = textBoxBuscar.Text;

                dgvListaArticulos.DataSource = negocio.filtrarArticulo(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboCampo.SelectedItem != null)
            {

                string opcion = cboCampo.SelectedItem.ToString();
                if (opcion == "Precio")
                {
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Mayor a");
                    cboCriterio.Items.Add("Menor a");
                    cboCriterio.Items.Add("Igual a");
                }
                else
                {
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Comienza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                }
            }
            else
            {
                cboCriterio.Items.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarDatos();
            cboCampo.SelectedIndex = -1;
            textBoxBuscar.Clear();
            txtFiltroRapido.Clear();
        }
    }
}

