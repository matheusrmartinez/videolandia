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
    public partial class frmCadastroArtista : Form
    {
        ArtistaDAL artistaDAL;

        public frmCadastroArtista()
        {
            InitializeComponent();
            artistaDAL = new ArtistaDAL();
        }
        private void frmCadastroArtista_Load(object sender, EventArgs e)
        {
            ControlarComponentesDaTela(false);
            TrocarEnable(true);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Artista artista = new Artista();
                artista.Nome = string.IsNullOrEmpty(txtNomeAtor.Text) ? txtNomeDiretor.Text : txtNomeAtor.Text;
                artista.DataDeNascimento = dtpDataNascimento.Value;
                artista.Pais = txtPaisNascimento.Text;
                artista.CaminhoFoto = string.Empty;

                artistaDAL.AdicionarArtista(artista);
                LimparDadosDaTela();
                MessageBox.Show("Artista adicionado com sucesso!");
                ControlarComponentesDaTela(false);
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
                Artista artista = new Artista();
                artista.Nome = string.IsNullOrEmpty(txtNomeAtor.Text) ? txtNomeDiretor.Text : txtNomeAtor.Text;
                artista.DataDeNascimento = dtpDataNascimento.Value;
                artista.Pais = txtPaisNascimento.Text;
                artista.CaminhoFoto = string.Empty;

                artistaDAL.AtualizarArtista(artista);
                LimparDadosDaTela();
                MessageBox.Show("Artista atualizado com sucesso!");
                ControlarComponentesDaTela(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao atualizar o registro. Retorno: {ex.Message}");
            }

        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            var codigoArtista = Convert.ToInt32(txtCodigoArtista.Text);
            try
            {
                artistaDAL.RemoverArtista(codigoArtista);
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
        private void btnPesquisarNomeAtor_Click(object sender, EventArgs e)
        {
            var nomeAtor = txtNomeAtor.Text;

            if (string.IsNullOrEmpty(nomeAtor))
                MessageBox.Show("Preencha o nome do ator.");

            var artista = artistaDAL.RecuperarArtistaPeloNome(nomeAtor);
            var filmesArtista = artistaDAL.PesquisarFilmesDoArtistaPeloNome(nomeAtor);

            if (artista == null)
            {
                MessageBox.Show("Registro não encontrado.");
                LimparDadosDaTela();
                TrocarEnable(true);
                ControlarComponentesDaTela(false);
                return;
            }

            PreencherInformacoesDoCabecalho(artista, true);
            PreencherInformacoesDaGridListaDeFilmesDoArtista(filmesArtista);
            ControlarComponentesDaTela(false);
            TrocarEnable(false);

        }
        private void btnPesquisarNomeDiretor_Click(object sender, EventArgs e)
        {
            var nomeDiretor = txtNomeDiretor.Text;

            if (string.IsNullOrEmpty(nomeDiretor))
                MessageBox.Show("Preencha o nome do ator.");

            if (!string.IsNullOrEmpty(nomeDiretor))
            {
                var artista = artistaDAL.RecuperarArtistaPeloNome(nomeDiretor);
                var filmesArtista = artistaDAL.PesquisarFilmesDoArtistaPeloNome(nomeDiretor);

                if (artista == null)
                {
                    MessageBox.Show("Registro não encontrado.");
                    LimparDadosDaTela();
                    TrocarEnable(true);
                    ControlarComponentesDaTela(false);
                    return;
                }
                PreencherInformacoesDoCabecalho(artista, false);
                PreencherInformacoesDaGridListaDeFilmesDoArtista(filmesArtista);
                ControlarComponentesDaTela(false);
                TrocarEnable(false);
            }

        }
        private void LimparDadosDaTela()
        {
            txtCodigoArtista.Text = string.Empty;
            txtNomeAtor.Text = string.Empty;
            txtNomeDiretor.Text = string.Empty;
            dtpDataNascimento.Value = DateTimePicker.MinimumDateTime;
            txtPaisNascimento.Text = string.Empty;
        }
        private void TrocarEnable(bool habilitarEdicao)
        {
            btnAdicionar.Enabled = habilitarEdicao;
            btnRemover.Enabled = !habilitarEdicao;
            btnAtualizar.Enabled = !habilitarEdicao;
        }
        private void ControlarComponentesDaTela(bool enabled)
        {
            txtCodigoArtista.Enabled = enabled;
            
        }
        private void PreencherInformacoesDoCabecalho(Artista artista, bool nomeAtorPreenchido)
        {
            txtCodigoArtista.Text = artista.CodigoArtista.ToString();

            if (nomeAtorPreenchido)
                txtNomeAtor.Text = artista.Nome;

            else
                txtNomeDiretor.Text = artista.Nome;

            dtpDataNascimento.Value = artista.DataDeNascimento;
            txtPaisNascimento.Text = artista.Pais;
        }
        private void PreencherInformacoesDaGridListaDeFilmesDoArtista(List<FilmeArtista> filmesArtista)
        {
            dgvFilmesArtista.DataSource = filmesArtista;
            ControlarColunasDaGridView();
        }
        private void txtNomeAtor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeAtor.Text))
                txtNomeDiretor.Enabled = false;

            else
                txtNomeDiretor.Enabled = true;
        }
        private void txtNomeDiretor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeDiretor.Text))
                txtNomeAtor.Enabled = false;

            else
                txtNomeAtor.Enabled = true;
        }

        private void ControlarColunasDaGridView()
        {
            dgvFilmesArtista.Columns["NomeFilme"].Visible = false;
            dgvFilmesArtista.Columns["CodigoArtista"].Visible = false;
        }
    }
}
