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
    public partial class PreencherComboBoxNaTela : Form
    {
        GeneroFilmeDAL generoFilmeDAL;
        public PreencherComboBoxNaTela()
        {
            InitializeComponent();
            generoFilmeDAL = new GeneroFilmeDAL();
        }
        private void frmCadastroGenerosFilme_Load(object sender, EventArgs e)
        {
            TrocarEnable(true);
            ControlarComponentesDaTela(false);
            ControlarComboBoxDaTela(false);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var generoFilme = new GeneroFilme();
                var nomesGeneros = RecuperarNomesDosGenerosDaTela().ToList();
                generoFilme.Titulo = cmbFilme.Text;
                generoFilme.CodigoItem = Convert.ToInt32(txtCodigoFilme.Text);
                generoFilme.CodigoDeBarras = txtCodigoDeBarras.Text;
                generoFilme.NomeGenero = nomesGeneros;
                generoFilme.CodigoGenero = RecuperarCodigosDosGenerosAPartirDosNomesDosGeneros(nomesGeneros).ToList();
                generoFilmeDAL.AdicionarGenerosFilme(generoFilme);
                LimparDadosDaTela();
                MessageBox.Show("Registro adicionado com sucesso!");
                ControlarComponentesDaTela(false);
                ControlarComboBoxDaTela(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao adicionar o registro. Retorno: {ex.Message}");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var generoFilme = new GeneroFilme();
                var nomesGeneros = RecuperarNomesDosGenerosDaTela().ToList();
                generoFilme.Titulo = cmbFilme.Text;
                generoFilme.CodigoItem = Convert.ToInt32(txtCodigoFilme.Text);
                generoFilme.CodigoDeBarras = txtCodigoDeBarras.Text;
                generoFilme.CodigoGenero = RecuperarCodigosDosGenerosAPartirDosNomesDosGeneros(nomesGeneros).ToList();
                generoFilme.NomeGenero = nomesGeneros;
                generoFilmeDAL.RemoverGeneroFilme(txtCodigoDeBarras.Text);
                generoFilmeDAL.AdicionarGenerosFilme(generoFilme);

                LimparDadosDaTela();
                TrocarEnable(true);
                ControlarComponentesDaTela(false);
                ControlarComboBoxDaTela(false);
                MessageBox.Show("Registro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao atualizar o registro. Retorno: {ex.Message}");
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var codigoDeBarras = txtCodigoDeBarras.Text;
            try
            {
                generoFilmeDAL.RemoverGeneroFilme(codigoDeBarras);
                TrocarEnable(false);
                LimparDadosDaTela();
                ControlarComponentesDaTela(false);
                ControlarComboBoxDaTela(false);
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
            TrocarEnable(false);
            ControlarComponentesDaTela(false);
            ControlarComboBoxDaTela(false);
        }

        private void cmbGenero1_MouseClick(object sender, MouseEventArgs e)
        {
            var generoFilme = generoFilmeDAL.RecuperarTodosGeneros();
            cmbGenero1.DataSource = generoFilme;
        }

        private void cmbGenero2_MouseClick(object sender, MouseEventArgs e)
        {
            var generoFilme = generoFilmeDAL.RecuperarTodosGeneros();
            cmbGenero2.DataSource = generoFilme;
        }

        private void cmbGenero3_MouseClick(object sender, MouseEventArgs e)
        {
            var generoFilme = generoFilmeDAL.RecuperarTodosGeneros();
            cmbGenero3.DataSource = generoFilme;
        }

        private void cmbGenero4_MouseClick(object sender, MouseEventArgs e)
        {
            var generoFilme = generoFilmeDAL.RecuperarTodosGeneros();
            cmbGenero4.DataSource = generoFilme;
        }

        private void cmbGenero5_MouseClick(object sender, MouseEventArgs e)
        {
            var generoFilme = generoFilmeDAL.RecuperarTodosGeneros();
            cmbGenero5.DataSource = generoFilme;

        }

        private void cmbGenero6_MouseClick(object sender, MouseEventArgs e)
        {
            var generoFilme = generoFilmeDAL.RecuperarTodosGeneros();
            cmbGenero6.DataSource = generoFilme;
        }

        private void cmbGenero7_MouseClick(object sender, MouseEventArgs e)
        {
            var generoFilme = generoFilmeDAL.RecuperarTodosGeneros();
            cmbGenero7.DataSource = generoFilme;
        }

        private void cmbGenero8_MouseClick(object sender, MouseEventArgs e)
        {
            var generoFilme = generoFilmeDAL.RecuperarTodosGeneros();
            cmbGenero8.DataSource = generoFilme;
        }

        private void cmbFilme_MouseClick(object sender, MouseEventArgs e)
        {
            LimparDadosDaTela();
            var filmes = generoFilmeDAL.ListarTodosOsFilmes();
            cmbFilme.DataSource = filmes;
        }
        private void TrocarEnable(bool habilitarEdicao)
        {
            btnAdicionar.Enabled = habilitarEdicao;
            btnRemover.Enabled = !habilitarEdicao;
            btnAtualizar.Enabled = !habilitarEdicao;
            btnPesquisar.Enabled = !habilitarEdicao;
        }
        private void ControlarComponentesDaTela(bool enabled)
        {
            txtCodigoFilme.Enabled = enabled;
            txtCodigoDeBarras.Enabled = enabled;
        }

        private IEnumerable<string> RecuperarNomesDosGenerosDaTela()
        {
            var nomesGeneros = new List<string>();

            nomesGeneros.Add(cmbGenero1.Text);
            nomesGeneros.Add(cmbGenero2.Text);
            nomesGeneros.Add(cmbGenero3.Text);
            nomesGeneros.Add(cmbGenero4.Text);
            nomesGeneros.Add(cmbGenero5.Text);
            nomesGeneros.Add(cmbGenero6.Text);
            nomesGeneros.Add(cmbGenero7.Text);
            nomesGeneros.Add(cmbGenero8.Text);

            return nomesGeneros;
        }

        private IEnumerable<int> RecuperarCodigosDosGenerosAPartirDosNomesDosGeneros(IEnumerable<string> nomesGeneros)
        {
            var codigosGeneros = new List<int>();
            codigosGeneros = generoFilmeDAL.RecuperarCodigosGenerosAPartirDosNomesDosGeneros(nomesGeneros.ToList()).ToList();

            return codigosGeneros;
        }

        private void LimparDadosDaTela()
        {
            txtCodigoFilme.Text = string.Empty;
            cmbFilme.Text = string.Empty;
            cmbGenero1.Text = string.Empty;
            cmbGenero2.Text = string.Empty;
            cmbGenero3.Text = string.Empty;
            cmbGenero4.Text = string.Empty;
            cmbGenero5.Text = string.Empty;
            cmbGenero6.Text = string.Empty;
            cmbGenero7.Text = string.Empty;
            cmbGenero8.Text = string.Empty;
        }

        private void ControlarComboBoxDaTela(bool enabled)
        {
            cmbGenero1.Enabled = enabled;
            cmbGenero2.Enabled = enabled;
            cmbGenero3.Enabled = enabled;
            cmbGenero4.Enabled = enabled;
            cmbGenero5.Enabled = enabled;
            cmbGenero6.Enabled = enabled;
            cmbGenero7.Enabled = enabled;
            cmbGenero8.Enabled = enabled;
        }

        private void cmbFilme_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbFilme.Text))
            {
                var codigoFilme = generoFilmeDAL.RecuperarCodigoItemPeloTitulo(cmbFilme.Text);
                var codigoDeBarras = generoFilmeDAL.RecuperarCodigoDeBarrasPeloTitulo(cmbFilme.Text);
                txtCodigoFilme.Text = codigoFilme.ToString();
                txtCodigoDeBarras.Text = codigoDeBarras;

                var itemSelecionadoJaPossuiAlgumGeneroCadastrado = generoFilmeDAL.VerificarSeTituloJaPossuiGeneroCadastrado(codigoDeBarras);

                if (itemSelecionadoJaPossuiAlgumGeneroCadastrado)
                {
                    ControlarComboBoxDaTela(true);
                    TrocarEnable(false);
                }

                else
                {
                    ControlarComboBoxDaTela(true);
                    TrocarEnable(true);
                    LimparDadosDaTela();
                    txtCodigoFilme.Text = codigoFilme.ToString();
                }
            }

            else
            {
                ControlarComboBoxDaTela(false);
                txtCodigoFilme.Text = string.Empty;
            }
        }

        private void PreencherComboBoxGenerosNaTela(IEnumerable<string> generosTitulo)
        {
            var generos = generosTitulo.ToList();

            if (generos.Count > 0)
                cmbGenero1.Text = generos[0];
            else return;
            if (generos.Count > 1)
                cmbGenero2.Text = generos[1];
            else return;
            if (generos.Count > 2)
                cmbGenero3.Text = generos[2];
            else return;
            if (generos.Count > 3)
                cmbGenero4.Text = generos[3];
            else return;
            if (generos.Count > 4)
                cmbGenero5.Text = generos[4];
            else return;
            if (generos.Count > 5)
                cmbGenero6.Text = generos[5];
            else return;
            if (generos.Count > 6)
                cmbGenero7.Text = generos[6];
            else return;
            if (generos.Count > 7)
                cmbGenero8.Text = generos[7];
            else return;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var generosDoTitulo = generoFilmeDAL.RecuperarTodosGenerosDoTitulo(txtCodigoDeBarras.Text);
            PreencherComboBoxGenerosNaTela(generosDoTitulo);
        }
    }
}
