using DAL;
using Models;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroLocacao : Form
    {
        LocacaoDAL locacaoDAL;
        ItemDAL itemDAL;
        PessoaDAL pessoaDAL;
        ItemLocacaoDAL itemLocacaoDAL;
        public frmCadastroLocacao()
        {
            InitializeComponent();
            locacaoDAL = new LocacaoDAL();
            itemDAL = new ItemDAL();
            pessoaDAL = new PessoaDAL();
            itemLocacaoDAL = new ItemLocacaoDAL();
        }

        private void frmCadastroLocacao_Load(object sender, EventArgs e)
        {
            ControlarComponentesDaTela();
            TrocarEnableBotoes(false);
        }

        private void cmbFuncionario_MouseClick(object sender, MouseEventArgs e)
        {
            cmbFuncionario.DataSource = locacaoDAL.ListarNomeDeTodosOsFuncionarios();
        }

        private void btnCodigoDeBarrasItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoBarras.Text))
            {
                MessageBox.Show("Informe o código de barras.");
                return;
            }

            var item = new Item();
            item = itemDAL.RecuperarFilmePeloCodigoDeBarrasOuPeloTitulo(txtCodigoBarras.Text, string.Empty);

            if (item == null)
            {
                MessageBox.Show("Item não encontrado.");
                return;
            }

            PreencherCamposReferentesAoItem(item);
        }

        private void btnRegistrarLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                Locacao locacao = new Locacao();
                Situacao situacao = new Situacao();
                Funcionario funcionario = new Funcionario();
                ItemLocacao itemLocacao = new ItemLocacao();
                Item item = new Item();


                var codigoFuncionario = Convert.ToInt32(cmbFuncionario.Text);
                int.TryParse(txtCodigoLocacao.Text, out int codigoSituacao);
                var cliente = pessoaDAL.PesquisarClientePeloCPF(txtCPF.Text);

                locacao.Funcionario = pessoaDAL.PesquisarFuncionario(codigoFuncionario);
                locacao.Cliente = pessoaDAL.PesquisarClientePeloCPF(txtCPF.Text);
                locacao.Item = itemDAL.RecuperarFilmePeloCodigoDeBarrasOuPeloTitulo(txtCodigoBarras.Text, string.Empty);
                locacao.DataAtual = dtpDataAtual.Value;
                locacao.DataPrevista = DateTime.Now.AddDays(5);
                locacao.Valor = locacao.Item.Preco;
                locacao.ValorTotal = locacao.Valor + locacaoDAL.RecuperarSomaDosItensDaLocacao(codigoSituacao);
                locacao.SituacaoPagamento = "Devendo";

                if (string.IsNullOrEmpty(txtCodigoLocacao.Text))
                    locacaoDAL.AdicionarLocacao(locacao);

                itemLocacao.CodigoLocacao = locacaoDAL.RecuperarCodigoDaUltimaLocacaoAdicionada();
                itemLocacao.CodigoItem = locacao.Item.CodigoItem;
                itemLocacao.CodigoDeBarras = txtCodigoBarras.Text;
                itemLocacao.Titulo = locacao.Item.Titulo;
                itemLocacao.Valor = locacao.Item.Preco;
                itemLocacaoDAL.AdicionarLocacao(itemLocacao);

                locacaoDAL.AtualizarLocacao(locacao);

                situacao.NomeCliente = cliente.Nome;
                situacao.DataRetirada = DateTime.Now;
                situacao.DataPrevista = DateTime.Now.AddDays(5);
                situacao.Telefone = cliente.Telefone;
                situacao.Celular = cliente.Celular;
                
                itemDAL.InserirNaTabelaSituacao(situacao);
                codigoSituacao = itemDAL.RecuperarCodigoDaUltimaSituacaoInserida();
                itemDAL.AtualizarSituacaoItem(codigoSituacao, txtCodigoBarras.Text);

                txtCodigoLocacao.Text = itemLocacao.CodigoLocacao.ToString();
                btnFecharLocacao.Enabled = true;
                txtValor.Enabled = true;
                LimparParcialmenteCamposDaTela();
                txtValor.Enabled = true;
                txtValorTotal.Text = locacaoDAL.RecuperarSomaDeTodosItensDaLocacao(itemLocacao.CodigoLocacao).ToString();
                MessageBox.Show("Item de locação inserida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao inserir a locacação. Retorno: {ex.Message}");
            }
        }

        private void btnFecharLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                Locacao locacao = new Locacao();
                var cliente = pessoaDAL.PesquisarClientePeloCPF(txtCPF.Text);
                var codigoLocacao = locacaoDAL.RecuperarCodigoDaUltimaLocacaoAdicionada();

                var clienteDevendo = VerificarSeClienteEstaDevendo();

                if (clienteDevendo)
                    pessoaDAL.AtualizarSituacaoDoCliente(cliente.CodigoPessoa, true);

                else
                    pessoaDAL.AtualizarSituacaoDoCliente(cliente.CodigoPessoa, false);

                locacao.SituacaoPagamento = clienteDevendo ? "Devendo" : "Pago";
                decimal.TryParse(txtValorPago.Text, out decimal valorPago);
                locacao.ValorTotal = locacaoDAL.RecuperarSomaDeTodosItensDaLocacao(codigoLocacao);
                locacao.ValorPago = valorPago;
                locacao.CodigoLocacao = codigoLocacao;
                locacaoDAL.AtualizarLocacao(locacao);

                MessageBox.Show("Locação registrada com sucesso");
                LimparTodosCamposDaTela();
                dtpDataPrevista.Value = DateTime.Now.AddDays(5);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao inserir a locação. Retorno: {ex.Message}");
            }
        }

        private void LimparParcialmenteCamposDaTela()
        {
            txtCodigoBarras.Text = string.Empty;
            txtNomeItem.Text = string.Empty;
            dtpDataPrevista.Text = string.Empty;
            txtValorPago.Text = string.Empty;
        }

        private void LimparTodosCamposDaTela()
        {
            txtCodigoLocacao.Text = string.Empty;
            cmbFuncionario.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            dtpDataAtual.Text = string.Empty;
            txtCodigoBarras.Text = string.Empty;
            txtNomeItem.Text = string.Empty;
            txtValor.Text = string.Empty;
            dtpDataPrevista.Text = string.Empty;
            txtValorTotal.Text = string.Empty;
            txtValorPago.Text = string.Empty;
        }
        private void ControlarComponentesDaTela()
        {
            txtCodigoLocacao.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtNomeItem.Enabled = false;
            txtValor.Enabled = false;
            txtValorTotal.Enabled = false;
            dtpDataAtual.Value = DateTime.Now;
            dtpDataPrevista.Value = DateTime.Now.AddDays(5);
        }
        private void TrocarEnableBotoes(bool habilitarEdicao)
        {
            btnRegistrarLocacao.Enabled = habilitarEdicao;
            btnFecharLocacao.Enabled = habilitarEdicao;
        }

        private void btnCPFCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("Informe um CPF.");
                return;
            }

            var nomeCliente = locacaoDAL.RecuperarNomeClientePeloCPF(txtCPF.Text);

            if (string.IsNullOrEmpty(nomeCliente))
            {
                MessageBox.Show("Registro não encontrado");
                return;
            }
            txtNomeCliente.Text = nomeCliente;
        }

        private void PreencherCamposReferentesAoItem(Item item)
        {
            txtNomeItem.Text = item.Titulo;
            txtValor.Text = item.Preco.ToString();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            btnRegistrarLocacao.Enabled = true;
            ItemLocacao itemLocacao = new ItemLocacao();

            if (string.IsNullOrEmpty(txtCodigoLocacao.Text))
                txtValorTotal.Text = txtValor.Text;

            else
            {
                itemLocacao.CodigoLocacao = locacaoDAL.RecuperarCodigoDaUltimaLocacaoAdicionada();
                var somaDeTodosItensVinculadosComLocacao = locacaoDAL.RecuperarSomaDeTodosItensDaLocacao(itemLocacao.CodigoLocacao);
                var somaDeTodosItensVinculadosComLocacaoMaisItemAtual = Convert.ToDecimal(txtValor.Text) + somaDeTodosItensVinculadosComLocacao;
                txtValorTotal.Text = somaDeTodosItensVinculadosComLocacaoMaisItemAtual.ToString();
            }
        }

        private bool VerificarSeClienteEstaDevendo()
        {
            var clienteDevendo = false;
            decimal.TryParse(txtValorPago.Text, out decimal valorPago);
            decimal.TryParse(txtValorTotal.Text, out decimal valorTotal);
            return clienteDevendo = valorPago < valorTotal;
        }
    }
}
