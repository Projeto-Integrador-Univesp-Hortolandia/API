using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Administrador> Adminstradores { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Feed> Feed { get; set; }
        public DbSet<SuporteFeedFiles> SuporteFiles { get; set; };
    }
}
