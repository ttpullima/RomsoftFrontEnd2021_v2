using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romsoft.GESTIONCLINICA.Presentacion.ModuloAdmision.OrdenServicio
{
    public partial class frmFiltroPacienteCuenta : Form
    {
        public frmFiltroPacienteCuenta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
