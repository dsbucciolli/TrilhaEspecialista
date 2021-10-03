using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoFinal_LPOO
{


    class Funcionario
    {
        private string _nome;
        public int CargaHoraria { get; set; }
        public double ValorHora { get; set; }

        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;
        }

        public Funcionario()
        {
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Erro: Nome inválido!");
                }
                else
                {
                    _nome = value;
                }
            }
        }
        public virtual double CalculaSalario()
        {
            return CargaHoraria * ValorHora;
        }
        public virtual void ImprimeDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário: {CalculaSalario()}");
        }
    }
}
