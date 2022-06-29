using univesp_webapi.Models;

namespace univesp_webapi.Handle
{
    public class ProfessorHandle
    { 
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string? Foto { get; set; }
        public int STATUS { get; set; }
        public int TurmaId { get; set; }
        public List<Turma> Turmas { get; set; }
    }

    public class ProfessorHandleList
    {
        public List<ProfessorHandle> professor { get; set; }
    }
}
