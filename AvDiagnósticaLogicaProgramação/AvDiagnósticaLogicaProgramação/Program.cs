using System;

namespace AvDiagnósticaLogicaProgramação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numerosInteiros = new int[10];
            byte qtd = 0;
            int numeroBusca;
            bool encontrado = false;

            Console.WriteLine("Informe uma sequência de 10 números inteiros:");
            while (qtd < 10)
            {
                try
                {
                    int numero = Convert.ToInt32(Console.ReadLine());
                    numerosInteiros[qtd] = numero;
                    qtd++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Não é um numero válido!");
                    continue;
                }
            }

            while (true)
            {
                Console.WriteLine("Informe o número que deseja buscar:");
                try
                {
                    numeroBusca = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < numerosInteiros.Length; i++)
                    {
                        if (numerosInteiros[i] == numeroBusca)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Não é um número válido!");
                    continue;
                }

            }

            if (encontrado)
            {
                Console.WriteLine("O número {0} foi encontrado com sucesso!", numeroBusca);
                if (numeroBusca % 2 == 0)
                {
                    Console.WriteLine("O número é par!");
                }
                else
                {
                    Console.WriteLine("O número é ímpar!");
                }
            }
            else
            {
                Console.WriteLine("O número {0} não foi encontrado!", numeroBusca);

            }
            Console.ReadLine();
        }
    }
}
