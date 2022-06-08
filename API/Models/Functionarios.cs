namespace API.Models;

public class Functionarios
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Login { get; set; }
    public char Status { get; set; }
    public char IsAdmin { get; set; }
}