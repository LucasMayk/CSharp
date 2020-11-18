using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO; // Input e Output
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WhiteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            var byteArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {byteArquivo.Length} bytes");


            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();


            UsarStreamDeEntrada();

            Console.WriteLine("Aplicação Finalizada. . .");
                
            Console.ReadLine();
        }
    }
}
