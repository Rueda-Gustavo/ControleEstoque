using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Infra.Models
{
    public record Endereco
    {
        public Endereco(string rua, string coluna, string prateleira)
        {
            Rua = rua;
            Coluna = coluna;
            Prateleira = prateleira;
        }
        public string Rua { get; }
        public string Coluna { get; }
        public string Prateleira { get; }
    }
}
