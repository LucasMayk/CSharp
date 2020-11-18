using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11");

            double valorIvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++ )
            {
                valorIvestido *= 1.0036;
                Console.WriteLine(
                    "Após " + contadorMes +
                    " meses, você tera R$" + valorIvestido);
            }

            Console.ReadLine();
        }
    }
}
