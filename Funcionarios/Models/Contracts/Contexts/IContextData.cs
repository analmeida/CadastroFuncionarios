using Funcionarios.Models.Dtos;
using System.Collections.Generic;

namespace Funcionarios.Models.Contracts.Contexts
{
    public interface IContextData
    {
        void CadastrarFuncionario(FuncionarioDto funcionario);
        List<FuncionarioDto> ListarFuncionario();
        FuncionarioDto PesquisarFuncionarioPorId(string id);
        void AtualizarFuncionario(FuncionarioDto funcionario);
        void ExcluirFuncionario(string id);
    }
}
