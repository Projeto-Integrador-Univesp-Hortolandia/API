namespace API.Models
{
    public class Administrador
    {
        public int AdministradorId { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public Int64 CPF { get; set; }
        public DateTime DataNasc { get; set; }

    }
}
