using Funcionarios.Models.Enums;

namespace Funcionarios.Models.Repositories
{
    public class SqlManager
    {
        public static string GetSql(TSql tsql)
        {
            var sql = "";

            switch (tsql)
            {
                case TSql.CADASTRAR_FUNCIONARIO:
                    sql = "insert into funcionariosDados (Id, Nome, CPF, RG, OrgaoEmissor, TituloEleitor, CNH, Gestor, FuncAtivo) values (@Id, @Nome, @CPF, @RG, @OrgaoEmissor, @TituloEleitor, @CNH, @Gestor, @FuncAtivo)";
                    break;

                case TSql.CADASTRAR_FUNCIONARIO2:
                    sql = "insert into funcionariosEndereco (IdFunc, IdDados, CEP, Endereco, Numero, Complemento, Bairro, Cidade, Estado, PontoReferencia) values (@IdFunc, @IdDados, @CEP, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @PontoReferencia)";
                    break;

                case TSql.LISTAR_FUNCIONARIO:
                    sql = "SELECT * FROM funcionariosDados FULL OUTER JOIN funcionariosEndereco ON funcionariosDados.id = funcionariosEndereco.IdDados ORDER BY nome";
                    break;

                case TSql.PESQUISAR_FUNCIONARIO:
                    sql = "SELECT * FROM funcionariosDados FULL OUTER JOIN funcionariosEndereco ON funcionariosDados.id = funcionariosEndereco.IdDados where Id = @id";
                    break;

                case TSql.ATUALIZAR_FUNCIONARIO:
                    sql = "update funcionariosDados set Nome = @Nome, CPF = @CPF, RG = @RG, OrgaoEmissor = @OrgaoEmissor, TituloEleitor = @TituloEleitor, CNH = @CNH, Gestor = @Gestor, FuncAtivo = @FuncAtivo from funcionariosDados where id = @Id";
                    break;

                case TSql.ATUALIZAR_FUNCIONARIO2:
                    sql = "update funcionariosEndereco set CEP = @CEP, Endereco = @Endereco, Numero = @Numero, Complemento = @Complemento, Bairro = @Bairro, Cidade = @Cidade, Estado = Estado, PontoReferencia = @PontoReferencia from funcionariosEndereco where IdDados = @IdDados";
                    break;

                case TSql.EXCLUIR_FUNCIONARIO:
                    sql = "delete from funcionariosDados where Id = @Id";
                    break;

                case TSql.EXCLUIR_ENDERECO:                    
                    sql = "delete from funcionariosEndereco where IdFunc = @IdFunc";
                    break;
            }


            return sql;
        }
    }
}
