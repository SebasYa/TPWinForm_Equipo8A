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
    public partial class frmAltaMarca : Form
    {
        private Marca marca = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (marca == null) marca = new Marca();

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre.");
                    return;
                }
                marca.Descripcion = txtNombre.Text;

                if (marca.Id != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Modificado Exitosamente!");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado Exitosamente!!!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if(marca != null)
                {
                    txtNombre.Text = marca.Descripcion;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
