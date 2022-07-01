namespace univesp_webapi.Models
{
    public class Responsavel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Int64 cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Observacao { get; set; }
        public string? Foto { get; set; }
        public int STATUS { get; set; }
        public int IsAdmin { get; set; }
    }
}
