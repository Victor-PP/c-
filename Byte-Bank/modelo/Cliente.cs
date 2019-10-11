namespace Byte_Bank.modelo
{
    public class Cliente
    {
        private string _cpf;
        private string _nome;
        private string _email;
        private string _senha;
        public string Cpf{
            get{return _cpf;}
            set{_cpf = value;}
        }
        public string Nome{
            get{return _nome;}
            set{_nome = value;}
        }
        public string Email{
            get{return _email;}
            set{_email = value;}
        }
        public string Senha{
            get{return _senha;}
            set{}
        }
        public Cliente(string Nome, string Cpf, string Email){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        public bool TrocaSenha(string senha){
            if((senha.Length > 6) && (senha.Length < 16)){
            this.Senha = senha;
            return true;
            } else {
            return false;
            }
        }
    }
}
