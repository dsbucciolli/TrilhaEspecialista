using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AvDiagnostica_Contas
{
    class ContaPoupanca : ContaCorrente
    {
        public byte Aniversario { get; private set; }

        private DateTime _dataAbertura;

        public DateTime DataAbertura
        {
            get 
            {
                return _dataAbertura;
            } 
            set 
            {
                _dataAbertura = value;
                if (value.Day >= 29  && value.Day <= 31)
                {
                    Aniversario = 1;
                }
                else
                {
                    Aniversario = byte.Parse(value.Day.ToString());
                }
            } 
        }

        public ContaPoupanca(string nome, int agencia, int conta, double saldo, DateTime dataAbertura) : base(nome, agencia, conta, saldo)
        {
            DataAbertura = dataAbertura;
        }

        public override void Juros(double juros)
        {
            base.Deposito(Saldo * (juros / 100));
        }

        public void ResgateTotal()
        {
            Saque(Saldo);
        }
    }
}
