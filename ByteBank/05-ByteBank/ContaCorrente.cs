//using _04_ByteBank;

namespace _05_ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 200;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else

                    _saldo = value;
            }
        }

        //Sacar Valor 
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        //Depositar Valor
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        //Transferir Valor
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}