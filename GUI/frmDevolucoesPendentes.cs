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
    public partial class frmDevolucoesPendentes : Form
    {
        DevolucaoDAL devolucaoDAL;
        PessoaDAL pessoaDAL;
        public frmDevolucoesPendentes()
        {
            InitializeComponent();
            devolucaoDAL = new DevolucaoDAL();
            pessoaDAL = new PessoaDAL();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var nomeFuncionario = cmbFuncionario.Text;
            var codigoFuncionario = pessoaDAL.RecuperarCodigoDoFuncionarioPeloNome(nomeFuncionario);
            dgvDevolucoesPendentes.DataSource = devolucaoDAL.DevolucoesPendentesPorFuncionario(codigoFuncionario);
        }

        private void cmbFuncionario_MouseClick(object sender, MouseEventArgs e)
        {
             var funcionarios = pessoaDAL.ListarTodosFuncionarios();
             var nomesFuncionarios_ = funcionarios.Select(x => x.Nome).ToList();
            cmbFuncionario.DataSource = nomesFuncionarios_;

        }


    }
}
