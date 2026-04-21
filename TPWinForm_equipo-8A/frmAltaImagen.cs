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
    public partial class frmAltaImagen : Form
    {
        private int idArchivo;
        private bool modificado;
        List<Imagen> listaImg = new List<Imagen>();
        List<Imagen> imagenesArticuloActual;
        Imagen seleccionado;
        public frmAltaImagen()
        {
            InitializeComponent();
        }
        public frmAltaImagen(int idArchivo)
        {
            InitializeComponent();
            this.idArchivo = idArchivo;
            Text = "Agregar Imagen";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaImagen_Load(object sender, EventArgs e)
        {
            ImagenNegocio imagenN = new ImagenNegocio();
            try
            {
               btnEliminarAltaImagen.Enabled = false;
               btnModificarAltaImagen.Enabled=false;
               listaImg = imagenN.listar(this.idArchivo);

               if (listaImg.Count > 0)
               {
                   refrescarGrilla();
               }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //AGREGAR IMAGEN
        private void btnAgregarAltaImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrlAltaImagen.Text)) return;

            try
            {
                Imagen nueva;

                if (!modificado)
                {
                    nueva = new Imagen();
                    nueva.ImagenUrl = txtUrlAltaImagen.Text;
                    nueva.IdArticulo = this.idArchivo;

                    listaImg.Add(nueva);
                }
                else
                {
                    seleccionado.ImagenUrl = txtUrlAltaImagen.Text;
                    modificado = false;
                    seleccionado = null;
                    btnModificarAltaImagen.Enabled = true;
                    btnAgregarAltaImagen.Text = "Agregar";

                }

                refrescarGrilla();
                txtUrlAltaImagen.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        //ELIMINAR IMAGEN
        private void btnEliminarAltaImagen_Click(object sender, EventArgs e)
        {
            try
            {
                Imagen seleccionado = (Imagen)dgvAltaImagen.CurrentRow.DataBoundItem;
                if (seleccionado != null && !string.IsNullOrEmpty(seleccionado.ImagenUrl))
                {
                    listaImg.Remove(seleccionado);
                    refrescarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //MODIFICAR IMAGEN
        private void btnModificarAltaImagen_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado = (Imagen)dgvAltaImagen.CurrentRow.DataBoundItem;
                if (seleccionado != null && !string.IsNullOrEmpty(seleccionado.ImagenUrl))
                {
                    modificado = true;
                    txtUrlAltaImagen.Text = seleccionado.ImagenUrl;
                    btnModificarAltaImagen.Enabled = false;
                    btnAgregarAltaImagen.Text = "Guardar";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //LISTAR IMAGENES DE ARTICULOS
        private void cargarImagenesDelArticulo(int idArticulo)
        {
            imagenesArticuloActual = new List<Imagen>();

            foreach (var img in imagenesArticuloActual)
            {
                if (img.IdArticulo == idArticulo)
                {
                    listaImg.Add(img);
                }
            }

        }

        private void refrescarGrilla()
        {
            
            dgvAltaImagen.SelectionChanged -= dgvAltaImagen_SelectionChanged;

           
            dgvAltaImagen.DataSource = null;
            if (listaImg.Count > 0)
            {
                dgvAltaImagen.DataSource = listaImg;
                ocultarColumnas();
            }

            dgvAltaImagen.SelectionChanged += dgvAltaImagen_SelectionChanged;
        }

     
        private void ocultarColumnas()
        {
            dgvAltaImagen.Columns["Id"].Visible = false;
            dgvAltaImagen.Columns["IdArticulo"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxAltaImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }

        }


        private void dgvAltaImagen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAltaImagen.CurrentRow == null || dgvAltaImagen.CurrentRow.Index < 0)
                return;
            try
            {
                Imagen seleccionado = (Imagen)dgvAltaImagen.CurrentRow.DataBoundItem;
                if (seleccionado != null && !string.IsNullOrEmpty(seleccionado.ImagenUrl))
                {
                    cargarImagen(seleccionado.ImagenUrl);
                    btnModificarAltaImagen.Enabled = true;
                    btnEliminarAltaImagen.Enabled=true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
        private void txtUrlAltaImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlAltaImagen.Text);
        }

        private void btnAceptarAltaImagen_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();

            try
            {
               /*foreach (var item in listaImg)
                {
                    negocio.agregar(item);
                }*/
                foreach (var item in listaImg)
                {
                    if (item.Id == 0)
                    {
                        negocio.agregar(item);
                    }

                }

                MessageBox.Show("¡Imágenes guardadas con éxito!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.ToString());
            }
        }
    }
}
