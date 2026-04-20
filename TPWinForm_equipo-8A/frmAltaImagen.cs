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
    public partial class frmAltaImagen : Form
    {
        private int idArchivo;
        public frmAltaImagen()
        {
            InitializeComponent();
        }
        public frmAltaImagen(int idArchivo)
        {
            InitializeComponent();
            this.idArchivo = idArchivo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
