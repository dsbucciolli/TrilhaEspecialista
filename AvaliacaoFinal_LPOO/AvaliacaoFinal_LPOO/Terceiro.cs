using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoFinal_LPOO
{
    class Terceiro : Funcionario
    {
        public string EmpresaOrigem { get; set; }
        public double TaxaServico { get; set; }
        public Terceiro(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico) : base(nome, cargaHoraria, valorHora)
        {
            EmpresaOrigem = empresaOrigem;
            TaxaServico = taxaServico;
        }

        public override double CalculaSalario()
        {
            return base.CalculaSalario() + TaxaServico;
        }

        public override void ImprimeDados()
        {
            base.ImprimeDados();
            Console.WriteLine($"Empresa Origem: {EmpresaOrigem}");
        }
    }
}
