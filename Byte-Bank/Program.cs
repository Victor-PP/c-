using System;
using Byte_Bank.modelo;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // class cliente
            System.Console.WriteLine("cadastro de cliente");
            System.Console.WriteLine();
            System.Console.Write("nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("cpf: ");
            string cpf = Console.ReadLine();
            System.Console.Write("email: ");
            string email = Console.ReadLine();
            
            Cliente cliente1 = new Cliente(nome, cpf, email);

            bool senhaok = false;
            do{
                System.Console.Write("digite a senha: ");
                string senha = Console.ReadLine();
                if(!senhaok){
                    System.Console.WriteLine("senha nao atende aos requisitos");
                } else{
                    System.Console.WriteLine("senha trocada com sucesso");
                }
            }while(!senhaok);
            
        }
    }
}
