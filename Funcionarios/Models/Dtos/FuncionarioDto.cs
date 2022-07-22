using Funcionarios.Models.Entidades;

namespace Funcionarios.Models.Dtos
{
    public class FuncionarioDto : EntidadeBase
    {
        
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string OrgaoEmissor { get; set; }
        public string TituloEleitor { get; set; }
        public string CNH { get; set; }
        public bool Gestor { get; set; }
        public bool FuncAtivo { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string PontoReferencia { get; set; }
        

        public FuncionarioDto()
        {

        }
        public FuncionarioDto(string id, string nome, string cPF, string rG, string orgaoEmissor, string tituloEleitor, string cNH, bool gestor, bool funcAtivo, string IdFunc, string IdDados, string cEP, string endereco, string numero, string complemento, string bairro, string cidade, string estado, string pontoReferencia)
        : this(nome, cPF, rG, orgaoEmissor, tituloEleitor, cNH, gestor, funcAtivo, cEP, endereco, numero, complemento, bairro, cidade, estado, pontoReferencia)
        {
            this.Id = id;
            this.Id = IdDados;
            this.IdFunc = IdFunc;
        }

        public FuncionarioDto(string nome, string cPF, string rG, string orgaoEmissor, string tituloEleitor, string cNH, bool gestor, bool funcAtivo, string cEP, string endereco, string numero, string complemento, string bairro, string cidade, string estado, string pontoReferencia)
        {
            this.Nome = nome;
            this.CPF = cPF;
            this.RG = rG;
            this.OrgaoEmissor = orgaoEmissor;
            this.TituloEleitor = tituloEleitor;
            this.CNH = cNH;
            this.Gestor = gestor;
            this.CEP = cEP;
            this.Endereco = endereco;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.PontoReferencia = pontoReferencia;
            this.FuncAtivo = funcAtivo;
        }


    }
}
