using Funcionarios.Models.Dtos;
using System.Collections.Generic;

namespace Funcionarios.Models.Contracts.Repositories
{
    public interface IFuncionarioRepository
    {
        void Cadastrar(FuncionarioDto funcionario);
        List<FuncionarioDto> Listar();
        FuncionarioDto PesquisarId(string id);
        void Atualizar(FuncionarioDto funcionario);
        void Excluir(FuncionarioDto funcionario);
    }
}
