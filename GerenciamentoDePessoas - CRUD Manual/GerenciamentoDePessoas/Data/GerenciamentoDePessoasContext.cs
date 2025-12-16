using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDePessoas.Data
{
    public class GerenciamentoDePessoasContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
