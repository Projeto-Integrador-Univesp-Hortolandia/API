using API.Models;
using Microsoft.EntityFrameworkCore;
namespace API.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<Alunos> Aluno { get; set; }
    public DbSet<Functionarios> Functionario { get; set; }
    public DbSet<Administrador> Adm { get; set; }
    public DbSet<Responsaveis> Responsavel { get; set; }
}