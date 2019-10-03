using System;
namespace conta_corrente.modelo2
{
    public class ContaCorrente
    {
         // ATRIBUTOS 
        public string Titular {get; set; }
        public int Agencia {get; set; }
        public int Numero {get; set; }
        public double Saldo {get; set; }
        
        // construtor
        public ContaCorrente( int Numero, int Agencia,string Titular){
            this.Numero = Numero;
            this.Agencia = Agencia;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }        
    }
}