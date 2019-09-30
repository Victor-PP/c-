using System;

namespace tabuada_do_5
{
    class Program
    {
        static void Main(string[] args)
        {
             for (int i=5; i <= 50; i+=5) {
                for (int j=1; j<=10; j++){
                Console.Write($"{j} * {i} = {j*i} \t");
                }
                Console.WriteLine();   
            }
        }
    }
}
