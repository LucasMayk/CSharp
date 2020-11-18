using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaMaria = new ContaCorrente();
            contaMaria.titular = "Maria";
            contaMaria.agencia = 494;
            contaMaria.numero = 253445;
            contaMaria.saldo = 200;

            Console.WriteLine(contaMaria.titular);
            Console.WriteLine("Agência: " + contaMaria.agencia);
            Console.WriteLine("Número: " +contaMaria.numero);
            Console.WriteLine("Saldo: " + contaMaria.saldo);

            Console.ReadLine();
        }
    }
}
