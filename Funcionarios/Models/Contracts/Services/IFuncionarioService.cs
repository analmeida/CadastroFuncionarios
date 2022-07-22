﻿using Funcionarios.Models.Dtos;
using System.Collections.Generic;

namespace Funcionarios.Models.Contracts.Services
{
    public interface IFuncionarioService
    {
        void Cadastrar(FuncionarioDto funcionario);
        List<FuncionarioDto> Listar();
        FuncionarioDto PesquisarId(string id);
        void Atualizar(FuncionarioDto funcionario);
        void Excluir(string IdFunc, string id);
    }
}
