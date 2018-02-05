using Lazer.LojaVirtual.Dominio.Entidades;
using System.Collections.Generic;

namespace Lazer.LojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }

        public Paginacao Paginacao { get; set; }
    }
}