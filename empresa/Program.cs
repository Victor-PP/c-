using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario = 0;

            Console.WriteLine("digite seu salario");
            salario = int.Parse(Console.ReadLine ());

            if( salario < 500){
                Console.WriteLine("seu salario com reajuste" + (salario * 30 / 100 + salario) );
            }
            else {
                Console.WriteLine("seu salario é superior ou igual a 500");
                
            }
        }
    }
}
