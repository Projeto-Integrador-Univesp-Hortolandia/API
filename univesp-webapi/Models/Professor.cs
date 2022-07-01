namespace univesp_webapi.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Int64 cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public string? Registro { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string? Foto { get; set; }
        public int STATUS { get; set; }
        public int IsAdmin { get; set; }

    }
}
