using System.Collections.Generic;

namespace univesp_webapi.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Ano { get; set; }
        public string? turma { get; set; }
        public string? Periodo { get; set; }
        public string? Sala { get; set; }
        public int STATUS { get; set; }
        public List<Aluno>? Alunos { get; set; } = new List<Aluno>();
    }
}
