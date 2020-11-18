//using _04_ByteBank;

namespace _04_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 200;

        //Sacar Valor 
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        //Depositar Valor
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        //Transferir Valor
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}