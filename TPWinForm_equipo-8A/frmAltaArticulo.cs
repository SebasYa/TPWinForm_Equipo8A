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
            //ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
               /* cboxTipo.DataSource = elementoNegocio.listar();
                cboxTipo.ValueMember = "Id";
                cboxTipo.DisplayMember = "Descripcion";

                cboxDebilidad.DataSource = elementoNegocio.listar();
                cboxDebilidad.ValueMember = "Id";
                cboxDebilidad.DisplayMember = "Descripcion";

                if (pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtImagen.Text = pokemon.Imagen;
                    cargarImagen(pokemon.Imagen);
                    cboxTipo.SelectedValue = pokemon.Tipo.Id;
                    cboxDebilidad.SelectedValue = pokemon.Debilidad.Id;

                }*/
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
