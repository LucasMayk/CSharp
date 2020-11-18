using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13");

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********

            //Trabalhando com break
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }

                Console.WriteLine();
            }

            //Mapeando asterisco de uma forma diferente
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write("*");

                Console.WriteLine();
            }

            //Mútiplos de 3, entre 1 e 100
            for (int i = 3; i < 100; i += 3)
            {
                    Console.WriteLine(i);
            }

            //Fatorial
            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
