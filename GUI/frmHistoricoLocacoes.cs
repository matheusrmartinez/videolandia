using DAL;
using Models;
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
    public partial class frmHistoricoLocacoes : Form
    {
        LocacaoDAL locacaoDAL;
        public frmHistoricoLocacoes()
        {
            InitializeComponent();
            locacaoDAL = new LocacaoDAL();
        }

        private void frmHistoricoLocacoes_Load(object sender, EventArgs e)
        {
            dgvDezLocacoes.DataSource = locacaoDAL.RecuperarRelatorioLocacoes().ToList();
        }

        private void OcultarCamposDaGrid()
        {
            dgvDezLocacoes.Columns["NomeCliente"].Visible = false;
            dgvDezLocacoes.Columns["DataLocação"].Visible = false;
            dgvDezLocacoes.Columns["DataDevoluçãoPrevista"].Visible = false;
            dgvDezLocacoes.Columns["DataDevolução"].Visible = false;
        }
    }
}
