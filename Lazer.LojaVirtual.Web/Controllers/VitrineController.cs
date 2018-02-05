using Lazer.LojaVirtual.Dominio.Repositorio;
using Lazer.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lazer.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        // GET: Vitrine
        private ProdutosRepositorio _repositorio;

        public int ProdutosPorPagina = 3; // poder ser definido no web config or criar um enum

        // GET: Vitrine
        public ViewResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

            ProdutosViewModel model = new ProdutosViewModel
            {

                Produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina),

                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _repositorio.Produtos.Count()
                }
            };

            return View(model);
        }
    }
}