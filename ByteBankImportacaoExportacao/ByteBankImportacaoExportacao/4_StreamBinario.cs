using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(854); // Número da Agência
                escritor.Write(4454554); // Número da conta
                escritor.Write(7000.80); // Saldo
                escritor.Write("Mayk Lucas");
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
            }
        }
    }

}