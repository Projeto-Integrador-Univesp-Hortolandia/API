namespace API.Models
{
    public class Feed
    {
        public int Id { get; set; }
        public Turma TurmaId { get; set; }
        public Funcionario FuncionarioId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int Like { get; set; }
        public int Unlike { get; set; }
        public SuporteFeedFiles SuporteFiles { get; set; }
        public int Status { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}
