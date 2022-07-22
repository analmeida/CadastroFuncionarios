using Funcionarios.Models.Contracts.Contexts;
using Funcionarios.Models.Contracts.Repositories;
using Funcionarios.Models.Dtos;
using Funcionarios.Models.Enums;
using Funcionarios.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Funcionarios.Models.Contexts
{
    public class ContextDataSqlServer : IContextData
    {
        private readonly SqlConnection _connection = null;

        public ContextDataSqlServer(IConnectionManager connectionManager)
        {
            _connection = connectionManager.GetConnection();
        }
        public void AtualizarFuncionario(FuncionarioDto funcionario)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.ATUALIZAR_FUNCIONARIO);

                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = funcionario.Id;
                command.Parameters.Add("@Nome", System.Data.SqlDbType.VarChar).Value = funcionario.Nome;
                command.Parameters.Add("@CPF", System.Data.SqlDbType.VarChar).Value = funcionario.CPF;
                command.Parameters.Add("@RG", System.Data.SqlDbType.VarChar).Value = funcionario.RG;
                command.Parameters.Add("@OrgaoEmissor", System.Data.SqlDbType.VarChar).Value = funcionario.OrgaoEmissor;
                command.Parameters.Add("@TituloEleitor", System.Data.SqlDbType.VarChar).Value = funcionario.TituloEleitor;
                command.Parameters.Add("@CNH", System.Data.SqlDbType.VarChar).Value = funcionario.CNH;
                command.Parameters.Add("@Gestor", System.Data.SqlDbType.Bit).Value = funcionario.Gestor;
                command.Parameters.Add("@FuncAtivo", System.Data.SqlDbType.Bit).Value = funcionario.FuncAtivo;
                command.ExecuteNonQuery();
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();


                _connection.Open();
                var query1 = SqlManager.GetSql(TSql.ATUALIZAR_FUNCIONARIO2);
                var command1 = new SqlCommand(query1, _connection);
                command1.Parameters.Add("@IdFunc", System.Data.SqlDbType.VarChar).Value = funcionario.IdFunc;
                command1.Parameters.Add("@IdDados", System.Data.SqlDbType.VarChar).Value = funcionario.Id;
                command1.Parameters.Add("@CEP", System.Data.SqlDbType.VarChar).Value = funcionario.CEP;
                command1.Parameters.Add("@Endereco", System.Data.SqlDbType.VarChar).Value = funcionario.Endereco;
                command1.Parameters.Add("@Numero", System.Data.SqlDbType.VarChar).Value = funcionario.Numero;
                command1.Parameters.Add("@Complemento", System.Data.SqlDbType.VarChar).Value = funcionario.Complemento;
                command1.Parameters.Add("@Bairro", System.Data.SqlDbType.VarChar).Value = funcionario.Bairro;
                command1.Parameters.Add("@Cidade", System.Data.SqlDbType.VarChar).Value = funcionario.Cidade;
                command1.Parameters.Add("@Estado", System.Data.SqlDbType.VarChar).Value = funcionario.Estado;
                command1.Parameters.Add("@PontoReferencia", System.Data.SqlDbType.VarChar).Value = funcionario.PontoReferencia;
                command1.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void CadastrarFuncionario(FuncionarioDto funcionario)
        {
            try { 
            _connection.Open();
            var query = SqlManager.GetSql(TSql.CADASTRAR_FUNCIONARIO);

            var command = new SqlCommand(query, _connection);

            command.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = funcionario.Id;
            command.Parameters.Add("@Nome", System.Data.SqlDbType.VarChar).Value = funcionario.Nome;
            command.Parameters.Add("@CPF", System.Data.SqlDbType.VarChar).Value = funcionario.CPF;
            command.Parameters.Add("@RG", System.Data.SqlDbType.VarChar).Value = funcionario.RG;
            command.Parameters.Add("@OrgaoEmissor", System.Data.SqlDbType.VarChar).Value = funcionario.OrgaoEmissor;
            command.Parameters.Add("@TituloEleitor", System.Data.SqlDbType.VarChar).Value = funcionario.TituloEleitor;
            command.Parameters.Add("@CNH", System.Data.SqlDbType.VarChar).Value = funcionario.CNH;
            command.Parameters.Add("@Gestor", System.Data.SqlDbType.Bit).Value = funcionario.Gestor;
            command.Parameters.Add("@FuncAtivo", System.Data.SqlDbType.Bit).Value = funcionario.FuncAtivo;
            command.ExecuteNonQuery();

                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();


            _connection.Open();
            var query1 = SqlManager.GetSql(TSql.CADASTRAR_FUNCIONARIO2);           
            var command1 = new SqlCommand(query1, _connection);
                command1.Parameters.Add("@IdFunc", System.Data.SqlDbType.VarChar).Value = funcionario.IdFunc;
                command1.Parameters.Add("@IdDados", System.Data.SqlDbType.VarChar).Value = funcionario.Id;
                command1.Parameters.Add("@CEP", System.Data.SqlDbType.VarChar).Value = funcionario.CEP;
                command1.Parameters.Add("@Endereco", System.Data.SqlDbType.VarChar).Value = funcionario.Endereco;
                command1.Parameters.Add("@Numero", System.Data.SqlDbType.VarChar).Value = funcionario.Numero;
                command1.Parameters.Add("@Complemento", System.Data.SqlDbType.VarChar).Value = funcionario.Complemento;
                command1.Parameters.Add("@Bairro", System.Data.SqlDbType.VarChar).Value = funcionario.Bairro;
                command1.Parameters.Add("@Cidade", System.Data.SqlDbType.VarChar).Value = funcionario.Cidade;
                command1.Parameters.Add("@Estado", System.Data.SqlDbType.VarChar).Value = funcionario.Estado;
                command1.Parameters.Add("@PontoReferencia", System.Data.SqlDbType.VarChar).Value = funcionario.PontoReferencia;

                command1.ExecuteNonQuery();
                               

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
            }
        }

        public void ExcluirFuncionario(FuncionarioDto funcionario)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.EXCLUIR_ENDERECO);
                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@IdFunc", System.Data.SqlDbType.VarChar).Value = funcionario.IdFunc;
                command.ExecuteNonQuery();
                    if (_connection.State == ConnectionState.Open)
                        _connection.Close();

                _connection.Open();
                var query1 = SqlManager.GetSql(TSql.EXCLUIR_FUNCIONARIO);
                var command1 = new SqlCommand(query1, _connection);
                command1.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = funcionario.Id;
                command1.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public List<FuncionarioDto> ListarFuncionario()
        {
            var funcionarios = new List<FuncionarioDto>();

            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_FUNCIONARIO);

                var command = new SqlCommand(query, _connection);

                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach(DataRow item in rows)
                {
                    var colunas = item.ItemArray;
                    var Id = colunas[0].ToString();
                    var Nome = colunas[1].ToString();
                    var CPF = colunas[2].ToString();
                    var RG = colunas[3].ToString();
                    var OrgaoEmissor = colunas[4].ToString();
                    var TituloEleitor = colunas[5].ToString();
                    var CNH = colunas[6].ToString();
                    var Gestor = (bool)colunas[7];
                    var FuncAtivo = (bool)colunas[8];
                    var IdFunc = colunas[9].ToString();
                    var IdDados = colunas[10].ToString();
                    var CEP = colunas[11].ToString();
                    var Endereco = colunas[12].ToString();
                    var Numero = colunas[13].ToString();
                    var Complemento = colunas[14].ToString();
                    var Bairro = colunas[15].ToString();
                    var Cidade = colunas[16].ToString();
                    var Estado = colunas[17].ToString();
                    var PontoReferencia = colunas[18].ToString();
                    

                    var funcionario = new FuncionarioDto(Id, Nome, CPF, RG, OrgaoEmissor, TituloEleitor, CNH, Gestor, FuncAtivo, IdFunc, IdDados, CEP, Endereco, Numero, Complemento, Bairro, Cidade, Estado, PontoReferencia);
                    funcionarios.Add(funcionario);
                }

                adapter = null;
                dataset = null;
                return funcionarios;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public FuncionarioDto PesquisarFuncionarioPorId(string id)
        {
            
            try
            {
                FuncionarioDto funcionario = null;

                var query = SqlManager.GetSql(TSql.PESQUISAR_FUNCIONARIO);

                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
                command.Parameters.Add("@IdDados", SqlDbType.VarChar).Value = id;
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);

                var rows = dataset.Tables[0].Rows;

                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var Id = colunas[0].ToString();
                    var Nome = colunas[1].ToString();
                    var CPF = colunas[2].ToString();
                    var RG = colunas[3].ToString();
                    var OrgaoEmissor = colunas[4].ToString();
                    var TituloEleitor = colunas[5].ToString();
                    var CNH = colunas[6].ToString();
                    var Gestor = (bool)colunas[7];
                    //bool ehChefe = string.IsNullOrEmpty(Gestor) || Gestor == 0 ? false : true ;
                    bool FuncAtivo = (bool)colunas[8];
                    var IdFunc2 = colunas[9].ToString();
                    var IdDados = colunas[10].ToString();
                    var CEP = colunas[11].ToString();
                    var Endereco = colunas[12].ToString();
                    var Numero = colunas[13].ToString();
                    var Complemento = colunas[14].ToString();
                    var Bairro = colunas[15].ToString();
                    var Cidade = colunas[16].ToString();
                    var Estado = colunas[17].ToString();
                    var PontoReferencia = colunas[18].ToString();


                    funcionario = new FuncionarioDto(Id, Nome, CPF, RG, OrgaoEmissor, TituloEleitor, CNH, Gestor, FuncAtivo, IdFunc2, IdDados, CEP, Endereco, Numero, Complemento, Bairro, Cidade, Estado, PontoReferencia);
                    
                }

                adapter = null;
                dataset = null;
                return funcionario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
