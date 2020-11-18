//using _04_ByteBank;

using System;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeComprasCriadas { get; private set; }
        public Cliente Titular { get; set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidos { get; private set; }
        public int Numero { get; }
        public int Agencia { get; }

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

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0." , nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento número deve ser maior que 0." , nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeComprasCriadas++;
            TaxaOperacao = 30 / TotalDeComprasCriadas;
        }

        //Sacar Valor 
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            else
            {
                _saldo -= valor;
            }
        }

        //Depositar Valor
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        //Transferir Valor
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }
    }

}