using Microsoft.AspNetCore.Mvc;
using Projeto2.GerenciaArquivos;
using Projeto2.Models;
using Projeto2.Repositorio.Contrato;

namespace Projeto2.Controllers
{
    public class LivrosController : Controller
    {
        private ILivrosRepositorio _livroRepositorio;

        public LivrosController(ILivrosRepositorio livroRepositorio)
        {
            _livroRepositorio = livroRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Livro livro, IFormFile file)
        {
            var Caminho = GerenciadorArquivo.CadastrarImagemProduto(file);

            livro.ImagemLivro = Caminho;

            _livroRepositorio.Cadastrar(livro);

            ViewBag.msg = "Cadastro Realizado";
            return View();
        }
    }
}
