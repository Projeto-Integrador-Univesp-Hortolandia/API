using univesp_webapi.Models;

namespace univesp_webapi.Handle
{
    public class TurmaHandle
    { 
        public string Nome { get; set; }
        public string? Ano { get; set; }
        public string? turma { get; set; }
        public string? Periodo { get; set; }
        public string? Sala { get; set; }
        public int STATUS { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    }

    public class TurmaHandleList
    {
        public List<TurmaHandle> Turmas { get; set; } = new List<TurmaHandle>();
    }

    
}
