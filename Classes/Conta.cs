using System;
using DesafioBanco.Enum;

namespace DesafioBanco.Classes
{
    public class Conta
    {
        private TipoConta TipoConta {get; set;}
        
        private double Saldo {get; set;}

        private double Credito {get; set;}
        
        private string Nome   {get; set;}


        public Conta (TipoConta tipoConta, double saldo, double credito, string nome){
            this.TipoConta = tipoConta;
            this.Credito= credito;
            this.Saldo= saldo;
            this.Nome= nome;
        }


        public bool Sacar (double valorSaque){
                //validação de saldo 
                if(this.Saldo-valorSaque<(this.Credito*-1)){
                    Console.WriteLine("Saldo Insuficiente!");
                    return false;
                }

                this.Saldo-= valorSaque;
                Console.WriteLine($"Saldo Atual da Conta de {this.Nome} é {this.Saldo}");
                return true;
        }

        public void Depositar (double valorDeposito){
            this.Saldo += valorDeposito;
            Console.WriteLine($"Saldo Atual da Conta de {this.Nome} é {this.Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino){
               if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            } 
        }

         public override string ToString()
		{
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
			return retorno;
		}
    }
}