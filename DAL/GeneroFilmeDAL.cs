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
    public class GeneroFilmeDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VideoLandiaDB"].ConnectionString;
        public void AdicionarGenero(string nomeGenero)
        {
            var queryAdicionarGenero = @"INSERT INTO GenerosFilmes (Nome)
                                         VALUES
                                        (
                                          @nome
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
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarGenero, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nome", nomeGenero);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

            }
        }

        public void AtualizarGenero(GeneroFilme GeneroFilme)
        {
            var queryAtualizarGenero = @" 
                                           UPDATE GenerosFilmes 
                                           SET 
                                              Nome = @nome  
                                           WHERE CodigoGenero = @codigoGenero
                                       ";

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
                    SqlCommand sqlCommand = new SqlCommand(queryAtualizarGenero, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nome", GeneroFilme.Nome);
                    sqlCommand.Parameters.AddWithValue("@codigoGenero", GeneroFilme.CodigoGenero);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public void RemoverGeneroFilme(int codigoGeneroFilme)
        {
            var queryRemoverGeneroFilme = "DELETE FROM GenerosFilmes WHERE CodigoGenero = @codigoGeneroFilme";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRemoverGeneroFilme, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoGeneroFilme", codigoGeneroFilme);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public GeneroFilme PesquisarGeneroFilme(string nomeGeneroFilme)
        {
            GeneroFilme GeneroFilme = null;
            var queryPesquisarGenero = $@" SELECT * 
                                           FROM GenerosFilmes
                                           WHERE Nome LIKE @nomeGeneroFilme
                                         ";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (System.Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados!");
                }
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(queryPesquisarGenero, sqlConnection);
                    SqlDataReader sqlDataReader;
                    sqlCommand.Parameters.AddWithValue("@nomeGeneroFilme", $"%{nomeGeneroFilme}%");
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        GeneroFilme = new GeneroFilme();
                        GeneroFilme.CodigoGenero = Convert.ToInt32(sqlDataReader["CodigoGenero"]);
                        GeneroFilme.Nome = sqlDataReader["Nome"].ToString();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return GeneroFilme;
        }

        public List<GeneroFilme> ListarTodosGeneros()
        {
            GeneroFilme generoFilme = null;
            List<GeneroFilme> generosFilme = new List<GeneroFilme>();
            var queryListarTodosClientes = @"SELECT *
                                             FROM GenerosFilmes
                                            ";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao conectar no banco de dados. Retorno: {e.Message}");
                }

                SqlCommand sqlCommand = new SqlCommand(queryListarTodosClientes, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        generoFilme = new GeneroFilme();
                        generoFilme.CodigoGenero = Convert.ToInt32(sqlDataReader["CodigoGenero"].ToString());
                        generoFilme.Nome = sqlDataReader["Nome"].ToString();
                        generosFilme.Add(generoFilme);
                    }
                }

                return generosFilme;
            }
        }
    }
}
