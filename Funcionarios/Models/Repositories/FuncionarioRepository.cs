using Funcionarios.Models.Contracts.Contexts;
using Funcionarios.Models.Contracts.Repositories;
using Funcionarios.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Funcionarios.Models.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {

        private readonly IContextData _contextData;

        public FuncionarioRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        
        public void Atualizar(FuncionarioDto funcionario)
        {
            _contextData.AtualizarFuncionario(funcionario);

        }

        public void Cadastrar(FuncionarioDto funcionario)
        {
            funcionario.CPF = Convert.ToUInt64(funcionario.CPF).ToString(@"000\.000\.000\-00");
            funcionario.RG = Convert.ToUInt64(funcionario.RG).ToString(@"00\.000\.000\-0");
           
            _contextData.CadastrarFuncionario(funcionario);
        }

        public List<FuncionarioDto> Listar()
        {
           return _contextData.ListarFuncionario();
        }

        public FuncionarioDto PesquisarId(string id)
        {
            return _contextData.PesquisarFuncionarioPorId(id);
        }
       
        public void Excluir(string IdFunc, string id)
        {
            _contextData.ExcluirFuncionario(IdFunc, id);
        }
    }
}
