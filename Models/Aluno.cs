namespace API.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public int ResponsavelId { get; set; }
        public string Nome { get; set; }
        public Int64 RG { get; set; }
        public char Sexo { get; set; }
        public string Foto { get; set; }
        public string Observacao { get; set; }
        public char Status { get; set; }
    }
}
