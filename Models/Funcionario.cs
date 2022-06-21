namespace API.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public int AdmId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public Int64 CPF { get; set; }
        public string Senha { get; set; }
        public char Sexo { get; set; }
        public string Foto { get; set; }
        public int Status { get; set; }
    }
}
