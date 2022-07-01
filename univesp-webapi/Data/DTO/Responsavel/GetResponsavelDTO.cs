using univesp_webapi.Models;
namespace univesp_webapi.Data.DTO.Responsavel
{
    public class GetResponsavelDTO
    {
        public string Nome { get; set; }
        public Int64 cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Observacao { get; set; }
        public string? Foto { get; set; }
        public int STATUS { get; set; }
        public int IsAdmin { get; set; }
        public List<Aluno> Alunos { get; set; }
    }
}
