using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_8A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas ventana = new frmMarcas();
            ventana.ShowDialog();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos ventana = new frmArticulos();
            ventana.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias ventana = new frmCategorias();
            ventana.ShowDialog();
        }
    }
}
