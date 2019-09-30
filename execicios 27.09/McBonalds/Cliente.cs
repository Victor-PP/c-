using System;

namespace McBonalds
{
    public class Cliente
    {

        //Atributos
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento {get;set;}

        // Construtor
        public Cliente(string Nome, string Telefone, string Email)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
    }
}