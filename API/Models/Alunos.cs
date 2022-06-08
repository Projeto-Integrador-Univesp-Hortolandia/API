namespace API.Models;

public class Alunos
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public DateTime DataNascimento { get; set; }
    public Int64 RG { get; set; }
    public string Endereco { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }
    public Int64 Telefone { get; set; }
    public int ResponsavelID { get; set; }
}