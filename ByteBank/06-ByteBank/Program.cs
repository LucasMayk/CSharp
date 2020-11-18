using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATH NO METODO MAIN");
            }
            

            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            //----------------------------------------------
            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturado e tratada!");
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
                
            //}
            
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta_01 = new ContaCorrente(123, 98567);
                ContaCorrente conta_02 = new ContaCorrente(234, 45798);

                //conta_01.Transferir(10000, conta_02);
                conta_01.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                // Console.WriteLine("Informções da INNER EXCEPTION (exceção interna):");
            }
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                Dividir(10, divisor);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Fui capturado pelo (NulReferenceException ex)");
                Console.WriteLine(ex.StackTrace);
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Fui capturado pelo (Exception ex)");
                Console.WriteLine(ex.StackTrace);
            }
     
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                Console.WriteLine("Fazendo o cálculo " + numero + " / " + divisor);
                int resultado = numero / divisor;
                Console.WriteLine("O resultado é " + resultado);
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no calculo: " + ex.Message);
                throw; //Lança exceção
            }
            
        }
    }
}