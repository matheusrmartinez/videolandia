using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class PersonagemFilmeDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VideoLandiaDB"].ConnectionString;
        public void AdicionarPersonagem(PersonagemFilme personagemFilme)
        {
            var queryAdicionarPersonagem = @"INSERT INTO PersonagensFilme (CodigoArtista, CodigoDeBarras, NomePersonagem, NomeArtista, Titulo)
                                         VALUES
                                        (
                                            @codigoArtista, 
                                            @codigoDeBarras,
                                            @nomePersonagem,
                                            @nomeArtista,
                                            @titulo
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
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarPersonagem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoArtista", personagemFilme.CodigoArtista);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", personagemFilme.CodigoDeBarrasFilme);
                    sqlCommand.Parameters.AddWithValue("@nomePersonagem", personagemFilme.NomePersonagem);
                    sqlCommand.Parameters.AddWithValue("@nomeArtista", personagemFilme.NomeAtor);
                    sqlCommand.Parameters.AddWithValue("@titulo", personagemFilme.Titulo);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public void AtualizarPersonagem(PersonagemFilme personagemFilme)
        {
            var queryAtualizarItem = @" 
                                               UPDATE PersonagensFilme 
                                               SET 
                                                     CodigoArtista = @codigoDeBarras, 
                                                     CodigoDeBarras = @titulo,
                                                     NomePersonagem = @nomePersonagem,
                                               WHERE NomePersonagem = @nomePersonagem
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
                    SqlCommand sqlCommand = new SqlCommand(queryAtualizarItem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoArtista", personagemFilme.CodigoArtista);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", personagemFilme.CodigoDeBarrasFilme);
                    sqlCommand.Parameters.AddWithValue("@nomePersonagem", personagemFilme.NomePersonagem);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public void RemoverPersonagem(string nomePersonagem)
        {
            var queryRemoverItem = "DELETE FROM PersonagensFilme WHERE NomePersonagem = @nomePersonagem";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRemoverItem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nomePersonagem", nomePersonagem);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public PersonagemFilme RecuperarPersonagemFilme(string nomePersonagem, string nomeArtista)
        {
            PersonagemFilme personagemFilme = null;
            var queryRecuperarPersonagem = @"SELECT * 
                                             FROM PersonagensFilme 
                                             WHERE NomePersonagem LIKE @nomePersonagem
                                             OR NomeArtista LIKE @nomeArtista
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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarPersonagem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nomePersonagem", $"%{nomePersonagem}%");
                    sqlCommand.Parameters.AddWithValue("@nomeArtista", $"%{nomeArtista}%");
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        personagemFilme = new PersonagemFilme();
                        personagemFilme.CodigoArtista = Convert.ToInt32(sqlDataReader["CodigoArtista"].ToString());
                        personagemFilme.CodigoDeBarrasFilme = sqlDataReader["CodigoDeBarras"].ToString();
                        personagemFilme.NomePersonagem = sqlDataReader["NomePersonagem"].ToString();
                        personagemFilme.NomeAtor = sqlDataReader["NomeArtista"].ToString();
                        personagemFilme.Titulo = sqlDataReader["Titulo"].ToString();
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }

            return personagemFilme;
        }

        public int RecuperarCodigoArtistaAPartirDoNome(string nomeArtista)
        {
            int codigoArtista = -1;
            var queryRecuperarCodigoArtista = @"SELECT 
                                                    T0.CodigoArtista
                                                FROM Artistas T0
                                                WHERE 
                                                    T0.Nome = @nomeArtista
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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarCodigoArtista, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nomeArtista", nomeArtista);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        codigoArtista = Convert.ToInt32(sqlDataReader["CodigoArtista"].ToString());
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return codigoArtista;
            }
        }

        public List<string> RecuperarTodosFilmes()
        {
            var titulo = string.Empty;
            var titulos = new List<string>();
            var queryRecuperarTodosFilmes = @"SELECT 
                                                Titulo
                                              FROM Itens";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarTodosFilmes, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            titulo = sqlDataReader["Titulo"].ToString();
                            titulos.Add(titulo);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return titulos;
            }
        }

        public List<string> RecuperarTodosArtistas()
        {
            var artista = string.Empty;
            var artistas = new List<string>();
            var queryRecuperarTodosArtistas = @"SELECT 
                                                Nome
                                              FROM Artistas";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarTodosArtistas, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            artista = sqlDataReader["Nome"].ToString();
                            artistas.Add(artista);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return artistas;

            }
        }

        public string RecuperarCodigoDeBarrasDoFilme(string titulo)
        {
            var codigoDeBarras = string.Empty;
            var queryRecuperarCodigoDeBarras = "SELECT CodigoDeBarras FROM Itens WHERE Titulo = @titulo";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarCodigoDeBarras, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@titulo", titulo);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                        codigoDeBarras = sqlDataReader["CodigoDeBarras"].ToString();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return codigoDeBarras;
            }
        }

        public bool VerificarSeExistePersonagemParaOFilmeECodigoArtistaInformado(string titulo, int codigoArtista)
        {
            var existePersonagem = false;
            var queryRecuperarVerificarSeExistePersonagem = "SELECT COUNT(*) FROM Itens WHERE Titulo = @titulo AND CodigoArtista = @codigoArtista";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarVerificarSeExistePersonagem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@titulo", titulo);
                    sqlCommand.Parameters.AddWithValue("@codigoArtista", codigoArtista);
                    existePersonagem = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                    
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return existePersonagem;
            }
        }
    }
}
