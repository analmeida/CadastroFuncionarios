using Funcionarios.Models.Contracts.Services;
using Funcionarios.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Funcionarios.Controllers
{    
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioService _funcionarioService;
        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;   
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            try
            {
                var funcionarios = _funcionarioService.Listar();
                return View(funcionarios);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Nome, CPF, RG, OrgaoEmissor, TituloEleitor, CNH, Gestor, FuncAtivo, CEP, Endereco, Numero, Complemento, Bairro, Cidade, Estado, PontoReferencia")]FuncionarioDto funcionario)
        {
            try
            {
                _funcionarioService.Cadastrar(funcionario);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public IActionResult Edit(string Id)
        {
            if (string.IsNullOrEmpty(Id))
               return NotFound();

            var funcionario = _funcionarioService.PesquisarId(Id);

            if (funcionario == null)
                return NotFound();
            
            return View(funcionario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id, Nome, CPF, RG, OrgaoEmissor, TituloEleitor, CNH, Gestor, FuncAtivo, IdFunc, IdDados, CEP, Endereco, Numero, Complemento, Bairro, Cidade, Estado, PontoReferencia")] FuncionarioDto funcionario)
        {
            if (string.IsNullOrEmpty(funcionario.Id))
                return NotFound();

            try
            {
                _funcionarioService.Atualizar(funcionario);
                return RedirectToAction("List");
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        public IActionResult Details(string? id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var funcionario = _funcionarioService.PesquisarId(id);

            if (funcionario == null)
                return NotFound();

            return View(funcionario);
        }
        public IActionResult Delete(string? id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var funcionario = _funcionarioService.PesquisarId(id);
       
            if (funcionario == null)
                return NotFound();

            return View(funcionario);
        }

        [HttpPost]
        public IActionResult Delete([Bind("Id, IdFunc")] FuncionarioDto funcionario)
        {            
                if(funcionario.Gestor == null || funcionario.Gestor == true || funcionario.Gestor == false?  false:true)
                _funcionarioService.Excluir(funcionario);
                return RedirectToAction("List");            

        }
    }

}
