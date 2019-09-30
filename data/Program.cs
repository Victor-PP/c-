using System;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            Console.WriteLine("digite sua idade");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine ("sua idade em dias e" + idade = 365)
            Console.WriteLine("sua idade em meses e" + idade = 8760);
            Console.WriteLine("sua idade em horas e" + idade = 525600);
            Console.WriteLine("sua idade em semanas e" + idade = 216);
        }

        private static int NewMethod()
        {
            return 365;
        }
    }
}
