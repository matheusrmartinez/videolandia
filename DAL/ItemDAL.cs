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
    public class ItemDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VideoLandiaDB"].ConnectionString;
        public void AdicionarItem(Item Item)
        {
            var queryAdicionarItem = @"INSERT INTO Itens (CodigoDeBarras, Titulo, CodigoGenero, Ano, Tipo, Preco, DataAdquirida, Custo, CodigoSituacao, CodigoArtista) 
                                         VALUES
                                        (
                                            @codigoDeBarras, 
                                            @titulo,
                                            @codigoGenero,
                                            @ano,
                                            @tipo,
                                            @preco,
                                            @dataAdquirida,
                                            @custo,
                                            @codigoSituacao,
                                            @codigoArtista
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
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", Item.CodigoDeBarras);
                    sqlCommand.Parameters.AddWithValue("@titulo", Item.Titulo);
                    sqlCommand.Parameters.AddWithValue("@codigoGenero", 1);
                    sqlCommand.Parameters.AddWithValue("@ano", Item.Ano);
                    sqlCommand.Parameters.AddWithValue("@tipo", Item.Tipo);
                    sqlCommand.Parameters.AddWithValue("@preco", Item.Preco);
                    sqlCommand.Parameters.AddWithValue("@dataAdquirida", Item.DataAdquirida);
                    sqlCommand.Parameters.AddWithValue("@custo", Item.Custo);
                    sqlCommand.Parameters.AddWithValue("@codigoSituacao", 1);
                    sqlCommand.Parameters.AddWithValue("@codigoArtista", 1);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

            }
        }
        public void AtualizarItem(Item Item)
        {
            var queryAtualizarItem = @" 
                                               UPDATE Itens 
                                               SET 
                                                     CodigoDeBarras = @codigoDeBarras, 
                                                     Titulo = @titulo,
                                                     CodigoGenero = @codigoGenero,
                                                     Ano = @ano,
                                                     Tipo = @tipo,
                                                     Preco = @preco,
                                                     DataAdquirida = @dataAdquirida,
                                                     Custo = @custo,
                                                     CodigoSituacao = @codigoSituacao,
                                                     CodigoArtista = @codigoArtista
                                                WHERE CodigoDeBarras = @codigoDeBarras
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
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", Item.CodigoDeBarras);
                    sqlCommand.Parameters.AddWithValue("@titulo", Item.Titulo);
                    sqlCommand.Parameters.AddWithValue("@codigoGenero", 1);
                    sqlCommand.Parameters.AddWithValue("@ano", Item.Ano);
                    sqlCommand.Parameters.AddWithValue("@tipo", Item.Tipo);
                    sqlCommand.Parameters.AddWithValue("@preco", Item.Preco);
                    sqlCommand.Parameters.AddWithValue("@dataAdquirida", Item.DataAdquirida);
                    sqlCommand.Parameters.AddWithValue("@custo", Item.Custo);
                    sqlCommand.Parameters.AddWithValue("@codigoSituacao", 1);
                    sqlCommand.Parameters.AddWithValue("@codigoArtista", 1);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }
        public void RemoverItem(int codigoDeBarras)
        {
            var queryRemoverItem = "DELETE FROM Items WHERE CodigoDeBarras = @codigoDeBarras";

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
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }
        public List<string> RecuperarGenerosDoFilme(string codigoDeBarras, string titulo)
        {
            List<string> generosFilme = new List<string>();

            var queryRecuperarGenerosDoFilme = @"SELECT T1.Nome 
                                                 FROM GenerosFilmes T0
                                                    INNER JOIN Generos T1 ON T0.CodigoGenero = T1.CodigoGenero
                                                 WHERE T0.CodigoDeBarras = @codigoDeBarras
                                                    OR T0.Titulo LIKE @titulo";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarGenerosDoFilme, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                    sqlCommand.Parameters.AddWithValue("@titulo", $"%'{titulo}'%");
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            var genero = sqlDataReader["Nome"].ToString();
                            generosFilme.Add(genero);
                        }
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return generosFilme;
            }
        }
        public Item RecuperarFilmePeloCodigoDeBarrasOuPeloTitulo(string codigoDeBarras, string titulo)
        {
            Item item = null;
            var queryRecuperarFilme = @"SELECT * 
                                        FROM Itens
                                        WHERE CodigoDeBarras = @codigoDeBarras
                                         OR Titulo = @titulo";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarFilme, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                    sqlCommand.Parameters.AddWithValue("@titulo", titulo);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        item = new Item();
                        item.CodigoItem = Convert.ToInt32(sqlDataReader["CodigoItem"].ToString());
                        item.CodigoDeBarras = sqlDataReader["CodigoDeBarras"].ToString();
                        item.Titulo = sqlDataReader["Titulo"].ToString();
                        item.Ano = Convert.ToInt32(sqlDataReader["Ano"].ToString());
                        item.Tipo = sqlDataReader["Tipo"].ToString();
                        item.Preco = Convert.ToDecimal(sqlDataReader["Preco"].ToString());
                        item.DataAdquirida = Convert.ToDateTime(sqlDataReader["DataAdquirida"].ToString());
                        item.Custo = Convert.ToDecimal(sqlDataReader["Custo"].ToString());
                        item.CodigoSituacaoFilme = Convert.ToInt32(sqlDataReader["CodigoSituacao"].ToString());
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
                return item;
            }
        }
        public List<Item> ListarTodosOsFilmesCadastrados()
        {
            List<Item> itens = new List<Item>();
            Item item = null;

            var queryRecuperarFilmes = @"SELECT 
                                          CodigoDeBarras,
                                          Titulo,
                                          Ano
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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarFilmes, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            item = new Item();
                            item.CodigoDeBarras = sqlDataReader["CodigoDeBarras"].ToString();
                            item.Titulo = sqlDataReader["Titulo"].ToString();
                            item.Ano = Convert.ToInt32(sqlDataReader["Ano"].ToString());
                            itens.Add(item);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
                return itens;
            }
        }
        public List<PersonagemFilme> ListarPersonagensDoFilmeDadoUmTituloOuCodigoDeBarras(string codigoDeBarras, string titulo)
        {
            PersonagemFilme personagemFilme = null;
            List<PersonagemFilme> personagensFilme = new List<PersonagemFilme>();

            var queryRecuperarPersonagensFilme = @"SELECT 
                                                   T1.Nome,
                                                   T0.NomePersonagem
                                                   FROM PersonagensFilme T0
                                                       INNER JOIN Artistas T1 ON T0.CodigoArtista = T1.CodigoArtista
                                                       INNER JOIN Itens T2 ON T2.CodigoDeBarras = T0.CodigoDeBarras
                                                   WHERE T2.CodigoDeBarras = @codigoDeBarras OR
                                                   T2.Titulo = @titulo
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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarPersonagensFilme, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                    sqlCommand.Parameters.AddWithValue("@titulo", titulo);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            personagemFilme = new PersonagemFilme();
                            personagemFilme.NomeAtor = sqlDataReader["Nome"].ToString();
                            personagemFilme.NomePersonagem = sqlDataReader["NomePersonagem"].ToString();
                            personagensFilme.Add(personagemFilme);
                        }
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return personagensFilme;
            }
        }
        public void InserirNaTabelaSituacao(Situacao situacao)
        {
            var queryAdicionarSituacao = @"INSERT INTO Situacoes (NomeCliente, DataRetirada, DataPrevista, Telefone, Celular) 
                                         VALUES
                                        (
                                            @nomeCliente, 
                                            @dataRetirada,
                                            @dataPrevista,
                                            @telefone,
                                            @celular
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
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarSituacao, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nomeCliente", situacao.NomeCliente);
                    sqlCommand.Parameters.AddWithValue("@dataRetirada", situacao.DataRetirada);
                    sqlCommand.Parameters.AddWithValue("@dataPrevista", situacao.DataPrevista);
                    sqlCommand.Parameters.AddWithValue("@telefone", situacao.Telefone);
                    sqlCommand.Parameters.AddWithValue("@celular", situacao.Celular);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }
        public void InserirSituacaoPadraoNaTabelaSituacao(Situacao situacao)
        {
            var queryAdicionarSituacao = @"INSERT INTO Situacoes (NomeCliente, DataRetirada, DataPrevista, Telefone, Celular) 
                                         VALUES
                                        (
                                            @nomeCliente, 
                                            @dataRetirada,
                                            @dataPrevista,
                                            @telefone,
                                            @celular
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
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarSituacao, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nomeCliente", null);
                    sqlCommand.Parameters.AddWithValue("@dataRetirada", null);
                    sqlCommand.Parameters.AddWithValue("@dataPrevista", null);
                    sqlCommand.Parameters.AddWithValue("@telefone", null);
                    sqlCommand.Parameters.AddWithValue("@celular", null);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }
        public bool VerificarSeExisteRegistroPadraoNaTabelaSituacao()
        {
            var existeRegistroNaTabela = false;

            var verificarSeExisteRegistroNaTabela = "SELECT COUNT(*) FROM Situacoes";

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
                    SqlCommand sqlCommand = new SqlCommand(verificarSeExisteRegistroNaTabela, sqlConnection);
                    existeRegistroNaTabela = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }

            return existeRegistroNaTabela;
        }
        public int RecuperarCodigoDaUltimaSituacaoInserida()
        {
            var queryRecuperarUltimoCodigoSituacaoInserida = "SELECT TOP 1 CodigoSituacao FROM Situacoes ORDER BY CodigoSituacao DESC";
            int codigoSituacao = 0;

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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarUltimoCodigoSituacaoInserida, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        codigoSituacao = Convert.ToInt32(sqlDataReader["CodigoSituacao"].ToString());
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return codigoSituacao;
        }
        public void AtualizarSituacaoItem(int codigoSituacao, string codigoDeBarras)
        {
            var queryAtualizarSituacaoItem = "UPDATE Itens SET CodigoSituacao = @codigoSituacao WHERE CodigoDeBarras = @codigoDeBarras";

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
                    SqlCommand sqlCommand = new SqlCommand(queryAtualizarSituacaoItem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoSituacao", codigoSituacao);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }
        public int RecuperarSituacaoDoItemPeloTituloOuCodigoDeBarras(string codigoDeBarras, string titulo)
        {
            var codigoSituacao = -1;
            var queryRecuperarSituacaoItem = "SELECT CodigoSituacao FROM Itens WHERE CodigoDeBarras = @codigoDeBarras OR titulo = @titulo ";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarSituacaoItem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoDeBarras", codigoDeBarras);
                    sqlCommand.Parameters.AddWithValue("@titulo", titulo);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        codigoSituacao = Convert.ToInt32(sqlDataReader["CodigoSituacao"].ToString());
                    }

                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

                return codigoSituacao;
            }
        }
    }
}

