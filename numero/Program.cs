using System;

namespace numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string fdp;
            do{
                Console.WriteLine("digite o numero");
                numero = int.Parse(Console.ReadLine() );
                
                if (numero % 2 == 0){
                    Console.WriteLine( "o resultado é par" );
                }
                else {
                    Console.WriteLine( "o resultado é impar" );
                }
                Console.WriteLine( "quer jogar denovo? 1-sim // 0-nao");
                fdp= Console.ReadLine();
            }while ( fdp == "1");            
        }
    }
}
