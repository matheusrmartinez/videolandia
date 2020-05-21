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
    public partial class frmCadastroGenero : Form
    {
        GeneroFilmeDAL generoFilmeDAL;
        public frmCadastroGenero()
        {
            InitializeComponent();
            generoFilmeDAL = new GeneroFilmeDAL();
        }
        private void frmCadastroGenero_Load(object sender, EventArgs e)
        {
            TrocarEnable(true);
            var generosFilmes = generoFilmeDAL.ListarTodosGeneros();
            ControlarComponentesDaTela(false);
            dgvGenerosFilmes.DataSource = generosFilmes;
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var nomeGenero = txtNomeGenero.Text;

                generoFilmeDAL.AdicionarGenero(nomeGenero);
                dgvGenerosFilmes.DataSource = generoFilmeDAL.ListarTodosGeneros();
                LimparDadosDaTela();
                MessageBox.Show("Registro adicionado com sucesso!");
                ControlarComponentesDaTela(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao adicionar o registro. Retorno: {ex.Message}");
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var codigoGenero = Convert.ToInt32(txtCodigoGenero.Text);
            var generoFilme = PreencherGeneroFilmeDeAcordoComDadosDaTela(codigoGenero);

            try
            {
                generoFilmeDAL.AtualizarGenero(generoFilme);
                dgvGenerosFilmes.DataSource = generoFilmeDAL.ListarTodosGeneros();
                LimparDadosDaTela();
                TrocarEnable(true);
                ControlarComponentesDaTela(false);
                MessageBox.Show("Registro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao atualizar o registro. Retorno: {ex.Message}");
            }

        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            var codigoGenero = Convert.ToInt32(txtCodigoGenero.Text);
            try
            {
                generoFilmeDAL.RemoverGeneroFilme(codigoGenero);
                dgvGenerosFilmes.DataSource = generoFilmeDAL.ListarTodosGeneros();
                TrocarEnable(false);
                LimparDadosDaTela();
                ControlarComponentesDaTela(false);
                MessageBox.Show("Registro removido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao remover o registro. Retorno: {ex.Message}");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparDadosDaTela();
            TrocarEnable(true);
            ControlarComponentesDaTela(false);
        }
        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeGenero.Text))
            {
                var generoFilme = generoFilmeDAL.PesquisarGeneroFilme(txtNomeGenero.Text);

                if (generoFilme == null)
                {
                    MessageBox.Show("Registro não encontrado.");
                    LimparDadosDaTela();
                    TrocarEnable(true);
                    ControlarComponentesDaTela(false);
                    return;
                }

                PreencherATela(generoFilme);
                ControlarComponentesDaTela(false);
                TrocarEnable(false);
            }
        }
        private void LimparDadosDaTela()
        {
            txtCodigoGenero.Text = string.Empty;
            txtNomeGenero.Text = string.Empty;
        }
        private GeneroFilme PreencherGeneroFilmeDeAcordoComDadosDaTela(int codigoGenero)
        {
            GeneroFilme generoFilme = new GeneroFilme();
            generoFilme.CodigoGenero = codigoGenero;
            generoFilme.Nome = txtNomeGenero.Text;

            return generoFilme;
        }
        private void TrocarEnable(bool habilitarEdicao)
        {
            btnAdicionar.Enabled = habilitarEdicao;
            btnRemover.Enabled = !habilitarEdicao;
            btnAtualizar.Enabled = !habilitarEdicao;
        }
        private void ControlarComponentesDaTela(bool enabled)
        {
            txtCodigoGenero.Enabled = enabled;
        }
        private void PreencherATela(GeneroFilme generoFilme)
        {
            txtCodigoGenero.Text = generoFilme.CodigoGenero.ToString();
            txtNomeGenero.Text = generoFilme.Nome;
        }


    }
}
