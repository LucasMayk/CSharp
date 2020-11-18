using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Mayk";
            cliente.CPF = "345.345.566-76";
            cliente.Profisao = "Programador Web";

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            
            Console.ReadLine();
        }
    }
}
