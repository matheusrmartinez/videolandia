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
        public void AdicionarGenerosFilme(GeneroFilme generoFilme)
        {
            var queryAdicionarGenero = @"INSERT INTO GenerosFilmes (CodigoGenero, NomeGenero, CodigoItem, Titulo, CodigoDeBarras)
                                         VALUES
                                        (
                                          @CodigoGenero,
                                          @nomeGenero,
                                          @CodigoItem,
                                          @titulo,
                                          @codigoDeBarras  
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
                    for (int i = 0; i < generoFilme.CodigoGenero.Count; i++)
                    {
                        SqlCommand sqlCommand = new SqlCommand(queryAdicionarGenero, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@codigoGenero", generoFilme.CodigoGenero[i]);
                        sqlCommand.Parameters.AddWithValue("@nomeGenero", generoFilme.NomeGenero[i]);
                        sqlCommand.Parameters.AddWithValue("@codigoItem", generoFilme.CodigoItem);
                        sqlCommand.Parameters.AddWithValue("@titulo", generoFilme.Titulo);
                        sqlCommand.Parameters.AddWithValue("@codigoDeBarras", generoFilme.CodigoDeBarras);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

            }
        }

        public void AtualizarGenerosFilme(GeneroFilme generoFilme)
        {
            var queryAtualizarGenero = @" 
                                           UPDATE GenerosFilmes 
                                           SET 
                                              CodigoGenero = @codigoGenero
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
                    for (int i = 0; i < generoFilme.CodigoGenero.Count; i++)
                    {
                        SqlCommand sqlCommand = new SqlCommand(queryAtualizarGenero, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@codigoGenero", generoFilme.CodigoGenero[i]);
                        sqlCommand.Parameters.AddWithValue("@codigoDeBarras", generoFilme.CodigoDeBarras);
                        sqlCommand.ExecuteNonQuery();
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public void RemoverGeneroFilme(string codigoDeBarras)
        {
            var queryRemoverGeneroFilme = "DELETE FROM GenerosFilmes WHERE CodigoDeBarras = @codigoDeBarras";

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
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public IEnumerable<string> ListarTodosOsFilmes()
        {
            List<string> filmes = new List<string>();
            var queryListarTodosClientes = @"SELECT Titulo
                                             FROM Itens
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
                        var titulo = sqlDataReader["Titulo"].ToString();
                        filmes.Add(titulo);
                    }
                }
            }
            return filmes.ToList();
        }

        public int RecuperarCodigoItemPeloTitulo(string titulo)
        {
            var queryRecuperarCodigoItem = "SELECT CodigoItem FROM Itens WHERE titulo LIKE @titulo";
            var codigoTitulo = 0;

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

                SqlCommand sqlCommand = new SqlCommand(queryRecuperarCodigoItem, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@titulo", $"%{titulo}%");

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows && sqlDataReader.Read())
                    codigoTitulo = Convert.ToInt32(sqlDataReader["CodigoItem"].ToString());

                return codigoTitulo;
            }
        }

        public string RecuperarCodigoDeBarrasPeloTitulo(string titulo)
        {
            var queryRecuperarCodigoDeBarras = "SELECT CodigoDeBarras FROM Itens WHERE titulo LIKE @titulo";
            var codigoDeBarras = string.Empty;

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

                SqlCommand sqlCommand = new SqlCommand(queryRecuperarCodigoDeBarras, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@titulo", $"%{titulo}%");

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows && sqlDataReader.Read())
                    codigoDeBarras = sqlDataReader["CodigoDeBarras"].ToString();

                return codigoDeBarras;
            }
        }

        public IEnumerable<string> RecuperarTodosGeneros()
        {
            List<string> generos = new List<string>();
            var queryListarTodosClientes = @"SELECT Nome
                                             FROM Generos
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
                        var GeneroFilme = sqlDataReader["Nome"].ToString();
                        generos.Add(GeneroFilme);
                    }
                }
            }
            return generos.ToList();

        }

        public IEnumerable<int> RecuperarCodigosGenerosAPartirDosNomesDosGeneros(List<string> nomesGeneros)
        {
            var codigosGeneros = new List<int>();
            var queryRecuperarCodigosGeneros = "SELECT CodigoGenero FROM Generos WHERE Nome = @nomesGeneros";

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

                for (int i = 0; i < nomesGeneros.Count; i++)
                {
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarCodigosGeneros, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nomesGeneros", nomesGeneros[i]);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        var codigoGenero = Convert.ToInt32(sqlDataReader["CodigoGenero"].ToString());
                        codigosGeneros.Add(codigoGenero);
                    }
                    sqlDataReader.Close();
                }
            }
            return codigosGeneros.ToList();
        }

        public bool VerificarSeTituloJaPossuiGeneroCadastrado(string codigoDeBarras)
        {
            var queryVerificaSeExisteGeneroItem = "SELECT COUNT(*) FROM GenerosFilmes WHERE CodigoDeBarras = @codigoDeBarras";
            bool existeGeneroParaOTitulo = false;

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

                SqlCommand sqlCommand = new SqlCommand(queryVerificaSeExisteGeneroItem, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                existeGeneroParaOTitulo = Convert.ToBoolean(sqlCommand.ExecuteScalar());
            }

            return existeGeneroParaOTitulo;
        }

        public IEnumerable<string> RecuperarTodosGenerosDoTitulo(string codigoDeBarras)
        {
            List<string> generos = new List<string>();
            var queryListarTodosClientes = @"SELECT NomeGenero
                                             FROM GenerosFilmes
                                             WHERE CodigoDeBarras = @codigoDeBarras
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
                sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        var GeneroFilme = sqlDataReader["NomeGenero"].ToString();
                        generos.Add(GeneroFilme);
                    }
                }
            }
            return generos.ToList();
        }
    }
}
