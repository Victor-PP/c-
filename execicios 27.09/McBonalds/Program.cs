using System;

namespace McBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Alexandre", "55 11 9876-5432","alexandre@gmail.com");

            Console.WriteLine("nome:" + cliente1.Nome);
            Console.WriteLine("telefone: " + cliente1.Telefone);
            Console.WriteLine("email: " + cliente1.Email);

        }
    }
}
