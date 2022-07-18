using Funcionarios.Models.Contracts.Repositories;
using Funcionarios.Models.Contracts.Services;
using Funcionarios.Models.Dtos;
using System;
using System.Collections.Generic;

namespace Funcionarios.Models.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;

        }

        public void Atualizar(FuncionarioDto funcionario)
        {
            try
            {
                _funcionarioRepository.Atualizar(funcionario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(FuncionarioDto funcionario)
        {
            try
            {
                 _funcionarioRepository.Cadastrar(funcionario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FuncionarioDto> Listar()
        {
            try 
            {
                return _funcionarioRepository.Listar();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public FuncionarioDto PesquisarId(string Id)
        {
            try
            {
                return _funcionarioRepository.PesquisarId(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(string id)
        {
            try
            {
                _funcionarioRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
