namespace Byte_Bank.modelo
{
    public class Cliente
    {
        // ATRIBUTOS 
        public string Cpf {get; set; }
        public string Nome {get; set; }
        public string Email {get; set; }
        public string Senha {get; set; }

        // CONSTRUTOR
        public Cliente(string Nome, string Cpf, string Email){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }
        public bool TrocarSenha(string senha){
            if((senha.Length > 6)&&(senha.Length < 16)){
                this.Senha = senha;
                return true;
            }else {
                return false;
            }
        }
    }
}