using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = 2019;
            int anoNasc = 0;
            int idade;

            Console.WriteLine("qual o ano de nascimento?");
            anoNasc = int.Parse(Console.ReadLine());
            idade = anoAtual - anoNasc;

            Console.WriteLine (" sua idade atual e de:" + idade + "anos");
            if(idade <= 2) {
                Console.WriteLine("voce e uma recem nascido");
            } else if ((idade >=3) && (idade <= 11)){
                Console.WriteLine( "voce e uma criança");
            } else if ((idade >= 12) && (idade <= 19)){
                Console.WriteLine("voce e um adolescente");
            } else if ((idade >=20) && (idade <=65)){
                Console.WriteLine("voce e um adulto");
            } else if (idade > 65){
                Console.WriteLine("voce e idoso");
            }
        }
    }
}