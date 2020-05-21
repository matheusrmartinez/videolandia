using System;
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
            frmCadastroCliente frmCliente = new frmCadastroCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frmFuncionario = new frmCadastroFuncionario();
            frmFuncionario.MdiParent = this;
            frmFuncionario.Show();
        }

        private void gêneroFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroGenero frmCadastroGenero = new frmCadastroGenero();
            frmCadastroGenero.MdiParent = this;
            frmCadastroGenero.Show();
        }

        private void personagensFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDePersonagens frmCadastroDePersonagens = new frmCadastroDePersonagens();
            frmCadastroDePersonagens.MdiParent = this;
            frmCadastroDePersonagens.Show();
        }

        private void artistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroArtista frmCadastroArtista = new frmCadastroArtista();
            frmCadastroArtista.MdiParent = this;
            frmCadastroArtista.Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroItem frmCadastroItem = new frmCadastroItem();
            frmCadastroItem.MdiParent = this;
            frmCadastroItem.Show();
        }
    }
}
