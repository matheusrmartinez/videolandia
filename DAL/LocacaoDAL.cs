using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class LocacaoDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VideoLandiaDB"].ConnectionString;
        ItemLocacaoDAL itemLocacaoDAL;
        PessoaDAL pessoaDAL;

        public LocacaoDAL()
        {
            itemLocacaoDAL = new ItemLocacaoDAL();
            pessoaDAL = new PessoaDAL();
        }

        public void AdicionarLocacao(Locacao locacao)
        {

            var queryAdicionarLocacao = @"INSERT INTO Locacoes (CodigoFuncionario, CodigoCliente, DataAtual, DataPrevista, Valor, ValorTotal, ValorPago, SituacaoPagamento) 
                                         VALUES
                                        (
                                            @codigoFuncionario,
                                            @codigoCliente,
                                            @dataAtual,
                                            @dataPrevista,
                                            @valor,
                                            @valorTotal,
                                            @valorPago,
                                            @situacaoPagamento
                                        )
                                        ";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {

                    throw new Exception("Falha ao conectar no banco de dados");
                }
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarLocacao, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoFuncionario", locacao.Funcionario.CodigoPessoa);
                    sqlCommand.Parameters.AddWithValue("@codigoCliente", locacao.Cliente.CodigoPessoa);
                    sqlCommand.Parameters.AddWithValue("@dataAtual", locacao.DataAtual);
                    sqlCommand.Parameters.AddWithValue("@dataPrevista", locacao.DataPrevista);
                    sqlCommand.Parameters.AddWithValue("@valor", locacao.Item.Preco);
                    sqlCommand.Parameters.AddWithValue("@valorTotal", locacao.ValorTotal);
                    sqlCommand.Parameters.AddWithValue("@valorPago", locacao.ValorPago);
                    sqlCommand.Parameters.AddWithValue("@situacaoPagamento", locacao.SituacaoPagamento);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public void AtualizarLocacao(Locacao locacao)
        {
            var queryAdicionarLocacao = @"UPDATE Locacoes 
                                            SET 
                                                ValorTotal = @valorTotal, 
                                                ValorPago = @valorPago, 
                                                SituacaoPagamento = @situacaoPagamento 
                                          WHERE
                                               CodigoLocacao = @codigoLocacao";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {

                    throw new Exception("Falha ao conectar no banco de dados");
                }
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarLocacao, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@valorTotal", locacao.ValorTotal);
                    sqlCommand.Parameters.AddWithValue("@valorPago", locacao.ValorPago);
                    sqlCommand.Parameters.AddWithValue("@situacaoPagamento", locacao.SituacaoPagamento);
                    sqlCommand.Parameters.AddWithValue("@codigoLocacao", locacao.CodigoLocacao);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public IEnumerable<string> ListarNomeDeTodosOsFuncionarios()
        {
            var funcionarios = new List<string>();
            var queryListarFuncionarios = "SELECT CodigoPessoa FROM Pessoas WHERE Funcionario = 'Y'";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados.");
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(queryListarFuncionarios, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            var funcionario = sqlDataReader["CodigoPessoa"].ToString();
                            funcionarios.Add(funcionario);
                        }
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return funcionarios;
        }

        public string RecuperarNomeClientePeloCPF(string CPF)
        {
            var nomeCliente = string.Empty;

            var queryRecuperarNomeCliente = "SELECT Nome FROM Pessoas WHERE CPF = @cpf AND Funcionario = 'N'";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados.");
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarNomeCliente, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@cpf", CPF);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        nomeCliente = sqlDataReader["Nome"].ToString();
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return nomeCliente;
        }

        public decimal RecuperarSomaDosItensDaLocacao(int codigoLocacao)
        {
            var somaDoValorDosItensDaLocacao = 0.0m;

            var querySomaDosItensDaLocacao = @"SELECT 
                                               COALESCE(SUM(Preco), 0) AS ""SomaValor""
                                               FROM ItensLocacao
                                               WHERE CodigoLocacao = @codigoLocacao";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados.");
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(querySomaDosItensDaLocacao, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoLocacao", codigoLocacao);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        somaDoValorDosItensDaLocacao = Convert.ToDecimal(sqlDataReader["SomaValor"].ToString());
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return somaDoValorDosItensDaLocacao;
            }
        }

        public decimal RecuperarSomaDeTodosItensDaLocacao(int codigoLocacao)
        {
            var valorTotalDaLocacao = 0.0m;

            var querySomaDosItensDaLocacao = @"SELECT 
                                               SUM(Preco) AS PrecoTotal
                                               FROM ItensLocacao
                                               WHERE CodigoLocacao = @codigoLocacao";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados.");
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(querySomaDosItensDaLocacao, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoLocacao", codigoLocacao);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        valorTotalDaLocacao = Convert.ToDecimal(sqlDataReader["PrecoTotal"].ToString());
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return valorTotalDaLocacao;
            }
        }

        public int RecuperarCodigoDaUltimaLocacaoAdicionada()
        {
            var recuperarCodigoUltimaLocacao = "SELECT TOP 1 CodigoLocacao FROM Locacoes ORDER BY CodigoLocacao DESC";
            var codigoLocacao = -1;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados.");
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(recuperarCodigoUltimaLocacao, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        codigoLocacao = Convert.ToInt32(sqlDataReader["CodigoLocacao"].ToString());
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return codigoLocacao;

            }
        }

        public int RecuperarCodigoDoClientePelaLocacao(int codigoLocacao)
        {
            var queryrecuperarCodigoCliente = "SELECT CodigoCliente FROM Locacoes WHERE CodigoLocacao = @codigoLocacao";
            var codigoCliente = -1;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados.");
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(queryrecuperarCodigoCliente, sqlConnection);
                    sqlCommand.Parameters.Add("@codigoLocacao", codigoLocacao);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        codigoCliente = Convert.ToInt32(sqlDataReader["CodigoCliente"].ToString());
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return codigoCliente;
            }
        }

        public Locacao RecuperarLocacaoPeloCodigoDeBarras(string codigoDeBarras)
        {
            Locacao locacao = null;

            var queryRecuperarLocacao = @"SELECT * 
                                          FROM Locacoes T0
                                            INNER JOIN ItensLocacao T1 ON T0.CodigoLocacao = T1.CodigoLocacao
                                          WHERE T1.CodigoDeBarras = @codigoDeBarras";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados.");
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarLocacao, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        locacao = new Locacao();

                        int.TryParse(sqlDataReader["CodigoLocacao"].ToString(), out int codigoLocacao);
                        DateTime.TryParse(sqlDataReader["DataPrevista"].ToString(), out DateTime dataPrevista);
                        decimal.TryParse(sqlDataReader["Valor"].ToString(), out decimal valor);
                        decimal.TryParse(sqlDataReader["ValorTotal"].ToString(), out decimal valorTotal);
                        decimal.TryParse(sqlDataReader["ValorPago"].ToString(), out decimal valorPago);


                        locacao.CodigoLocacao = codigoLocacao;
                        locacao.DataAtual = DateTime.Now;
                        locacao.DataPrevista = dataPrevista;
                        locacao.Valor = valor;
                        locacao.ValorTotal = valorTotal;
                        locacao.ValorPago = valorPago;
                        locacao.SituacaoPagamento = sqlDataReader["SituacaoPagamento"].ToString();
                        locacao.ItensLocacao = RecuperarLinhasDaLocacao(codigoDeBarras);
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return locacao;
            }
        }

        public List<ItemLocacao> RecuperarLinhasDaLocacao(string codigoDeBarras)
        {
            ItemLocacao itemLocacao = null;
            List<ItemLocacao> itensLocacao = new List<ItemLocacao>();

            var queryRecuperarLinhasLocacao = @"SELECT
                                                        T0.CodigoLocacao,
                                                        T0.CodigoItem,
                                                        T0.CodigoDeBarras,
                                                        T0.Titulo,
                                                        T0.Preco 
                                                    FROM ItensLocacao T0
                                                    INNER JOIN Locacoes T1 ON T0.CodigoLocacao = T1.CodigoLocacao
                                                    WHERE T0.CodigoDeBarras = @codigoDeBarras";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados.");
                }

                try
                {

                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarLinhasLocacao, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            itemLocacao = new ItemLocacao();
                            itemLocacao.CodigoLocacao = Convert.ToInt32(sqlDataReader["CodigoLocacao"].ToString());
                            itemLocacao.CodigoItem = Convert.ToInt32(sqlDataReader["CodigoItem"].ToString());
                            itemLocacao.CodigoDeBarras = sqlDataReader["CodigoDeBarras"].ToString();
                            itemLocacao.Titulo = sqlDataReader["Titulo"].ToString();
                            itemLocacao.Valor = Convert.ToDecimal(sqlDataReader["Preco"].ToString());
                            itensLocacao.Add(itemLocacao);
                        }
                    }
                }

                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return itensLocacao;
            }
        }

        public IEnumerable<RelatorioLocacoes> RecuperarRelatorioLocacoes()
        {
            RelatorioLocacoes locacao = null;
            List<RelatorioLocacoes> locacoes = new List<RelatorioLocacoes>();

            var queryRecuperarLinhasLocacao = @"SELECT TOP 10
                                                    T2.Nome,
                                                    T0.DataAtual,
                                                    T0.DataPrevista,
                                                    T1.DataEntrega,
                                                    T1.ValorPago
                                                FROM Locacoes T0
                                                    INNER JOIN Devolucoes T1 ON T0.CodigoLocacao= T1.CodigoLocacao
                                                    INNER JOIN Pessoas T2 ON T0.CodigoCliente = T0.CodigoCliente
                                                WHERE T2.Funcionario = 'N'";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados.");
                }

                try
                {

                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarLinhasLocacao, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            locacao = new RelatorioLocacoes();
                            locacao.NomeCliente = sqlDataReader["Nome"].ToString();
                            locacao.DataLocacao = Convert.ToDateTime(sqlDataReader["DataAtual"].ToString());
                            locacao.DataDevolucaoPrevista = Convert.ToDateTime(sqlDataReader["DataPrevista"].ToString());
                            locacao.DataDevolucao = Convert.ToDateTime(sqlDataReader["DataEntrega"].ToString());
                            locacao.ValorPago = Convert.ToDecimal(sqlDataReader["ValorPago"].ToString());
                            locacoes.Add(locacao);
                        }
                    }
                }

                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return locacoes;
            }
        }
    }
}
