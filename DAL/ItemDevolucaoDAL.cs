using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemDevolucaoDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VideoLandiaDB"].ConnectionString;

        public void AdicionarDevolucao(ItemDevolucao itemDevolucao)
        {

            var queryAdicionarItem = @"INSERT INTO ItensDevolucao (CodigoDevolucao, CodigoDeBarras, Titulo, Preco) 
                                         VALUES
                                        (
                                            @codigoDevolucao, 
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
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarItem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoDevolucao", itemDevolucao.CodigoDevolucao);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", itemDevolucao.CodigoDeBarras);
                    sqlCommand.Parameters.AddWithValue("@titulo", itemDevolucao.Titulo);
                    sqlCommand.Parameters.AddWithValue("@preco", itemDevolucao.Preco);
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
