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
    public class ArtistaDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VideoLandiaDB"].ConnectionString;
        public void AdicionarArtista(Artista artista)
        {
            var queryAdicionarArtista = @"INSERT INTO Artistas (Nome, DataNascimento, Pais, CaminhoFoto)
                                         VALUES
                                        (
                                          @nome,
                                          @dataNascimento,
                                          @pais,
                                          @caminhoFoto
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
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarArtista, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nome", artista.Nome);
                    sqlCommand.Parameters.AddWithValue("@dataNascimento", artista.DataDeNascimento);
                    sqlCommand.Parameters.AddWithValue("@pais", artista.Pais);
                    sqlCommand.Parameters.AddWithValue("@caminhoFoto", artista.CaminhoFoto);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

            }
        }

        public void AtualizarArtista(Artista artista)
        {
            var queryAtualizarArtista = @" 
                                           UPDATE Artistas 
                                           SET 
                                               Nome = @nome,
                                               DataNascimento = @dataNascimento,
                                               Pais = @pais,
                                               CaminhoFoto = @caminhoFoto
                                           WHERE CodigoArtista = @codigoArtista
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
                    SqlCommand sqlCommand = new SqlCommand(queryAtualizarArtista, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nome", artista.Nome);
                    sqlCommand.Parameters.AddWithValue("@dataNascimento", artista.DataDeNascimento);
                    sqlCommand.Parameters.AddWithValue("@pais", artista.Pais);
                    sqlCommand.Parameters.AddWithValue("@caminhoFoto", artista.CaminhoFoto);
                    sqlCommand.Parameters.AddWithValue("@codigoArtista", artista.CodigoArtista);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public void RemoverArtista(int codigoArtista)
        {
            var queryRemoverArtista = "DELETE FROM Artistas WHERE CodigoArtista = @codigoArtista";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRemoverArtista, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoArtista", codigoArtista);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public Artista RecuperarArtistaPeloNome(string nomeArtista)
        {
            Artista artista = null;
            var queryRecuperarArtista = @"SELECT *
                                          FROM Artistas
                                          WHERE Nome LIKE @nomeArtista
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

                SqlCommand sqlCommand = new SqlCommand(queryRecuperarArtista, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nomeArtista", $"%{nomeArtista}%");
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows && sqlDataReader.Read())
                {
                    artista = new Artista();
                    artista.CodigoArtista = Convert.ToInt32(sqlDataReader["CodigoArtista"].ToString());
                    artista.Nome = sqlDataReader["Nome"].ToString();
                    DateTime.TryParse(sqlDataReader["DataNascimento"].ToString(), out DateTime dataNascimento);
                    artista.DataDeNascimento = dataNascimento;
                    artista.Pais = sqlDataReader["Pais"].ToString();
                    artista.CaminhoFoto = sqlDataReader["CaminhoFoto"].ToString();
                }

                return artista;
            }
        }

        public List<FilmeArtista> PesquisarFilmesDoArtistaPeloNome(string nomeArtista)
        {
            FilmeArtista filmeArtista = null;
            List<FilmeArtista> filmesArtista = new List<FilmeArtista>();
            var queryPesquisarArtista = $@"SELECT 
                                               T0.CodigoArtista,
                                               T2.Titulo,
                                               T3.NomePersonagem 
                                           FROM Artistas T0
                                               INNER JOIN ArtistasFilme T1 ON T0.CodigoArtista = T1.CodigoArtista
                                               INNER JOIN Itens T2 ON T1.CodigoItem = T2.CodigoItem 
                                               INNER JOIN PersonagensFilme T3 ON T2.CodigoArtista = T3.CodigoArtista AND T2.Codigoitem = T3.CodigoItem
                                           WHERE Nome LIKE @nomeArtista
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
                    SqlCommand sqlCommand = new SqlCommand(queryPesquisarArtista, sqlConnection);
                    SqlDataReader sqlDataReader;
                    sqlCommand.Parameters.AddWithValue("@nomeArtista", $"%{nomeArtista}%");
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            filmeArtista = new FilmeArtista();
                            filmeArtista.CodigoArtista = Convert.ToInt32(sqlDataReader["CodigoArtista"]);
                            filmeArtista.NomeFilme = sqlDataReader["NomeFilme"].ToString();
                            filmeArtista.NomePersonagem = sqlDataReader["NomePersonagem"].ToString();
                            filmesArtista.Add(filmeArtista);
                        }
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return filmesArtista;
        }

    }
}
