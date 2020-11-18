using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO; // Input e Output
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivos()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivos = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,54873,8542.54,Mayk Lucas";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivos.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWhiter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDearquivos = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxoDearquivos, Encoding.UTF8))
            {
                escritor.Write("345,78946,78.45,João");
            }
        }

        static void TestaEsrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush(); //Despeja obuffer para o Stream!

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais");
                    Console.ReadLine();
                }
            }
        }
    }
}