using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class PessoaDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["VideoLandiaDB"].ConnectionString;
        public void AdicionarPessoa(Pessoa pessoa)
        {
            var queryAdicionarPessoa = @"INSERT INTO Pessoas (Funcionario, Nome, DataNascimento, Sexo, EstadoCivil, RG, CPF, Endereco, Cidade, CEP, Estado, Telefone, Celular, Email, SituacaoPagamentos)
                                         VALUES
                                        (
                                            @funcionario,
                                            @nome,
                                            @dataNascimento, 
                                            @sexo,
                                            @estadoCivil,
                                            @rg,
                                            @cpf,
                                            @endereco,
                                            @cidade,
                                            @cep,
                                            @estado,
                                            @telefone,
                                            @celular,
                                            @email,
                                            @situacaoPagamentos
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
                    SqlCommand sqlCommand = new SqlCommand(queryAdicionarPessoa, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@funcionario", pessoa.Funcionario);
                    sqlCommand.Parameters.AddWithValue("@nome", pessoa.Nome);
                    sqlCommand.Parameters.AddWithValue("@dataNascimento", pessoa.DataNascimento);
                    sqlCommand.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                    sqlCommand.Parameters.AddWithValue("@estadoCivil", pessoa.EstadoCivil);
                    sqlCommand.Parameters.AddWithValue("@rg", pessoa.RG);
                    sqlCommand.Parameters.AddWithValue("@cpf", pessoa.CPF);
                    sqlCommand.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                    sqlCommand.Parameters.AddWithValue("@cidade", pessoa.Cidade);
                    sqlCommand.Parameters.AddWithValue("@cep", pessoa.CEP);
                    sqlCommand.Parameters.AddWithValue("@estado", pessoa.Estado);
                    sqlCommand.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                    sqlCommand.Parameters.AddWithValue("@celular", pessoa.Celular);
                    sqlCommand.Parameters.AddWithValue("@email", pessoa.Email);
                    sqlCommand.Parameters.AddWithValue("@situacaoPagamentos", pessoa.SituacaoPagamentos);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }

            }
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            var queryAtualizarPessoa = @" 
                                           UPDATE Pessoas 
                                           SET 
                                               Nome = @nome,  
                                               DataNascimento = @dataNascimento, 
                                               Sexo = @sexo,
                                               EstadoCivil = @estadoCivil,
                                               RG = @rg,
                                               CPF = @cpf,
                                               Endereco = @endereco,
                                               Cidade = @cidade,
                                               CEP = @cep,
                                               Estado = @estado,
                                               Telefone = @telefone,
                                               Celular = @celular,
                                               Email = @email,
                                               SituacaoPagamentos = @situacaoPagamentos
                                           WHERE CodigoPessoa = @codigoPessoa
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
                    SqlCommand sqlCommand = new SqlCommand(queryAtualizarPessoa, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nome", pessoa.Nome);
                    sqlCommand.Parameters.AddWithValue("@dataNascimento", pessoa.DataNascimento);
                    sqlCommand.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                    sqlCommand.Parameters.AddWithValue("@estadoCivil", pessoa.EstadoCivil);
                    sqlCommand.Parameters.AddWithValue("@rg", pessoa.RG);
                    sqlCommand.Parameters.AddWithValue("@cpf", pessoa.CPF);
                    sqlCommand.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                    sqlCommand.Parameters.AddWithValue("@cidade", pessoa.Cidade);
                    sqlCommand.Parameters.AddWithValue("@cep", pessoa.CEP);
                    sqlCommand.Parameters.AddWithValue("@estado", pessoa.Estado);
                    sqlCommand.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                    sqlCommand.Parameters.AddWithValue("@celular", pessoa.Celular);
                    sqlCommand.Parameters.AddWithValue("@email", pessoa.Email);
                    sqlCommand.Parameters.AddWithValue("@situacaoPagamentos", pessoa.SituacaoPagamentos);
                    sqlCommand.Parameters.AddWithValue("@codigoPessoa", pessoa.CodigoPessoa);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public void RemoverPessoa(int codigoPessoa)
        {
            var queryRemoverPessoa = "DELETE FROM Pessoas WHERE CodigoPessoa = @codigoPessoa";

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
                    SqlCommand sqlCommand = new SqlCommand(queryRemoverPessoa, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoPessoa", codigoPessoa);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public Pessoa PesquisarFuncionario(int codigoPessoa)
        {
            Pessoa pessoa = null;
            var queryPesquisarFuncionario = $@"SELECT * 
                                               FROM Pessoas 
                                               WHERE Funcionario = 'Y'
                                               AND CodigoPessoa = @codigoPessoa
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
                    SqlCommand sqlCommand = new SqlCommand(queryPesquisarFuncionario, sqlConnection);
                    SqlDataReader sqlDataReader;
                    sqlCommand.Parameters.AddWithValue("@codigoPessoa", codigoPessoa);
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        pessoa = new Pessoa();
                        pessoa.CodigoPessoa = codigoPessoa;
                        pessoa.Nome = sqlDataReader["Nome"].ToString();
                        pessoa.DataNascimento = DateTime.Parse(sqlDataReader["DataNascimento"].ToString());
                        pessoa.Sexo = Convert.ToChar(sqlDataReader["Sexo"].ToString());
                        pessoa.EstadoCivil = sqlDataReader["EstadoCivil"].ToString();
                        pessoa.RG = sqlDataReader["RG"].ToString();
                        pessoa.CPF = sqlDataReader["CPF"].ToString();
                        pessoa.Endereco = sqlDataReader["Endereco"].ToString();
                        pessoa.Cidade = sqlDataReader["Cidade"].ToString();
                        pessoa.CEP = sqlDataReader["CEP"].ToString();
                        pessoa.Estado = sqlDataReader["Estado"].ToString();
                        pessoa.Telefone = sqlDataReader["Telefone"].ToString();
                        pessoa.Celular = sqlDataReader["Celular"].ToString();
                        pessoa.Email = sqlDataReader["Email"].ToString();
                        pessoa.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return pessoa;
        }

        public Pessoa PesquisarCliente(int codigoPessoa)
        {
            Pessoa pessoa = null;
            var queryPesquisarCliente = $@"SELECT * 
                                               FROM Pessoas 
                                               WHERE Funcionario = 'N'
                                               AND CodigoPessoa = @codigoPessoa
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
                    SqlCommand sqlCommand = new SqlCommand(queryPesquisarCliente, sqlConnection);
                    SqlDataReader sqlDataReader;
                    sqlCommand.Parameters.AddWithValue("@codigoPessoa", codigoPessoa);
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        pessoa = new Pessoa();
                        pessoa.CodigoPessoa = codigoPessoa;
                        pessoa.Nome = sqlDataReader["Nome"].ToString();
                        pessoa.DataNascimento = DateTime.Parse(sqlDataReader["DataNascimento"].ToString());
                        pessoa.Sexo = Convert.ToChar(sqlDataReader["Sexo"].ToString());
                        pessoa.EstadoCivil = sqlDataReader["EstadoCivil"].ToString();
                        pessoa.RG = sqlDataReader["RG"].ToString();
                        pessoa.CPF = sqlDataReader["CPF"].ToString();
                        pessoa.Endereco = sqlDataReader["Endereco"].ToString();
                        pessoa.Cidade = sqlDataReader["Cidade"].ToString();
                        pessoa.CEP = sqlDataReader["CEP"].ToString();
                        pessoa.Estado = sqlDataReader["Estado"].ToString();
                        pessoa.Telefone = sqlDataReader["Telefone"].ToString();
                        pessoa.Celular = sqlDataReader["Celular"].ToString();
                        pessoa.Email = sqlDataReader["Email"].ToString();
                        pessoa.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return pessoa;
        }

        public List<Pessoa> ListarTodosClientes()
        {
            Pessoa cliente = null;
            List<Pessoa> clientes = new List<Pessoa>();
            var queryListarTodosClientes = @"SELECT 
                                                 CodigoPessoa,
                                                 Nome,
                                                 CPF,
                                                 SituacaoPagamentos
                                             FROM Pessoas
                                             WHERE Funcionario = 'N'";

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
                        cliente = new Pessoa();
                        cliente.CodigoPessoa = Convert.ToInt32(sqlDataReader["CodigoPessoa"].ToString());
                        cliente.Nome = sqlDataReader["Nome"].ToString();
                        cliente.CPF = sqlDataReader["CPF"].ToString();
                        cliente.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
                        clientes.Add(cliente);
                    }
                }

                return clientes;
            }
        }

         public List<Pessoa> ListarTodosFuncionarios()
        {
            Pessoa funcionario = null;
            List<Pessoa> funcionarios = new List<Pessoa>();
            var queryListarTodosFuncionarios = @"SELECT 
                                                 CodigoPessoa,
                                                 Nome,
                                                 CPF,
                                                 SituacaoPagamentos
                                             FROM Pessoas
                                             WHERE Funcionario = 'Y'";

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

                SqlCommand sqlCommand = new SqlCommand(queryListarTodosFuncionarios, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        funcionario = new Pessoa();
                        funcionario.CodigoPessoa = Convert.ToInt32(sqlDataReader["CodigoPessoa"].ToString());
                        funcionario.Nome = sqlDataReader["Nome"].ToString();
                        funcionario.CPF = sqlDataReader["CPF"].ToString();
                        funcionario.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
                        funcionarios.Add(funcionario);
                    }
                }

                return funcionarios;
            }
        }
    }
}
