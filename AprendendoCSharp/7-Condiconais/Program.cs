using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condiconais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoão = 16;
            int quantidadeDePessoas = 2;

            if (idadeJoão >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, Pode entrar.");
            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos de idade, mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("Joãonão possui  mais de 18 anos, não pode entrar");
                }
            }

            Console.ReadLine();
        }
    }
}
