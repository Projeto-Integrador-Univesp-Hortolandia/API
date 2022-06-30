using univesp_webapi.Models;

namespace univesp_webapi.Data.DTO.Turmas
{
    public class GetTurmaDTO
    {
        public string Nome { get; set; }
        public string? Ano { get; set; }
        public string? turma { get; set; }
        public string? Periodo { get; set; }
        public string? Sala { get; set; }
        public int STATUS { get; set; }
        public int ProfessorId { get; set; }
        public List<Aluno>? Alunos { get; set; }
    }
}
