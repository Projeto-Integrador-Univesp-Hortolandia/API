namespace API.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public Responsavel ResponsavelId { get; set; }
        public string Mensagem { get; set; }
        public Funcionario FuncionarioId { get; set; }
        public string Resposta { get; set; }
        public int Status { get; set; }
    }
}
