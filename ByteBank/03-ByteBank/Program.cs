using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando da class ContaCorrente()
            ContaCorrente contaMayk = new ContaCorrente();

            //Nome titular
            contaMayk.titular = "Mayk";
            Console.WriteLine(contaMayk.titular);

            //saldo da conta
            Console.WriteLine("Saldo: " + contaMayk.saldo);

            //Saque
            bool resultadoSaque = contaMayk.Sacar(50);
            Console.WriteLine("Saldo depois do saque: " + contaMayk.saldo);
            //Resultado do saque
            Console.WriteLine("Resultado do saque: " + resultadoSaque);

            Console.WriteLine();//Quebra de linha

            //Depositar
            contaMayk.Depositar(2000);
            Console.WriteLine("Depositado: " + contaMayk.saldo);

            Console.WriteLine();//Quebra de linha

            //Instanciando da class ContaCorrente()
            ContaCorrente contaMaria = new ContaCorrente();

            //Nome titular
            contaMaria.titular = "Maria";
            Console.WriteLine(contaMaria.titular);

            //Saldo antes da transferência
            Console.WriteLine("Saldodo Mayk: " + contaMayk.saldo);
            Console.WriteLine("Saldo da Maria: " + contaMaria.saldo);

            //Tranferência 
            bool resultadoDaTranferencia = contaMayk.Transferir(500, contaMaria);
            Console.WriteLine();//Quebra de linha

            //Saldo depois da transferência
            Console.WriteLine("Saldodo Mayk: " + contaMayk.saldo);
            Console.WriteLine("Saldo da Maria: " + contaMaria.saldo);

            //Resultado da tranferência
            Console.WriteLine("Resultado Tranferência: " + resultadoDaTranferencia);

            //Tranferência 
            contaMaria.Transferir(350, contaMayk);
            Console.WriteLine();//Quebra de linha

            //Saldo depois da transferência
            Console.WriteLine("Saldodo Mayk: " + contaMayk.saldo);
            Console.WriteLine("Saldo da Maria: " + contaMaria.saldo);

            Console.ReadLine();
        }
    }
}
