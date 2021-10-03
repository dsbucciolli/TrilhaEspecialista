using System;
using System.Collections.Generic;
using System.Text;

namespace AvDiagnostica_Contas
{
    class ContaCorrente
    {

        public string Nome { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; private set; }


        public ContaCorrente()
        {

        }

        public ContaCorrente(string nome, int agencia, int conta, double saldo)
        {
            Nome = nome;
            Agencia = agencia;
            Conta = conta;
            Saldo = saldo;
        }

        public void Saque(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public virtual void Juros(double juros)
        {
            double valor = (Saldo * (juros / 100)) * 0.99; // Desconto de 1% no credito do Juros
            Deposito(valor);
        }

    }
}
