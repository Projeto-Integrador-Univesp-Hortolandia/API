﻿namespace univesp_webapi.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }
        public int STATUS { get; set; }
    }
}
