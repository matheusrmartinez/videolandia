using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario frmFuncionario = new frmFuncionario();
            frmFuncionario.MdiParent = this;
            frmFuncionario.Show();
        }
    }
}
