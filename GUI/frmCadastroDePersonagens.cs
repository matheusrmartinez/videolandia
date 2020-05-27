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
    public partial class frmCadastroDePersonagens : Form
    {
        PersonagemFilmeDAL personagemFilmeDAL;
        public frmCadastroDePersonagens()
        {
            InitializeComponent();
            personagemFilmeDAL = new PersonagemFilmeDAL();
        }
        private void frmCadastroDePersonagens_Load(object sender, EventArgs e)
        {
            TrocarEnabledBotoes2(true);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonagemFilme personagemFilme = new PersonagemFilme();
                personagemFilme.Titulo = cmbFilme.Text;
                personagemFilme.NomeAtor = cmbArtista.Text;
                personagemFilme.NomePersonagem = txtNomePersonagem.Text;
                personagemFilme.CodigoDeBarrasFilme = personagemFilmeDAL.RecuperarCodigoDeBarrasDoFilme(cmbFilme.Text);
                personagemFilme.CodigoArtista = personagemFilmeDAL.RecuperarCodigoArtistaAPartirDoNome(cmbArtista.Text);
                personagemFilmeDAL.AdicionarPersonagem(personagemFilme);
                LimparDadosDaTela();
                MessageBox.Show("Registro adicionado com sucesso!");
                TrocarEnabledBotoes2(false);
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
                PersonagemFilme personagemFilme = new PersonagemFilme();
                personagemFilme.Titulo = cmbFilme.Text;
                personagemFilme.NomeAtor = cmbArtista.Text;
                personagemFilme.NomePersonagem = txtNomePersonagem.Text;
                personagemFilme.CodigoArtista = personagemFilmeDAL.RecuperarCodigoArtistaAPartirDoNome(personagemFilme.NomeAtor);
                personagemFilmeDAL.AtualizarPersonagem(personagemFilme);
                LimparDadosDaTela();
                MessageBox.Show("Registro adicionado com sucesso!");
                TrocarEnabledBotoes2(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao atualizar o registro. Retorno: {ex.Message}");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var nomePersonagem = txtNomePersonagem.Text;
                personagemFilmeDAL.RemoverPersonagem(nomePersonagem);
                TrocarEnabledBotoes2(false);
                LimparDadosDaTela();
                MessageBox.Show("Registro removido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao remover o registro. Retorno: {ex.Message}");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var nomePersonagem = txtNomePersonagem.Text;

            if (string.IsNullOrEmpty(nomePersonagem))
            {
                MessageBox.Show("Informe o nome do personagem.");
                return;
            }
            var personagem = personagemFilmeDAL.RecuperarPersonagemFilme(nomePersonagem, string.Empty);

            if (personagem == null)
            {
                MessageBox.Show("Personagem não encontrado");
                return;
            }

            PreencherATela(personagem);
            TrocarEnabledBotoes(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparDadosDaTela();
            TrocarEnabledBotoes(true);
        }

        private void LimparDadosDaTela()
        {
            cmbFilme.Text = string.Empty;
            cmbArtista.Text = string.Empty;
            txtNomePersonagem.Text = string.Empty;
        }

        private void TrocarEnabledBotoes(bool habilitarEdicao)
        {
            btnAdicionar.Enabled = habilitarEdicao;
            btnRemover.Enabled = !habilitarEdicao;
            btnAtualizar.Enabled = !habilitarEdicao;
        }

        private void TrocarEnabledBotoes2(bool habilitarEdicao)
        {
            btnAdicionar.Enabled = habilitarEdicao;
            btnRemover.Enabled = habilitarEdicao;
            btnAtualizar.Enabled = habilitarEdicao;
        }
        private void PreencherATela(PersonagemFilme personagemFilme)
        {
            cmbFilme.Text = personagemFilme.Titulo;
            cmbArtista.Text = personagemFilme.NomeAtor;
            txtNomePersonagem.Text = personagemFilme.NomePersonagem;
        }

        private void cmbFilme_MouseClick(object sender, MouseEventArgs e)
        {
            LimparDadosDaTela();
            var filmes = personagemFilmeDAL.RecuperarTodosFilmes();
            cmbFilme.DataSource = filmes;
        }

        private void cmbArtista_MouseClick(object sender, MouseEventArgs e)
        {

            var artistas = personagemFilmeDAL.RecuperarTodosArtistas();
            cmbArtista.DataSource = artistas;
            txtNomePersonagem.Text = string.Empty;
        }

        private void txtNomePersonagem_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbArtista_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbArtista_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbArtista.Text) && !string.IsNullOrEmpty(cmbFilme.Text))
            {
                var verificarSeExistePersonagemParaArtistaEFilme = false;
                var codigoArtista = personagemFilmeDAL.RecuperarCodigoArtistaAPartirDoNome(cmbArtista.Text);

                verificarSeExistePersonagemParaArtistaEFilme = personagemFilmeDAL.VerificarSeExistePersonagemParaOFilmeECodigoArtistaInformado(cmbFilme.Text, codigoArtista);

                if (verificarSeExistePersonagemParaArtistaEFilme)
                {
                    var personagem = personagemFilmeDAL.RecuperarPersonagemFilme(string.Empty, cmbArtista.Text);
                    txtNomePersonagem.Text = personagem.NomePersonagem;
                    TrocarEnabledBotoes(false);
                    btnPesquisar.Enabled = true;
                }

                if (string.IsNullOrEmpty(txtNomePersonagem.Text))
                    TrocarEnabledBotoes(true);
            }
        }
    }
}
