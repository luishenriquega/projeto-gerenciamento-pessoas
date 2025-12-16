using GerenciadorDePessoas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciamentoDePessoas.Controllers
{
    [Route("Usuario")]
    public class PessoaController : Controller
    {
        [Route("Inicio")]
        public IActionResult Index()
        {
            ViewBag.Cadastro = TempData["SucessoCriacao"];
            return View();
        }
        [Route("Detalhes/{id:int}")]
        public IActionResult DetalhesUsuario(int id)
        {
            ViewData["TextoDescrição"] = "Texto da tela de descrição.";
            ViewData["DataAtual"] = DateTime.Now;

            TempData["SucessoRedicionamento"] = " O redirecionamento foi um sucesso.";

            var listaUsuario = new List<Pessoa>();
            listaUsuario.Add(new Pessoa(1, "Pedro", "Silva", DateTime.Now));
            listaUsuario.Add(new Pessoa(1, "Maria", "Silva", DateTime.Now));
            listaUsuario.Add(new Pessoa(1, "Rosa", "Silva", DateTime.Now));
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("BuscarPorUrl")]
        public IActionResult BuscarPorUrl(string nome, string sobrenome)
        {
            var listaUsuario = new List<Pessoa>();
            listaUsuario.Add(new Pessoa(1, "Pedro", "Silva", DateTime.Now));
            listaUsuario.Add(new Pessoa(1, "Maria", "Silva", DateTime.Now));
            listaUsuario.Add(new Pessoa(1, "Rosa", "Silva", DateTime.Now));

            Pessoa pessoaSelecionada = listaUsuario.FirstOrDefault(n => n.Nome == nome && n.Sobrenome == sobrenome);


            return View(pessoaSelecionada);
        }
        [HttpGet]
        [Route("CriarUsuario")]
        public IActionResult CriarUsuario()
        {
            return View();
        }
        [HttpPost]
        [Route("CriarUsuario")]
        public IActionResult CriarUsuario(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                TempData["SucessoCriacao"] = $"O usuário {pessoa.Nome} {pessoa.Sobrenome} foi criado com sucesso!";
                return RedirectToAction("Index");
            }
            
            return View(pessoa);
        }

     
    }
}