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
    public partial class frmCliente : Form
    {
        PessoaDAL pessoaDAL;
        public frmCliente()
        {
            pessoaDAL = new PessoaDAL();
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            TrocarEnable(true);
            var clientes = pessoaDAL.ListarTodosClientes();
            dgvClientes.DataSource = clientes;
            OcultarCamposDaGrid(dgvClientes);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = null;
            try
            {
                pessoa = new Pessoa();
                pessoa.Funcionario = 'N';
                pessoa.Nome = txtNome.Text;
                pessoa.DataNascimento = Convert.ToDateTime(dtpDtNascimento.Text);
                pessoa.Sexo = Convert.ToChar(cmbSexo.Text);
                pessoa.EstadoCivil = cmbEstadoCivil.Text;
                pessoa.RG = txtRG.Text;
                pessoa.CPF = txtCPF.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.CEP = txtCEP.Text;
                pessoa.Estado = cmbEstado.Text;
                pessoa.Telefone = txtTelefone.Text;
                pessoa.Celular = txtCelular.Text;
                pessoa.Email = txtEmail.Text;
                pessoa.SituacaoPagamentos = cmbSituacaoPagamentos.Text;

            }
            catch (Exception)
            {

                throw new Exception("Falha ao preencher os dados");
            }

            try
            {
                pessoaDAL.AdicionarPessoa(pessoa);
                dgvClientes.DataSource = pessoaDAL.ListarTodosClientes();
                OcultarCamposDaGrid(dgvClientes);
                LimparDadosDaTela(string.Empty);
                MessageBox.Show("Registro adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao adicionar o registro. Retorno: {ex.Message}");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var codigoPessoa = Convert.ToInt32(txtCodigoCliente.Text);
            var pessoa = PreencherPessoaDeAcordoComDadosDaTela(codigoPessoa);

            try
            {
                pessoaDAL.AtualizarPessoa(pessoa);
                dgvClientes.DataSource = pessoaDAL.ListarTodosClientes();
                OcultarCamposDaGrid(dgvClientes);
                LimparDadosDaTela(string.Empty);
                TrocarEnable(true);
                ControlarComponentesDaTela(true);
                MessageBox.Show("Registro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao atualizar o registro. Retorno: {ex.Message}");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var codigoPessoa = Convert.ToInt32(txtCodigoCliente.Text);
            try
            {
                pessoaDAL.RemoverPessoa(codigoPessoa);
                dgvClientes.DataSource = pessoaDAL.ListarTodosClientes();
                OcultarCamposDaGrid(dgvClientes);
                TrocarEnable(false);
                LimparDadosDaTela(string.Empty);
                MessageBox.Show("Registro removido com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao remover o registro. Retorno: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparDadosDaTela(string.Empty);
            TrocarEnable(true);
            ControlarComponentesDaTela(true);
        }

        private void LimparDadosDaTela(string limpar)
        {
            txtCodigoCliente.Text = limpar;
            txtNome.Text = limpar;
            dtpDtNascimento.Text = limpar;
            cmbSexo.Text = limpar;
            cmbEstadoCivil.Text = limpar;
            txtRG.Text = limpar;
            txtCPF.Text = limpar;
            txtEndereco.Text = limpar;
            txtCidade.Text = limpar;
            txtCEP.Text = limpar;
            cmbEstado.Text = limpar;
            txtTelefone.Text = limpar;
            txtCelular.Text = limpar;
            txtEmail.Text = limpar;
            cmbSituacaoPagamentos.Text = limpar;
        }
        private void TrocarEnable(bool habilitarEdicao)
        {
            btnAdicionar.Enabled = habilitarEdicao;
            btnRemover.Enabled = !habilitarEdicao;
            btnAtualizar.Enabled = !habilitarEdicao;
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoCliente.Text))
            {
                int.TryParse(txtCodigoCliente.Text, out int codigoCliente);
                var pessoa = pessoaDAL.PesquisarCliente(codigoCliente);
                if (pessoa == null)
                {
                    MessageBox.Show("Registro não encontrado.");
                    LimparDadosDaTela(string.Empty);
                    TrocarEnable(true);
                    ControlarComponentesDaTela(true);
                    return;
                }
                PreencherATela(pessoa);
                ControlarComponentesDaTela(false);
                TrocarEnable(false);
            }
        }

        private void PreencherATela(Pessoa pessoa)
        {
            txtCodigoCliente.Text = pessoa.CodigoPessoa.ToString();
            txtNome.Text = pessoa.Nome;
            dtpDtNascimento.Text = pessoa.DataNascimento.ToString();
            cmbSexo.Text = pessoa.Sexo.ToString();
            cmbEstadoCivil.Text = pessoa.EstadoCivil;
            txtRG.Text = pessoa.RG;
            txtCPF.Text = pessoa.CPF;
            txtEndereco.Text = pessoa.Endereco;
            txtCidade.Text = pessoa.Cidade;
            txtCEP.Text = pessoa.CEP;
            cmbEstado.Text = pessoa.Estado;
            txtTelefone.Text = pessoa.Telefone;
            txtCelular.Text = pessoa.Celular;
            txtEmail.Text = pessoa.Email;
            cmbSituacaoPagamentos.Text = pessoa.SituacaoPagamentos;
        }

        private Pessoa PreencherPessoaDeAcordoComDadosDaTela(int codigoPessoa)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CodigoPessoa = codigoPessoa;
            pessoa.Nome = txtNome.Text;
            pessoa.DataNascimento = Convert.ToDateTime(dtpDtNascimento.Text);
            pessoa.Sexo = Convert.ToChar(cmbSexo.Text);
            pessoa.EstadoCivil = cmbEstadoCivil.Text;
            pessoa.RG = txtRG.Text;
            pessoa.CPF = txtCPF.Text;
            pessoa.Endereco = txtEndereco.Text;
            pessoa.Cidade = txtCidade.Text;
            pessoa.CEP = txtCEP.Text;
            pessoa.Estado = cmbEstado.Text;
            pessoa.Telefone = txtTelefone.Text;
            pessoa.Celular = txtCelular.Text;
            pessoa.Email = txtEmail.Text;
            pessoa.SituacaoPagamentos = cmbSituacaoPagamentos.Text;
            return pessoa;
        }

        private void OcultarCamposDaGrid(DataGridView dgvCliente)
        {
            dgvCliente.Columns["Funcionario"].Visible = false;
            dgvCliente.Columns["DataNascimento"].Visible = false;
            dgvCliente.Columns["Sexo"].Visible = false;
            dgvCliente.Columns["EstadoCivil"].Visible = false;
            dgvCliente.Columns["RG"].Visible = false;
            dgvCliente.Columns["Endereco"].Visible = false;
            dgvCliente.Columns["Cidade"].Visible = false;
            dgvCliente.Columns["CEP"].Visible = false;
            dgvCliente.Columns["Estado"].Visible = false;
            dgvCliente.Columns["Telefone"].Visible = false;
            dgvCliente.Columns["Celular"].Visible = false;
            dgvCliente.Columns["Email"].Visible = false;
        }

        private void ControlarComponentesDaTela(bool enabled)
        {
            txtCodigoCliente.Enabled = enabled;
        }
    }
}
