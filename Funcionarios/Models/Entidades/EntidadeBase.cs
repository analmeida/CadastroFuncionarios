using System;

namespace Funcionarios.Models.Entidades
{
    public abstract class EntidadeBase
    {
        public string Id { get; set; }
        public string IdFunc { get; set; }
        public string IdDados { get; set; }
        public EntidadeBase()
        {
            Id = Guid.NewGuid().ToString();
            IdFunc = Guid.NewGuid().ToString();
        }
    }
}
