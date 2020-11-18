using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando vaiaveis ponto flutuante");

            double salario;

            salario = 1200.70;
            Console.WriteLine("Salario: " + salario);

            double idade;
            idade = 15.0 / 2.0;
            Console.WriteLine("idade: " + idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 =  " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 =  " + idade);

            Console.WriteLine("Tecle Enter para finalizar...");
            Console.ReadLine();
        }
    }
}
