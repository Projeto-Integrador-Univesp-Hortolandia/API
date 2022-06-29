using Microsoft.EntityFrameworkCore;
using univesp_webapi.Models;

namespace univesp_webapi.Data
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Responsavel> Responsavels { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<Tag> Tags { get; set; }
        
    }
}
