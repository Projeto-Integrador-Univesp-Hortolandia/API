namespace univesp_webapi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int TurmaId { get; set; }
        public int ProfessorId { get; set; }
        public string Postagem { get; set; }
        public string? Imagem { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int Tag { get; set; }
        public int Reacao { get; set; }
    }
}
