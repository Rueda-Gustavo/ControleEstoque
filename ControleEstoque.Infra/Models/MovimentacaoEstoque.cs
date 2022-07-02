using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Infra.Models
{
    public enum TipoMovimentacao
    {
        Entrada, 
        Saida
    }
    public class MovimentacaoEstoque
    {
        public int Id { get; set; }
        public Endereco Endereco { get; set; }
        public Produto Produto { get; set; }  
        public TipoMovimentacao Tipo { get; set; }
        public decimal Quantidade { get; set; }
        public string Descricao { get; set; }
    }
}
