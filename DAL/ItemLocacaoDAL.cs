using Models;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class ItemLocacaoDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VideoLandiaDB"].ConnectionString;

        public void AdicionarLocacao(ItemLocacao itemLocacao)
        {
            var queryAdicionarLocacao = @"INSERT INTO ItensLocacao (CodigoLocacao, CodigoItem, CodigoDeBarras, Titulo, Preco)
                                         VALUES
                                        (
                                            @codigoLocacao, 
                                            @codigoItem,
                                            @codigoDeBarras,
                                            @titulo,
                                            @preco
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
                    sqlCommand.Parameters.AddWithValue("@codigoLocacao", itemLocacao.CodigoLocacao);
                    sqlCommand.Parameters.AddWithValue("@codigoItem", itemLocacao.CodigoItem);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", itemLocacao.CodigoDeBarras);
                    sqlCommand.Parameters.AddWithValue("@titulo", itemLocacao.Titulo);
                    sqlCommand.Parameters.AddWithValue("@preco", itemLocacao.Valor);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

            }

        }
    }
}
