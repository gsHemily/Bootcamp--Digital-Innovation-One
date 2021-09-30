using System;

namespace BankDio
{
    class ContaBancaria
    {
        private TipoConta TipoConta { get; set; }
        private string Name { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }


        public ContaBancaria(TipoConta tipoConta, string name, double saldo, double credito)
        {
            TipoConta = tipoConta;
            Name = name;
            Saldo = saldo;
            Credito = credito;

        }
        public bool Sacar(double ValorSaque) /*Para validação de slado*/
        {
            if (this.Saldo - ValorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            this.Saldo -= Saldo - ValorSaque;
            Console.WriteLine("Valor da conta é:" + Saldo);
            return true;
        }

        public void Depositar(double ValorDeposito)
        {
            Saldo += ValorDeposito;
            Console.WriteLine("Saldo atualizado: " + Saldo);
        }
        public void Transferir(double valorTransferencia, ContaBancaria contaDestino)
        {
            if (this.Sacar(valorTransferencia))
                contaDestino.Depositar(valorTransferencia);
        }
        public override string ToString()
        {
            string retorno = " ";
            retorno += "Tipo de conta:" + this.TipoConta + " | ";
            retorno += "Titular:" + this.Name + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Credito: " + this.Credito + " | ";
            return retorno;
        }







    }
}































