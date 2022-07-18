using Funcionarios.Models.Contracts.Contexts;
using Funcionarios.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funcionarios.Models.Contexts
{
    public class ContextDataFake : IContextData
    {
        private static List<FuncionarioDto> funcionarios;

        public ContextDataFake()
        {
            funcionarios = new List<FuncionarioDto>();
            InitializeData();
        }

        public void AtualizarFuncionario(FuncionarioDto funcionario)
        {
            try
            {
                var objPesquisa = PesquisarFuncionarioPorId(funcionario.Id);
                funcionarios.Remove(objPesquisa);

                objPesquisa.Nome = funcionario.Nome;
                objPesquisa.CPF = funcionario.CPF;
                objPesquisa.RG = funcionario.RG;
                objPesquisa.OrgaoEmissor = funcionario.OrgaoEmissor;
                objPesquisa.TituloEleitor = funcionario.TituloEleitor;
                objPesquisa.CNH = funcionario.CNH;
                objPesquisa.Gestor = funcionario.Gestor;
                objPesquisa.CEP = funcionario.CEP;
                objPesquisa.Endereco = funcionario.Endereco;
                objPesquisa.Numero = funcionario.Numero;
                objPesquisa.Complemento = funcionario.Complemento;
                objPesquisa.Bairro = funcionario.Bairro;
                objPesquisa.Cidade = funcionario.Cidade;
                objPesquisa.Estado = funcionario.Estado;
                objPesquisa.PontoReferencia = funcionario.PontoReferencia;
                objPesquisa.FuncAtivo = funcionario.FuncAtivo;

                CadastrarFuncionario(objPesquisa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CadastrarFuncionario(FuncionarioDto funcionario)
        {
            try
            {
                funcionarios.Add(funcionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirFuncionario(string id)
        {
            try
            {
                var objPesquisa = PesquisarFuncionarioPorId(id);
                funcionarios.Remove(objPesquisa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FuncionarioDto> ListarFuncionario()
        {
            try
            {
                return funcionarios
                    .OrderBy(p => p.Nome)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FuncionarioDto PesquisarFuncionarioPorId(string id)
        {
            try
            {
                return funcionarios.FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitializeData()
        {
            var funcionario = new FuncionarioDto("José Luiz Silva", "01325476980", "07/05/1989", "SSP", "0923747234", "0213987219387", true, "01672131", "Rua dos Alpes", "24", "N/A", "Parque do Carmo", "São Bernardo", "São Paulo", "Subway", true);
            funcionarios.Add(funcionario);

            funcionario = new FuncionarioDto("José Luiz Silva e Silva", "01325006980", "07/09/1985", "SSP", "0823120034", "0678237219387", false, "01672131", "Rua dos Ipês", "59", "N/A", "Parque do Carmo", "São Bento", "Minas Gerais", "Praça", true);
            funcionarios.Add(funcionario);

            funcionario = new FuncionarioDto("José Luiz Silva Sauro", "01369086980", "20/04/1989", "SSP", "0955555534", "0213983333387", true, "01655431", "Rua dos Asteróides", "339", "N/A", "Parque Village", "Jordanópolis", "São Paulo", "Metrô", true);
            funcionarios.Add(funcionario);

            funcionario = new FuncionarioDto("Maria Justina", "44325476111", "11/04/1963", "SSP", "0923747234", "021355559387", false, "09972131", "Rua dos Esquilos", "678", "N/A", "Vila Triunfo", "Mauá", "São Paulo", "Parquinho", true);
            funcionarios.Add(funcionario);

            funcionario = new FuncionarioDto("Francisca Silva", "20325476653", "18/05/1975", "SSP", "3333747234", "0213987219387", true, "01545131", "Rua dos Arbustos", "1584", "N/A", "Parque do Carmo", "São Bento", "São Bernardo", "Escola", true);
            funcionarios.Add(funcionario);


        }
    }
}
