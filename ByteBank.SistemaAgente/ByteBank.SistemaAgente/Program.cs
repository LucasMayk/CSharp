using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using ByteBank.SistemaAgente.Extensoes;
using ByteBank.SistemaAgente.Comparadores;

namespace ByteBank.SistemaAgente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testando ordenar ContaCorrente com Listagem
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(350, 123456),
                null,
                new ContaCorrente(353, 654321),
                null,
                new ContaCorrente(356, 14545),
                null,
                new ContaCorrente(352, 56984),
                null,
                new ContaCorrente(349, 40967),
                null
            };

            //contas.Sort(); --> Chamar a implementação dada em IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            var contasOrdenada = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenada)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();
        }

        //Testando métodos genéricos com a classe staticas e utilizando o var e short.
        public void TestaSort()
        {
            var nome = new List<string>()
            {
                "Mayk",
                "Lucas",
                "Carine",
                "João",
            };

            nome.Sort();

            foreach (var nomes in nome)
            {
                Console.WriteLine(nomes);
            }

            var idade = new List<int>();

            idade.Add(45);
            idade.Add(5);
            idade.Add(67);
            idade.Add(23);
            idade.Add(67);
            idade.Add(78);

            idade.AdicionarVarios(34, 45, 56, -3);
            idade.AdicionarVarios(345, 456, -20);

            idade.Sort();

            //ListExtensoes.AdicionarVarios(idade, 34, 45, 67, 89);

            for (int i = 0; i < idade.Count; i++)
            {
                Console.WriteLine(idade[i]);
            }
        }

        //Testando Listangem com object.
        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdade = new ListaDeObject();

            listaDeIdade.Adicionar(10);
            listaDeIdade.Adicionar(5);
            listaDeIdade.Adicionar(4);
            listaDeIdade.Adicionar(7);
            listaDeIdade.AdicionarVarios(14, 45, 56, 678);

            for (int i = 0; i < listaDeIdade.Tamanho; i++)
            {
                int idade = (int)listaDeIdade[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        //Testando método SomarVarios.
        static int SomaVarios(params int[] numeros)
        {
            int acumuador = 0;
            foreach(int numero in numeros)
            {
                acumuador += numero;
            }

            return acumuador;
        }

        //Testando listagem com a calsse ContaCorrente.
        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(454, 541451);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(878, 464464),
                new ContaCorrente(878, 464464)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(878, 464464)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item n aposição {i} = conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

        }

        //Testando Array com a classe ContaCorrente.
        static void TestaArrayDeContaCorrente()
        {

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(234, 356456),
                new ContaCorrente(545, 634416),
                new ContaCorrente(654, 124141)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        //Testando Array com números inteiros.
        static void TestaArrayInt()
        {
            //ARRAY
            int[] idade = null;
            idade = new int[4];

            idade[0] = 15;
            idade[1] = 28;
            idade[2] = 35;
            idade[3] = 50;
            idade[4] = 67;
            idade[5] = 80;

            Console.WriteLine(idade.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idade.Length; indice++)
            {
                int idades = idade[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idades}");

                acumulador += idades;
            }

            int media = acumulador / 5;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}