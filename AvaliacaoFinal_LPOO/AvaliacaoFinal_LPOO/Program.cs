using System;
using System.Collections;
using System.Collections.Generic;

namespace AvaliacaoFinal_LPOO
{
    struct StruFuncionario
    {
        public string Nome;
        public int CargaHoraria;
        public double ValorHora;
        public string EmpresaOrigem;
        public double TaxaServico;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listaFunc = new List<Funcionario>();

            bool sair = false;
            do
            {
                StruFuncionario struFuncionario = new StruFuncionario();
                Console.Write("Informe o nome do Funcionário: ");
                struFuncionario.Nome = Console.ReadLine();
                Console.Write("Informe a carga horária do Funcionário: ");
                struFuncionario.CargaHoraria = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o valor/hora do Funcionário: ");
                struFuncionario.ValorHora = Convert.ToDouble(Console.ReadLine());
                Console.Write("Se é terceiro, informe o nome da empresa origem: ");
                struFuncionario.EmpresaOrigem = Console.ReadLine();
                if (!struFuncionario.EmpresaOrigem.Trim().Equals(String.Empty))
                {
                    Console.Write("Informe a taxa de serviço para a empresa origem: ");
                    struFuncionario.TaxaServico = Convert.ToDouble(Console.ReadLine());
                    listaFunc.Add(new Terceiro(struFuncionario.Nome, struFuncionario.CargaHoraria, struFuncionario.ValorHora, struFuncionario.EmpresaOrigem, struFuncionario.TaxaServico));
                }
                else
                {
                    listaFunc.Add(new Funcionario(struFuncionario.Nome, struFuncionario.CargaHoraria, struFuncionario.ValorHora));
                }


                ConsoleKey resposta;
                do
                {
                    Console.Write("Deseja continuar o cadastro? [S/N] ");
                    resposta = Console.ReadKey(false).Key;
                    if (resposta != ConsoleKey.Enter)
                        Console.WriteLine();

                } while (resposta != ConsoleKey.S && resposta != ConsoleKey.N);

                sair = resposta == ConsoleKey.N;
            } while (!sair);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            foreach (var item in listaFunc)
            {
                item.ImprimeDados();
                Console.WriteLine("---------------------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
