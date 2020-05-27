using DAL;
using Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroDevolucao : Form
    {
        DevolucaoDAL devolucaoDAL;
        ItemDevolucaoDAL itemDevolucaoDAL;
        LocacaoDAL locacaoDAL;
        ItemDAL itemDAL;
        PessoaDAL pessoaDAL;

        public frmCadastroDevolucao()
        {
            InitializeComponent();
            devolucaoDAL = new DevolucaoDAL();
            itemDevolucaoDAL = new ItemDevolucaoDAL();
            locacaoDAL = new LocacaoDAL();
            itemDAL = new ItemDAL();
            pessoaDAL = new PessoaDAL();
        }

        private void frmCadastroDevolucao_Load(object sender, EventArgs e)
        {
            ControlarComponentesDaTela(false);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoDeBarras.Text))
            {
                MessageBox.Show("Informe um item.");
                return;
            }

            var locacao = locacaoDAL.RecuperarLocacaoPeloCodigoDeBarras(txtCodigoDeBarras.Text);

            if (locacao == null)
            {
                MessageBox.Show("Locação não localizada para o item.");
                return;
            }

            txtTitulo.Text = locacao.ItensLocacao.Where(x => x.CodigoDeBarras == txtCodigoDeBarras.Text).Select(x => x.Titulo).FirstOrDefault().ToString();
            dtpDataPrevista.Value = locacao.DataPrevista;
            dtpDataEntrega.Value = DateTime.Now;
            txtPreco.Text = locacao.ItensLocacao.Where(x => x.CodigoDeBarras == txtCodigoDeBarras.Text).Select(x => x.Valor).FirstOrDefault().ToString();

            var somaDoValorPagoDaLocacaoNaTabelaDevolucao = devolucaoDAL.RecuperarSomaDosItensDaLocacao(locacao.CodigoLocacao);
            var somaDeTodosValoresJaPagosPelaLocacao = somaDoValorPagoDaLocacaoNaTabelaDevolucao + locacao.ValorPago;

            txtValorPago.Text = somaDeTodosValoresJaPagosPelaLocacao.ToString();
            var diferencaDatas = dtpDataEntrega.Value - dtpDataPrevista.Value;
            var diferencaDias = diferencaDatas.Days > 0 ? diferencaDatas.Days : 0;
            var jurosEMulta = CalcularJurosEMultaDaLocacao(diferencaDias, locacao);
            var valorTotalComMultaEJuros = locacao.ValorTotal + jurosEMulta;
            var valorRestanteAPagar = (valorTotalComMultaEJuros - somaDeTodosValoresJaPagosPelaLocacao) + jurosEMulta;
            txtJurosEMulta.Text = jurosEMulta.ToString();
            txtValorTotal.Text = valorTotalComMultaEJuros.ToString();
            txtFaltaPagar.Text = valorRestanteAPagar.ToString();

            ControlarComponentesDaTela(false);
        }
        private void ControlarComponentesDaTela(bool habilitarEdicao)
        {
            txtTitulo.Enabled = habilitarEdicao;
            dtpDataEntrega.Enabled = habilitarEdicao;
            dtpDataPrevista.Enabled = habilitarEdicao;
            txtPreco.Enabled = habilitarEdicao;
            txtValorTotal.Enabled = habilitarEdicao;
            txtValorPago.Enabled = habilitarEdicao;
            txtTitulo.Enabled = habilitarEdicao;
            txtJurosEMulta.Enabled = habilitarEdicao;
            txtTitulo.Enabled = habilitarEdicao;
            txtFaltaPagar.Enabled = habilitarEdicao;
            txtCodigoDevolucao.Enabled = habilitarEdicao;
            txtNovoValor.Enabled = !habilitarEdicao;
        }

        private void btnRegistrarLocacao_Click(object sender, EventArgs e)
        {

            try
            {
                var locacao = locacaoDAL.RecuperarLocacaoPeloCodigoDeBarras(txtCodigoDeBarras.Text);
                Devolucao devolucao = new Devolucao();
                decimal.TryParse(txtNovoValor.Text, out decimal novoValorPago);
                decimal.TryParse(txtFaltaPagar.Text, out decimal faltaPagar);

                if (novoValorPago > faltaPagar)
                {
                    MessageBox.Show("Não é possível pagar um valor maior do que o saldo restante.");
                    return;
                }

                if (novoValorPago < locacao.ItensLocacao.Where(x => x.CodigoDeBarras == txtCodigoDeBarras.Text).Select(x => x.Valor).FirstOrDefault())
                {
                    MessageBox.Show("Não é possível pagar um valor menor do que o preco do item");
                    return;
                }

                if (novoValorPago <= 0)
                {
                    MessageBox.Show("Não é possível registrar um item de devolução sem pagamento");
                    return;
                }

                var somaDoValorPagoDaLocacaoNaTabelaDevolucao = devolucaoDAL.RecuperarSomaDosItensDaLocacao(locacao.CodigoLocacao);

                devolucao.Locacao = locacao;
                devolucao.ValorTotal = locacao.ValorTotal;
                devolucao.ValorPago = somaDoValorPagoDaLocacaoNaTabelaDevolucao + novoValorPago;
                devolucao.ValorAPagar = devolucao.ValorTotal;
                devolucao.DataEntrega = DateTime.Now;
                decimal.TryParse(txtJurosEMulta.Text, out decimal jurosEMulta);

                itemDAL.AtualizarSituacaoItem(1, txtCodigoDeBarras.Text);

                if (string.IsNullOrEmpty(txtCodigoDevolucao.Text))
                    devolucaoDAL.AdicionarDevolucao(devolucao);

                var codigoDevolucao = devolucaoDAL.RecuperarUltimoCodigoDevolucao();

                txtCodigoDevolucao.Text = codigoDevolucao.ToString();

                ItemDevolucao itemDevolucao = new ItemDevolucao();
                itemDevolucao.CodigoDevolucao = codigoDevolucao;
                itemDevolucao.CodigoDeBarras = txtCodigoDeBarras.Text;
                itemDevolucao.Titulo = txtTitulo.Text;
                decimal.TryParse(txtPreco.Text, out decimal preco);
                itemDevolucao.Preco = preco;
                itemDevolucaoDAL.AdicionarDevolucao(itemDevolucao);
                MessageBox.Show("Item de devolução adicionado com sucesso.");

                txtValorPago.Text = devolucao.ValorPago.ToString();

                var valorRestanteAPagar = devolucao.ValorTotal - devolucao.ValorPago;
                txtJurosEMulta.Text = jurosEMulta.ToString();
                txtValorTotal.Text = devolucao.ValorTotal.ToString();
                txtFaltaPagar.Text = valorRestanteAPagar.ToString();

                devolucaoDAL.AtualizarDevolucao(devolucao, codigoDevolucao);

                LimparCamposParciaisDaTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao cadastrar a devolução. Retorno: {ex.Message}");
            }
        }

        private void btnFecharDevolucao_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtFaltaPagar.Text, out decimal valorAPagar);
            var codigoLocacao = locacaoDAL.RecuperarCodigoDaUltimaLocacaoAdicionada();
            var codigoCliente = locacaoDAL.RecuperarCodigoDoClientePelaLocacao(codigoLocacao);

            if (valorAPagar > 0)
            {
                MessageBox.Show("Não é possível fechar a devolução sem antes pagar o valor total");
                return;
            }

            else
                pessoaDAL.AtualizarSituacaoDoCliente(codigoCliente, false);

            MessageBox.Show("Devolução fechada com sucesso.");
            LimparTodosCamposDaTela();
        }

        private decimal CalcularJurosEMultaDaLocacao(int diferencaDeDias, Locacao locacao)
        {
            decimal valorJurosEMulta = 1.0m,
                    multaCalculcada = 0.0m;

            return multaCalculcada = (diferencaDeDias * locacao.ItensLocacao.Count) * valorJurosEMulta;
        }

        private void LimparCamposParciaisDaTela()
        {
            txtCodigoDeBarras.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtNovoValor.Text = string.Empty;
        }

        private void LimparTodosCamposDaTela()
        {
            txtCodigoDevolucao.Text = string.Empty;
            txtCodigoDeBarras.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtNovoValor.Text = string.Empty;
            txtValorPago.Text = string.Empty;
            txtJurosEMulta.Text = string.Empty;
            txtValorTotal.Text = string.Empty;
            txtFaltaPagar.Text = string.Empty;
            txtNovoValor.Text = string.Empty;

        }
    }
}
