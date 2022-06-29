namespace univesp_webapi.Handle
{
    public class AlunoHandle
    {
        public string Nome { get; set; }
        public Int64 cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Observacoes { get; set; }
        public string? Foto { get; set; }
        public int Turma { get; set; }
        public int ResponsavelId { get; set; }
        public int STATUS { get; set; }
    }

    public class AlunoHandleList
    {
        public List<AlunoHandle> Aluno { get; set; }
    }    
}
