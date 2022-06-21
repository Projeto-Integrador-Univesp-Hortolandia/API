namespace API.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public Responsavel ResponsavelId { get; set; }
        public string Nome { get; set; }
        public Int64 RG { get; set; }
        public string Sexo { get; set; }
        public string Foto { get; set; }
        public string Observacao { get; set; }
        public int Status { get; set; }
    }
}
