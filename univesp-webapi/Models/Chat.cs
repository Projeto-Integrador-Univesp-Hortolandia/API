namespace univesp_webapi.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public int ProfessorId { get; set; }
        public int ResponsavelId { get; set; }
        public ICollection<Mensagem> mensagem { get; set; }

    }
}
