using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{

    public class DevolucaoDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VideoLandiaDB"].ConnectionString;
        public void AdicionarDevolucao(Devolucao devolucao)
        {

            var queryAdicionarItem = @"INSERT INTO Devolucoes (CodigoLocacao, DataEntrega, ValorAPagar, ValorPago) 
                                         VALUES
                                        (
                                            @codigoLocacao, 
                                            @dataEntrega,
                                            @valorAPagar,
                                            @valorPago
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
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarItem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoLocacao", devolucao.Locacao.CodigoLocacao);
                    sqlCommand.Parameters.AddWithValue("@dataEntrega", devolucao.DataEntrega);
                    sqlCommand.Parameters.AddWithValue("@valorAPagar", devolucao.ValorAPagar);
                    sqlCommand.Parameters.AddWithValue("@valorPago", devolucao.ValorPago);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public int RecuperarUltimoCodigoDevolucao()
        {
            var recuperarCodigoUltimaDevolucao = "SELECT TOP 1 CodigoDevolucao FROM Devolucoes ORDER BY CodigoLocacao DESC";
            var codigoDevolucao = -1;

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
                    SqlCommand sqlCommand = new SqlCommand(recuperarCodigoUltimaDevolucao, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        codigoDevolucao = Convert.ToInt32(sqlDataReader["CodigoDevolucao"].ToString());
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return codigoDevolucao;

            }
        }

        public void AtualizarDevolucao(Devolucao devolucao, int codigoDevolucao)
        {
            var queryAdicionarLocacao = @"UPDATE Devolucoes 
                                            SET 
                                                ValorPago = @valorPago 
                                          WHERE
                                               CodigoDevolucao = @codigoDevolucao";

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
                    sqlCommand.Parameters.AddWithValue("@valorPago", devolucao.ValorPago);
                    sqlCommand.Parameters.AddWithValue("@codigoDevolucao", codigoDevolucao);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public decimal RecuperarSomaDosItensDaLocacao(int codigoLocacao)
        {
            var somaDoValorDosItensDaLocacao = 0.0m;

            var querySomaDosItensDaLocacao = @"SELECT 
                                               COALESCE(SUM(T0.ValorPago), 0) + COALESCE (SUM(T1.ValorPago),0) AS ""ValorTotalPago""
                                               FROM Devolucoes T0
											   INNER JOIN Locacoes T1 ON T0.CodigoLocacao = T1.CodigoLocacao
                                               WHERE T1.CodigoLocacao = @codigoLocacao";

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
                        somaDoValorDosItensDaLocacao = Convert.ToDecimal(sqlDataReader["ValorTotalPago"].ToString());
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return somaDoValorDosItensDaLocacao;
            }
        }

        public IEnumerable<DevolucaoPendente> DevolucoesPendentesPorFuncionario(int codigoFuncionario)
        {
            List<DevolucaoPendente> devolucoesPendentes = new List<DevolucaoPendente>();
            DevolucaoPendente devolucaoPendente;
            var queryDevolucoesPendentes = @"  SELECT 
                                                    T2.Nome,
                                                    T3.Titulo,
                                                    T0.Valor,
                                                    T0.DataPrevista,
                                                    CASE WHEN DAY(T0.DataPrevista) - DAY(GETDATE()) > 0 THEN 0 ELSE DAY(T0.DataPrevista) - DAY(GETDATE()) END AS ""DiasAtrasados""
                                                FROM Locacoes T0
                                                    INNER JOIN Pessoas T2 ON T0.CodigoCliente = T2.CodigoPessoa
                                                    INNER JOIN ItensLocacao T3 ON T0.CodigoLocacao = T3.CodigoLocacao
                                                WHERE T0.CodigoLocacao NOT IN (SELECT CodigoLocacao FROM Devolucoes)
                                                AND T0.CodigoFuncionario = @codigoFuncionario";

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
                    SqlCommand sqlCommand = new SqlCommand(queryDevolucoesPendentes, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoFuncionario", codigoFuncionario);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            devolucaoPendente = new DevolucaoPendente();
                            devolucaoPendente.NomeCliente = sqlDataReader["Nome"].ToString();
                            devolucaoPendente.NomeItem = sqlDataReader["Titulo"].ToString();
                            devolucaoPendente.Preco = Decimal.Parse(sqlDataReader["Valor"].ToString());
                            devolucaoPendente.DataDevolucaoPrevista = Convert.ToDateTime(sqlDataReader["DataPrevista"].ToString());
                            devolucaoPendente.DiasAtrasados = Convert.ToInt32(sqlDataReader["DiasAtrasados"].ToString());
                            devolucoesPendentes.Add(devolucaoPendente);
                        }

                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return devolucoesPendentes;
            }
        }
    }
}

