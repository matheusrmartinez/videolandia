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

        public Funcionario PesquisarFuncionario(int codigoPessoa)
        {
            Funcionario funcionario = null;
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
                        funcionario = new Funcionario();
                        funcionario.CodigoPessoa = codigoPessoa;
                        funcionario.Nome = sqlDataReader["Nome"].ToString();
                        funcionario.DataNascimento = DateTime.Parse(sqlDataReader["DataNascimento"].ToString());
                        funcionario.Sexo = Convert.ToChar(sqlDataReader["Sexo"].ToString());
                        funcionario.EstadoCivil = sqlDataReader["EstadoCivil"].ToString();
                        funcionario.RG = sqlDataReader["RG"].ToString();
                        funcionario.CPF = sqlDataReader["CPF"].ToString();
                        funcionario.Endereco = sqlDataReader["Endereco"].ToString();
                        funcionario.Cidade = sqlDataReader["Cidade"].ToString();
                        funcionario.CEP = sqlDataReader["CEP"].ToString();
                        funcionario.Estado = sqlDataReader["Estado"].ToString();
                        funcionario.Telefone = sqlDataReader["Telefone"].ToString();
                        funcionario.Celular = sqlDataReader["Celular"].ToString();
                        funcionario.Email = sqlDataReader["Email"].ToString();
                        funcionario.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return funcionario;
        }

        public Cliente PesquisarCliente(int codigoPessoa)
        {
            Cliente cliente = null;
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
                        cliente = new Cliente();
                        cliente.CodigoPessoa = codigoPessoa;
                        cliente.Nome = sqlDataReader["Nome"].ToString();
                        cliente.DataNascimento = DateTime.Parse(sqlDataReader["DataNascimento"].ToString());
                        cliente.Sexo = Convert.ToChar(sqlDataReader["Sexo"].ToString());
                        cliente.EstadoCivil = sqlDataReader["EstadoCivil"].ToString();
                        cliente.RG = sqlDataReader["RG"].ToString();
                        cliente.CPF = sqlDataReader["CPF"].ToString();
                        cliente.Endereco = sqlDataReader["Endereco"].ToString();
                        cliente.Cidade = sqlDataReader["Cidade"].ToString();
                        cliente.CEP = sqlDataReader["CEP"].ToString();
                        cliente.Estado = sqlDataReader["Estado"].ToString();
                        cliente.Telefone = sqlDataReader["Telefone"].ToString();
                        cliente.Celular = sqlDataReader["Celular"].ToString();
                        cliente.Email = sqlDataReader["Email"].ToString();
                        cliente.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return cliente;
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

        public Cliente PesquisarClientePeloCPF(string CPF)
        {
            Cliente cliente = null;
            var queryPesquisarCliente = $@"SELECT * 
                                               FROM Pessoas 
                                               WHERE Funcionario = 'N'
                                               AND CPF = @cpf
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
                    sqlCommand.Parameters.AddWithValue("@cpf", CPF);
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        cliente = new Cliente();
                        cliente.CodigoPessoa = Convert.ToInt32(sqlDataReader["CodigoPessoa"].ToString());
                        cliente.Nome = sqlDataReader["Nome"].ToString();
                        cliente.DataNascimento = DateTime.Parse(sqlDataReader["DataNascimento"].ToString());
                        cliente.Sexo = Convert.ToChar(sqlDataReader["Sexo"].ToString());
                        cliente.EstadoCivil = sqlDataReader["EstadoCivil"].ToString();
                        cliente.RG = sqlDataReader["RG"].ToString();
                        cliente.CPF = sqlDataReader["CPF"].ToString();
                        cliente.Endereco = sqlDataReader["Endereco"].ToString();
                        cliente.Cidade = sqlDataReader["Cidade"].ToString();
                        cliente.CEP = sqlDataReader["CEP"].ToString();
                        cliente.Estado = sqlDataReader["Estado"].ToString();
                        cliente.Telefone = sqlDataReader["Telefone"].ToString();
                        cliente.Celular = sqlDataReader["Celular"].ToString();
                        cliente.Email = sqlDataReader["Email"].ToString();
                        cliente.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return cliente;
        }

        public void AtualizarSituacaoDoCliente(int codigoPessoa, bool clienteDevendo)
        {
            string devendo = clienteDevendo ? "Devendo" : "OK";

            var queryAtualizarSituacaoCliente = $"UPDATE Pessoas SET SituacaoPagamentos = '{devendo}' WHERE CodigoPessoa = @codigoPessoa";

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
                    SqlCommand sqlCommand = new SqlCommand(queryAtualizarSituacaoCliente, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@codigoPessoa", codigoPessoa);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
        }

        public string RecuperarSituacaoCliente(int codigoCliente)
        {
            var situacaoCliente = string.Empty;
            var queryRecuperarCodigoSituacao = $@"SELECT 
                                                    SituacaoPagamentos
                                                  FROM Pessoas 
                                                  WHERE Funcionario = 'N'
                                                  AND CodigoPessoa = @codigoCliente
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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarCodigoSituacao, sqlConnection);
                    SqlDataReader sqlDataReader;
                    sqlCommand.Parameters.AddWithValue("@codigoCliente", codigoCliente);
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        situacaoCliente = sqlDataReader["SituacaoPagamentos"].ToString();

                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return situacaoCliente;
        }

        public int RecuperarCodigoDoFuncionarioPeloNome(string nome)
        {
            var codigoFuncionario = -1;
            var queryRecuperarCodigoFuncionario = $@"SELECT 
                                                    CodigoPessoa
                                                  FROM Pessoas 
                                                  WHERE Funcionario = 'Y'
                                                  AND Nome LIKE @nomePessoa
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
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarCodigoFuncionario, sqlConnection);
                    SqlDataReader sqlDataReader;
                    sqlCommand.Parameters.AddWithValue("@nomePessoa", $"%{nome}%");
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        codigoFuncionario = Convert.ToInt32(sqlDataReader["CodigoPessoa"].ToString());
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return codigoFuncionario;
        }

        public List<HistoricoLocacaoCliente> RecuperarHistoricoLocacaoClientes()
        {
            HistoricoLocacaoCliente historicoLocacaoCliente = null;
            List<HistoricoLocacaoCliente> historicoLocacaoClientes = new List<HistoricoLocacaoCliente>();

            var queryHistoricoLocacoesClientes = $@"
                                            SELECT 
                                                T2.Nome,
                                                T0.DataAtual,
                                                T1.DataEntrega,
                                                T0.ValorPago,
                                                T0.DataPrevista
                                            FROM Locacoes T0
                                                INNER JOIN Devolucoes T1 ON T0.CodigoLocacao= T1.CodigoLocacao
                                                INNER JOIN Pessoas T2 ON T0.CodigoCliente = T0.CodigoCliente
                                            WHERE T2.Funcionario = 'N'
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
                    SqlCommand sqlCommand = new SqlCommand(queryHistoricoLocacoesClientes, sqlConnection);
                    SqlDataReader sqlDataReader;
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        historicoLocacaoCliente = new HistoricoLocacaoCliente();
                        historicoLocacaoCliente.Nome = sqlDataReader["Nome"].ToString();
                        historicoLocacaoCliente.DataLocacao = Convert.ToDateTime(sqlDataReader["DataAtual"].ToString());
                        historicoLocacaoCliente.DataLocacao = Convert.ToDateTime(sqlDataReader["DataEntrega"].ToString());
                        historicoLocacaoCliente.ValorPago = Convert.ToDecimal(sqlDataReader["ValorPago"].ToString());
                        historicoLocacaoCliente.DataLocacao = Convert.ToDateTime(sqlDataReader["DataPrevista"].ToString());
                        historicoLocacaoClientes.Add(historicoLocacaoCliente);

                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
                }
            }
            return historicoLocacaoClientes;
        }
    }
}
