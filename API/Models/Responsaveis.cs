namespace API.Models;

public class Responsaveis
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public Int64 CPF { get; set; }
    public Int64 Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
}