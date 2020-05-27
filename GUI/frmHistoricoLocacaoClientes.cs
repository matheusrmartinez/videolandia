using DAL;
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
    public partial class frmHistoricoLocacaoClientes : Form
    {
        PessoaDAL pessoaDAL;
        public frmHistoricoLocacaoClientes()
        {
            InitializeComponent();
            pessoaDAL = new PessoaDAL();
        }

        private void frmHistoricoLocacaoClientes_Load(object sender, EventArgs e)
        {
            dgvLocacoesClientes.DataSource = pessoaDAL.RecuperarHistoricoLocacaoClientes();
        }
    }
}
