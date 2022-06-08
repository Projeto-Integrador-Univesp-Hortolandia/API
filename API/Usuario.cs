using System.Security.Principal;

namespace API;

public class Usuario
{
    public int UsuarioID { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; }
    
}