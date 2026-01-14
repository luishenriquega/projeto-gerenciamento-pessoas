using GerenciamentoDePessoas.Services;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDePessoas.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaService _pessoasService;

        public PessoaController(IPessoaService pessoasService)
        {
            _pessoasService = pessoasService;
        }
        public IActionResult Index()
        {
            var todosUsuarios = _pessoasService.BuscarTodos();
            return View();
        }
    }
}
