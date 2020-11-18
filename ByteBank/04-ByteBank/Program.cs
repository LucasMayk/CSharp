using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente maria = new Cliente();

            //maria.nome = "Maria";
            //maria.profisao = "Revisora";
            //maria.cpf = "234.456.786-03";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = maria;
            conta.titular = new Cliente();
            conta.titular.nome = "Maria";
            conta.titular.cpf = "234.456.786-03";
            conta.titular.profisao = "Revisora";

            conta.saldo = 500;
            conta.agencia = 565;
            conta.numero = 346476;

            conta.titular.nome = "Maria Carine";

            //Console.WriteLine(maria.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profisao);

            Console.ReadLine();
        }
    }
}
