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
                    sql = "insert into ApiFuncionarios (Id, Nome, CPF, RG, OrgaoEmissor, TituloEleitor, CNH, Gestor, CEP, Endereco, Numero, Complemento, Bairro, Cidade, Estado, PontoReferencia, FuncAtivo) values (@Id, @Nome, @CPF, @RG, @OrgaoEmissor, @TituloEleitor, @CNH, @Gestor, @CEP, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @PontoReferencia, @FuncAtivo)";
                    break;

                case TSql.LISTAR_FUNCIONARIO:
                    sql = "select Id, Nome, CPF, RG, OrgaoEmissor, TituloEleitor, CNH, Gestor, CEP, Endereco, Numero, Complemento, Bairro, Cidade, Estado, PontoReferencia, FuncAtivo from ApiFuncionarios order by nome";
                    break;

                case TSql.PESQUISAR_FUNCIONARIO:
                    sql = "select Id, Nome, CPF, RG, OrgaoEmissor, TituloEleitor, CNH, Gestor, CEP, Endereco, Numero, Complemento, Bairro, Cidade, Estado, PontoReferencia, FuncAtivo from ApiFuncionarios where Id = @id";
                    break;

                case TSql.ATUALIZAR_FUNCIONARIO:
                    sql = "update ApiFuncionarios set Nome = @Nome, CPF = @CPF, RG = @RG, OrgaoEmissor = @OrgaoEmissor, TituloEleitor = @TituloEleitor, CNH = @CNH, Gestor = @Gestor, CEP = @CEP, Endereco = @Endereco, Numero = @Numero, Complemento = @Complemento, Bairro = @Bairro, Cidade = @Cidade, Estado = Estado, PontoReferencia = @PontoReferencia, FuncAtivo = @FuncAtivo from ApiFuncionarios where id = @Id";
                    break;

                case TSql.EXCLUIR_FUNCIONARIO:
                    sql = "delete from ApiFuncionarios where Id = @Id";
                    break;
            }


            return sql;
        }
    }
}
