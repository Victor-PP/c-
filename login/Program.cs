using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string senha;
            
            Console.WriteLine("usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine("senha: ");
            senha = Console.ReadLine();

            if((usuario== "admin")&&( senha== "admin")){
                Console.WriteLine("bem vindo admin");
            } else {
                Console.WriteLine("ola usuario");
            }
        }
    }
}
