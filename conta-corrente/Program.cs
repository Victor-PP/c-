using System;
using conta_corrente.modelo2;
namespace conta_corrente
{
    class Program
    {
        static void Main(string[] args)
        {
            // clas contacorrente
            System.Console.WriteLine("conta corrente");
            System.Console.WriteLine();
            System.Console.Write("titular: ");
            string Titular = Console.ReadLine();
            System.Console.Write("agencia: ");
            int Agencia = int.Parse(Console.ReadLine());
            System.Console.Write("numero: ");
            int Numero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("saldo: ");
            double saldo = double.Parse(Console.ReadLine());

            bool saldovalido = false;
            double saldo;
            do{
                System.Console.Write("digite o saldo: ");
                if(saldo >= 0){
                    saldovalido = true;
                }else{
                    System.Console.WriteLine("o saldo nao pode ser negativo");
                }
            }while(!saldovalido)
            ContaCorrente conta1 = new ContaCorrente ()
            conta1.Saldo = saldo;
        }
    }
}
