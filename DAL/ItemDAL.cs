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
        //public void AdicionarItem(Item Item)
        //{
        //    var queryAdicionarItem = @"INSERT INTO Itens (CodigoItem, CodigoDeBarras, Titulo, CodigoGenero, Ano, Tipo, Preco, DataAdquirida, Custo, CodigoSituacao, CodigoArtista) 
        //                                 VALUES
        //                                (
        //                                    @funcionario,
        //                                    @nome,
        //                                    @dataNascimento, 
        //                                    @sexo,
        //                                    @estadoCivil,
        //                                    @rg,
        //                                    @cpf,
        //                                    @endereco,
        //                                    @cidade,
        //                                    @cep,
        //                                    @estado,
        //                                    @telefone,
        //                                    @celular,
        //                                    @email,
        //                                    @situacaoPagamentos
        //                                )
        //                                ";

        //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            sqlConnection.Open();
        //        }
        //        catch (Exception)
        //        {

        //            throw new Exception("Falha ao conectar no banco de dados");
        //        }
        //        try
        //        {
        //            SqlCommand sqlCommand = new SqlCommand(queryAdicionarItem, sqlConnection);
        //            sqlCommand.Parameters.AddWithValue("@funcionario", Item.Funcionario);
        //            sqlCommand.Parameters.AddWithValue("@nome", Item.Nome);
        //            sqlCommand.Parameters.AddWithValue("@dataNascimento", Item.DataNascimento);
        //            sqlCommand.Parameters.AddWithValue("@sexo", Item.Sexo);
        //            sqlCommand.Parameters.AddWithValue("@estadoCivil", Item.EstadoCivil);
        //            sqlCommand.Parameters.AddWithValue("@rg", Item.RG);
        //            sqlCommand.Parameters.AddWithValue("@cpf", Item.CPF);
        //            sqlCommand.Parameters.AddWithValue("@endereco", Item.Endereco);
        //            sqlCommand.Parameters.AddWithValue("@cidade", Item.Cidade);
        //            sqlCommand.Parameters.AddWithValue("@cep", Item.CEP);
        //            sqlCommand.Parameters.AddWithValue("@estado", Item.Estado);
        //            sqlCommand.Parameters.AddWithValue("@telefone", Item.Telefone);
        //            sqlCommand.Parameters.AddWithValue("@celular", Item.Celular);
        //            sqlCommand.Parameters.AddWithValue("@email", Item.Email);
        //            sqlCommand.Parameters.AddWithValue("@situacaoPagamentos", Item.SituacaoPagamentos);
        //            sqlCommand.ExecuteNonQuery();
        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
        //        }

        //    }
        //}
        //public void AtualizarItem(Item Item)
        //{
        //    var queryAtualizarItem = @" 
        //                                   UPDATE Items 
        //                                   SET 
        //                                       Nome = @nome,  
        //                                       DataNascimento = @dataNascimento, 
        //                                       Sexo = @sexo,
        //                                       EstadoCivil = @estadoCivil,
        //                                       RG = @rg,
        //                                       CPF = @cpf,
        //                                       Endereco = @endereco,
        //                                       Cidade = @cidade,
        //                                       CEP = @cep,
        //                                       Estado = @estado,
        //                                       Telefone = @telefone,
        //                                       Celular = @celular,
        //                                       Email = @email,
        //                                       SituacaoPagamentos = @situacaoPagamentos
        //                                   WHERE CodigoItem = @codigoItem
        //                               ";

        //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            sqlConnection.Open();
        //        }
        //        catch (Exception)
        //        {
        //            throw new Exception("Falha ao conectar no banco de dados.");
        //        }

        //        try
        //        {
        //            SqlCommand sqlCommand = new SqlCommand(queryAtualizarItem, sqlConnection);
        //            sqlCommand.Parameters.AddWithValue("@nome", Item.Nome);
        //            sqlCommand.Parameters.AddWithValue("@dataNascimento", Item.DataNascimento);
        //            sqlCommand.Parameters.AddWithValue("@sexo", Item.Sexo);
        //            sqlCommand.Parameters.AddWithValue("@estadoCivil", Item.EstadoCivil);
        //            sqlCommand.Parameters.AddWithValue("@rg", Item.RG);
        //            sqlCommand.Parameters.AddWithValue("@cpf", Item.CPF);
        //            sqlCommand.Parameters.AddWithValue("@endereco", Item.Endereco);
        //            sqlCommand.Parameters.AddWithValue("@cidade", Item.Cidade);
        //            sqlCommand.Parameters.AddWithValue("@cep", Item.CEP);
        //            sqlCommand.Parameters.AddWithValue("@estado", Item.Estado);
        //            sqlCommand.Parameters.AddWithValue("@telefone", Item.Telefone);
        //            sqlCommand.Parameters.AddWithValue("@celular", Item.Celular);
        //            sqlCommand.Parameters.AddWithValue("@email", Item.Email);
        //            sqlCommand.Parameters.AddWithValue("@situacaoPagamentos", Item.SituacaoPagamentos);
        //            sqlCommand.Parameters.AddWithValue("@codigoItem", Item.CodigoItem);
        //            sqlCommand.ExecuteNonQuery();
        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
        //        }
        //    }
        //}

        //public void RemoverItem(int codigoItem)
        //{
        //    var queryRemoverItem = "DELETE FROM Items WHERE CodigoItem = @codigoItem";

        //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            sqlConnection.Open();
        //        }
        //        catch (Exception)
        //        {
        //            throw new Exception("Falha ao conectar no banco de dados.");
        //        }

        //        try
        //        {
        //            SqlCommand sqlCommand = new SqlCommand(queryRemoverItem, sqlConnection);
        //            sqlCommand.Parameters.AddWithValue("@codigoItem", codigoItem);
        //            sqlCommand.ExecuteNonQuery();
        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
        //        }
        //    }
        //}

        public List<string> RecuperarNomesGeneros()
        {
            var nomeGenero = string.Empty;
            List<string> generosFilme = new List<string>();
            var queryRecuperarGeneros = @"SELECT 
                                          Nome
                                          FROM GenerosFilmes";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("Falha ao conectar no banco de dados!");
                }

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(queryRecuperarGeneros, sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            nomeGenero = sqlDataReader["Nome"].ToString();
                            generosFilme.Add(nomeGenero);
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
    //}

    //public Item PesquisarFuncionario(int codigoItem)
    //{
    //    Item Item = null;
    //    var queryPesquisarFuncionario = $@"SELECT * 
    //                                       FROM Items 
    //                                       WHERE Funcionario = 'Y'
    //                                       AND CodigoItem = @codigoItem
    //                                      ";

    //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
    //    {
    //        try
    //        {
    //            sqlConnection.Open();
    //        }
    //        catch (System.Exception)
    //        {
    //            throw new Exception("Falha ao conectar no banco de dados!");
    //        }
    //        try
    //        {
    //            SqlCommand sqlCommand = new SqlCommand(queryPesquisarFuncionario, sqlConnection);
    //            SqlDataReader sqlDataReader;
    //            sqlCommand.Parameters.AddWithValue("@codigoItem", codigoItem);
    //            sqlDataReader = sqlCommand.ExecuteReader();

    //            if (sqlDataReader.HasRows && sqlDataReader.Read())
    //            {
    //                Item = new Item();
    //                Item.CodigoItem = codigoItem;
    //                Item.Nome = sqlDataReader["Nome"].ToString();
    //                Item.DataNascimento = DateTime.Parse(sqlDataReader["DataNascimento"].ToString());
    //                Item.Sexo = Convert.ToChar(sqlDataReader["Sexo"].ToString());
    //                Item.EstadoCivil = sqlDataReader["EstadoCivil"].ToString();
    //                Item.RG = sqlDataReader["RG"].ToString();
    //                Item.CPF = sqlDataReader["CPF"].ToString();
    //                Item.Endereco = sqlDataReader["Endereco"].ToString();
    //                Item.Cidade = sqlDataReader["Cidade"].ToString();
    //                Item.CEP = sqlDataReader["CEP"].ToString();
    //                Item.Estado = sqlDataReader["Estado"].ToString();
    //                Item.Telefone = sqlDataReader["Telefone"].ToString();
    //                Item.Celular = sqlDataReader["Celular"].ToString();
    //                Item.Email = sqlDataReader["Email"].ToString();
    //                Item.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
    //        }
    //    }
    //    return Item;
    //}

    //public Item PesquisarCliente(int codigoItem)
    //{
    //    Item Item = null;
    //    var queryPesquisarCliente = $@"SELECT * 
    //                                       FROM Items 
    //                                       WHERE Funcionario = 'N'
    //                                       AND CodigoItem = @codigoItem
    //                                      ";

    //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
    //    {
    //        try
    //        {
    //            sqlConnection.Open();
    //        }
    //        catch (System.Exception)
    //        {
    //            throw new Exception("Falha ao conectar no banco de dados!");
    //        }
    //        try
    //        {
    //            SqlCommand sqlCommand = new SqlCommand(queryPesquisarCliente, sqlConnection);
    //            SqlDataReader sqlDataReader;
    //            sqlCommand.Parameters.AddWithValue("@codigoItem", codigoItem);
    //            sqlDataReader = sqlCommand.ExecuteReader();

    //            if (sqlDataReader.HasRows && sqlDataReader.Read())
    //            {
    //                Item = new Item();
    //                Item.CodigoItem = codigoItem;
    //                Item.Nome = sqlDataReader["Nome"].ToString();
    //                Item.DataNascimento = DateTime.Parse(sqlDataReader["DataNascimento"].ToString());
    //                Item.Sexo = Convert.ToChar(sqlDataReader["Sexo"].ToString());
    //                Item.EstadoCivil = sqlDataReader["EstadoCivil"].ToString();
    //                Item.RG = sqlDataReader["RG"].ToString();
    //                Item.CPF = sqlDataReader["CPF"].ToString();
    //                Item.Endereco = sqlDataReader["Endereco"].ToString();
    //                Item.Cidade = sqlDataReader["Cidade"].ToString();
    //                Item.CEP = sqlDataReader["CEP"].ToString();
    //                Item.Estado = sqlDataReader["Estado"].ToString();
    //                Item.Telefone = sqlDataReader["Telefone"].ToString();
    //                Item.Celular = sqlDataReader["Celular"].ToString();
    //                Item.Email = sqlDataReader["Email"].ToString();
    //                Item.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            throw new Exception($"Falha ao executar a query. Retorno: {e.Message}");
    //        }
    //    }
    //    return Item;
    //}

    //public List<Item> ListarTodosClientes()
    //{
    //    Item cliente = null;
    //    List<Item> clientes = new List<Item>();
    //    var queryListarTodosClientes = @"SELECT 
    //                                         CodigoItem,
    //                                         Nome,
    //                                         CPF,
    //                                         SituacaoPagamentos
    //                                     FROM Items
    //                                     WHERE Funcionario = 'N'";

    //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
    //    {
    //        try
    //        {
    //            sqlConnection.Open();
    //        }
    //        catch (Exception e)
    //        {
    //            throw new Exception($"Falha ao conectar no banco de dados. Retorno: {e.Message}");
    //        }

    //        SqlCommand sqlCommand = new SqlCommand(queryListarTodosClientes, sqlConnection);
    //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

    //        if (sqlDataReader.HasRows)
    //        {
    //            while (sqlDataReader.Read())
    //            {
    //                cliente = new Item();
    //                cliente.CodigoItem = Convert.ToInt32(sqlDataReader["CodigoItem"].ToString());
    //                cliente.Nome = sqlDataReader["Nome"].ToString();
    //                cliente.CPF = sqlDataReader["CPF"].ToString();
    //                cliente.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
    //                clientes.Add(cliente);
    //            }
    //        }

    //        return clientes;
    //    }
    //}

    //public List<Item> ListarTodosFuncionarios()
    //{
    //    Item funcionario = null;
    //    List<Item> funcionarios = new List<Item>();
    //    var queryListarTodosFuncionarios = @"SELECT 
    //                                         CodigoItem,
    //                                         Nome,
    //                                         CPF,
    //                                         SituacaoPagamentos
    //                                     FROM Items
    //                                     WHERE Funcionario = 'Y'";

    //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
    //    {
    //        try
    //        {
    //            sqlConnection.Open();
    //        }
    //        catch (Exception e)
    //        {
    //            throw new Exception($"Falha ao conectar no banco de dados. Retorno: {e.Message}");
    //        }

    //        SqlCommand sqlCommand = new SqlCommand(queryListarTodosFuncionarios, sqlConnection);
    //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

    //        if (sqlDataReader.HasRows)
    //        {
    //            while (sqlDataReader.Read())
    //            {
    //                funcionario = new Item();
    //                funcionario.CodigoItem = Convert.ToInt32(sqlDataReader["CodigoItem"].ToString());
    //                funcionario.Nome = sqlDataReader["Nome"].ToString();
    //                funcionario.CPF = sqlDataReader["CPF"].ToString();
    //                funcionario.SituacaoPagamentos = sqlDataReader["SituacaoPagamentos"].ToString();
    //                funcionarios.Add(funcionario);
    //            }
    //        }

    //        return funcionarios;
    //    }
    //}

}
}
