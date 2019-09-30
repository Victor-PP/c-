using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 =0;
            int num2 = 0;
            string oper;

            Console.WriteLine("digite o primeiro numero:");
            num1 = int.Parse( Console.ReadLine());
            Console.WriteLine("digite o segundo numero:");
            num2 = int.Parse( Console.ReadLine());
            Console.WriteLine("qual o operador desjado?");
            oper = Console.ReadLine();
           
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }
    }
}
