using GerenciadorDePessoas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoDePessoas.Data
{
    public class GerenciamentoDePessoasContext : DbContext
    {
        public GerenciamentoDePessoasContext(DbContextOptions<GerenciamentoDePessoasContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
