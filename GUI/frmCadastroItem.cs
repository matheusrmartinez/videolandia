using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroItem : Form
    {
        ItemDAL itemDAL;
        public frmCadastroItem()
        {
            InitializeComponent();
            itemDAL = new ItemDAL();
        }

        private void frmcadastroitem_Load(object sender, EventArgs e)
        {
            var existeRegistroNaTabelaSituacao = itemDAL.VerificarSeExisteRegistroPadraoNaTabelaSituacao();

            if (!existeRegistroNaTabelaSituacao)
                itemDAL.InserirSituacaoPadraoNaTabelaSituacao(null);

            dgvItens.DataSource = itemDAL.ListarTodosOsFilmesCadastrados();
            OcultarCamposGridViewItens();
            TrocarEnableCamposDaTela(false);
            TrocarEnableBotoes(true);
            //btnAdicionarFoto.Enabled = false;
        }
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                item.CodigoDeBarras = txtCodigoDeBarras.Text;
                item.Titulo = txtTitulo.Text;
                item.Ano = Convert.ToInt32(txtAno.Text);
                item.Tipo = txtTipo.Text;
                item.Preco = Convert.ToDecimal(txtPreco.Text);
                item.DataAdquirida = dtpDataAdquirida.Value;
                item.Custo = Convert.ToDecimal(txtCusto.Text);
                item.CodigoSituacaoFilme = 1;
                itemDAL.AdicionarItem(item);
                dgvItens.DataSource = itemDAL.ListarTodosOsFilmesCadastrados();
                LimparDadosDaTela();
                MessageBox.Show("Registro adicionado com sucesso!");
                TrocarEnableBotoes(true);
                TrocarEnableCamposDaTela(false);
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
                Item item = new Item();
                item.CodigoItem = Convert.ToInt32(txtCodigoItem.Text);
                item.CodigoDeBarras = txtCodigoDeBarras.Text;
                item.Titulo = txtTitulo.Text;
                item.Ano = Convert.ToInt32(txtAno.Text);
                item.Tipo = txtTipo.Text;
                item.Preco = Convert.ToDecimal(txtPreco.Text);
                item.DataAdquirida = dtpDataAdquirida.Value;
                item.Custo = Convert.ToDecimal(txtCusto.Text);
                item.CodigoSituacaoFilme = 1;
                itemDAL.AtualizarItem(item);
                dgvItens.DataSource = itemDAL.ListarTodosOsFilmesCadastrados();
                LimparDadosDaTela();
                MessageBox.Show("Registro atualizado com sucesso!");
                TrocarEnableBotoes(true);
                TrocarEnableCamposDaTela(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao adicionar o registro. Retorno: {ex.Message}");
            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            var codigoDeBarras = Convert.ToInt32(txtCodigoDeBarras.Text);
            try
            {
                itemDAL.RemoverItem(codigoDeBarras);
                dgvItens.DataSource = itemDAL.ListarTodosOsFilmesCadastrados();
                LimparDadosDaTela();
                MessageBox.Show("Registro removido com sucesso!");
                TrocarEnableBotoes(true);
                TrocarEnableCamposDaTela(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao remover o registro. Retorno: {ex.Message}");
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimparDadosDaTela();
            TrocarEnableBotoes(true);
        }
        private void btnPesquisarCodigoDeBarras_Click_1(object sender, EventArgs e)
        {
            try
            {
                var codigoDeBarras = txtCodigoDeBarras.Text;
                var titulo = txtTitulo.Text;
                var codigoSituacao = -1;

                if (string.IsNullOrEmpty(codigoDeBarras))
                {
                    MessageBox.Show("Insira o código de barras do filme.");
                    return;
                }

                var filme = itemDAL.RecuperarFilmePeloCodigoDeBarrasOuPeloTitulo(codigoDeBarras, titulo);

                if (filme == null)
                {
                    MessageBox.Show("Filme não localizado.");
                    return;
                }

                var generosFilme = itemDAL.RecuperarGenerosDoFilme(codigoDeBarras, titulo);
                PreencherTela(filme);
                PreencherComboBox(generosFilme);
                codigoSituacao = itemDAL.RecuperarSituacaoDoItemPeloTituloOuCodigoDeBarras(codigoDeBarras, string.Empty);
                txtSituacao.Text = codigoSituacao != 1 ? "LOCADO" : "DISPONÍVEL";

                dgvAtoresParticipantes.DataSource = itemDAL.ListarPersonagensDoFilmeDadoUmTituloOuCodigoDeBarras(codigoDeBarras, titulo);
                OcultarCamposGridViewArtistas();

                TrocarEnableBotoes(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao localizar o registro. Retorno: {ex.Message}");
            }
        }

        private void btnPesquisarTitulo_Click_1(object sender, EventArgs e)
        {
            try
            {
                var codigoDeBarras = txtCodigoDeBarras.Text;
                var titulo = txtTitulo.Text;

                if (string.IsNullOrEmpty(titulo))
                {
                    MessageBox.Show("Insira o título do filme.");
                    return;
                }

                var filme = itemDAL.RecuperarFilmePeloCodigoDeBarrasOuPeloTitulo(codigoDeBarras, titulo);

                if (filme == null)
                {
                    MessageBox.Show("Filme não localizado.");
                    return;
                }

                var generosFilme = itemDAL.RecuperarGenerosDoFilme(codigoDeBarras, titulo);
                PreencherTela(filme);
                PreencherComboBox(generosFilme);
                TrocarEnableBotoes(false);
                dgvAtoresParticipantes.DataSource = itemDAL.ListarPersonagensDoFilmeDadoUmTituloOuCodigoDeBarras(codigoDeBarras, titulo);
                OcultarCamposGridViewArtistas();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao localizar o registro.");
            }
        }

        private void PreencherComboBox(List<string> generosFilme)
        {
            if (generosFilme.Count > 0)
                cmbGenero1.Text = generosFilme[0];
            else return;
            if (generosFilme.Count > 1)
                cmbGenero2.Text = generosFilme[1];
            else return;
            if (generosFilme.Count > 2)
                cmbGenero3.Text = generosFilme[2];
            else return;
            if (generosFilme.Count > 3)
                cmbGenero4.Text = generosFilme[3];
            else return;
            if (generosFilme.Count > 4)
                cmbGenero5.Text = generosFilme[4];
            else return;
            if (generosFilme.Count > 5)
                cmbGenero6.Text = generosFilme[5];
            else return;
            if (generosFilme.Count > 6)
                cmbGenero7.Text = generosFilme[6];
            else return;
            if (generosFilme.Count > 7)
                cmbGenero8.Text = generosFilme[7];
            else return;
        }
        private void TrocarEnableBotoes(bool habilitarEdicao)
        {
            btnAdicionar.Enabled = habilitarEdicao;
            btnRemover.Enabled = !habilitarEdicao;
            btnAtualizar.Enabled = !habilitarEdicao;
        }

        private void TrocarEnableCamposDaTela(bool habilitarEdicao)
        {
            txtCodigoItem.Enabled = habilitarEdicao;
            txtSituacao.Enabled = habilitarEdicao;
            cmbGenero1.Enabled = habilitarEdicao;
            cmbGenero2.Enabled = habilitarEdicao;
            cmbGenero3.Enabled = habilitarEdicao;
            cmbGenero4.Enabled = habilitarEdicao;
            cmbGenero5.Enabled = habilitarEdicao;
            cmbGenero6.Enabled = habilitarEdicao;
            cmbGenero7.Enabled = habilitarEdicao;
            cmbGenero8.Enabled = habilitarEdicao;
        }

        private void LimparDadosDaTela()
        {
            txtCodigoItem.Text = string.Empty;
            txtCodigoDeBarras.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtAno.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtPreco.Text = string.Empty;
            dtpDataAdquirida.Text = string.Empty;
            txtCusto.Text = string.Empty;
            txtSituacao.Text = string.Empty;
            cmbGenero1.Text = string.Empty;
            cmbGenero2.Text = string.Empty;
            cmbGenero3.Text = string.Empty;
            cmbGenero4.Text = string.Empty;
            cmbGenero5.Text = string.Empty;
            cmbGenero6.Text = string.Empty;
            cmbGenero7.Text = string.Empty;
            cmbGenero8.Text = string.Empty;
        }

        private void PreencherTela(Item item)
        {
            txtCodigoItem.Text = item.CodigoItem.ToString();
            txtCodigoDeBarras.Text = item.CodigoDeBarras;
            txtTitulo.Text = item.Titulo;
            txtAno.Text = item.Ano.ToString();
            txtTipo.Text = item.Tipo;
            txtPreco.Text = item.Preco.ToString();
            dtpDataAdquirida.Value = item.DataAdquirida;
            txtCusto.Text = item.Custo.ToString();
            txtSituacao.Text = item.CodigoSituacaoFilme.ToString();
        }

        private void OcultarCamposGridViewItens()
        {
            dgvItens.Columns["Preco"].Visible = false;
            dgvItens.Columns["Custo"].Visible = false;
            dgvItens.Columns["CodigoItem"].Visible = false;
            dgvItens.Columns["CodigoSituacaoFilme"].Visible = false;
            dgvItens.Columns["GeneroFilme"].Visible = false;
            dgvItens.Columns["Tipo"].Visible = false;
            dgvItens.Columns["DataAdquirida"].Visible = false;
        }
        private void OcultarCamposGridViewArtistas()
        {
            dgvAtoresParticipantes.Columns["NomeArtista"].Visible = false;
            dgvAtoresParticipantes.Columns["CodigoArtista"].Visible = false;
            dgvAtoresParticipantes.Columns["CodigoDeBarrasFilme"].Visible = false;
            dgvAtoresParticipantes.Columns["Titulo"].Visible = false;
        }

        private void btnFotoFilme_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using(StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(pbFotoFilme.Image);
                }

            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }
    }
}
