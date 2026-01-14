using GerenciadorDePessoas.Models;
using GerenciamentoDePessoas.Models;
using GerenciamentoDePessoas.Repository;

namespace GerenciamentoDePessoas.Services
{
    public class PessoaService : IPessoaService
    {
        public List<Pessoa> BuscarTodos()
        {
            var pessoas = new PessoaRepository();
            var todosUsuarios = pessoas.BuscarTodos();

            return todosUsuarios;
        }
    }
}
