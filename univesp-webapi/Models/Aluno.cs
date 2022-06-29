namespace univesp_webapi.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Int64 cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Observacoes { get; set; }
        public string? Foto { get; set; }
        public int Turma { get; set; }
        public int STATUS { get; set; }

    }
}
