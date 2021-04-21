namespace DIO.Bank
{
    public class Conta
    {
        
        @references
        private TipoConta TipoConta{get; set;}
        @references
        private double Saldo{get; set;}
        @references
        private double Credito{get; set;}
        @references
        private string Nome{get; set;}

        @references
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome) 
        {
        this.TipoConta = tipoConta;
        this.Saldo = saldo;
        this.Credito = credito;
        this.Nome = nome;
   
        }
        public bool Sacar(double valorSaque) {
            
        }
    }
}