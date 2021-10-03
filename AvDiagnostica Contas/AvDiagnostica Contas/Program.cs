using System;

namespace AvDiagnostica_Contas
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente("Douglas Sebastiani Bucciolli", 1, 28, 100);

            Console.WriteLine("Informações de Conta Corrente:");
            Console.WriteLine($@"Nome: {cc.Nome}");
            Console.WriteLine($@"Agência: {cc.Agencia}");
            Console.WriteLine($@"Conta: {cc.Conta}");
            Console.WriteLine($@"Saldo: R$ {cc.Saldo:F2}");

            Console.WriteLine("---------------------------------------------------------------------");
            double valor = 25;
            Console.WriteLine($@"Saque de R$ {valor:F2} na Conta Corrente.");
            cc.Saque(valor);
            Console.WriteLine($@"Saldo: R$ {cc.Saldo:F2}");

            Console.WriteLine("---------------------------------------------------------------------");
            valor = 100;
            Console.WriteLine($@"Depósito de R$ {valor:F2} na Conta Corrente.");
            cc.Deposito(valor);
            Console.WriteLine($@"Saldo: R$ {cc.Saldo:F2}");

            Console.WriteLine("---------------------------------------------------------------------");
            valor = 2;
            Console.WriteLine($@"Juros de {valor:F2}% na Conta Corrente. Desconto fixo de 1%");
            cc.Juros(valor);
            Console.WriteLine($@"Saldo: R$ {cc.Saldo:F2}");

            Console.WriteLine("---------------------------------------------------------------------");
            valor = 350;
            Console.WriteLine($@"Saque de R$ {valor:F2} na Conta Corrente.");
            cc.Saque(valor);
            Console.WriteLine($@"Saldo: R$ {cc.Saldo:F2}");

            Console.WriteLine("---------------------------------------------------------------------");
            ContaPoupanca cp = new ContaPoupanca("Douglas Sebastiani Bucciolli", 1, 35, 200, DateTime.Now);
            Console.WriteLine("Informações de Conta Poupança:");
            Console.WriteLine($@"Nome: {cp.Nome}");
            Console.WriteLine($@"Agência: {cp.Agencia}");
            Console.WriteLine($@"Conta: {cp.Conta}");
            Console.WriteLine($@"Saldo: R$ {cp.Saldo:F2}");
            Console.WriteLine($@"Data de Abertura: {cp.DataAbertura:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($@"Dia de Aniversário: {cp.Aniversario}");

            //Operações
            Console.WriteLine("---------------------------------------------------------------------");
            valor = 100;
            Console.WriteLine($@"Depósito de R$ {valor:F2} na Conta Poupança.");
            cp.Deposito(valor);
            Console.WriteLine($@"Saldo: R$ {cp.Saldo:F2}");

            Console.WriteLine("---------------------------------------------------------------------");
            valor = 4.5; //Crédito de Juros de 4.5% na Conta Poupança
            Console.WriteLine($@"Crédito de Juros de {valor:F2}% na Conta Poupança.");
            cp.Juros(valor);
            Console.WriteLine($@"Saldo: R$ {cp.Saldo:F2}");

            Console.WriteLine("---------------------------------------------------------------------");
            valor = 500;
            Console.WriteLine($@"Saque de R$ {valor:F2} na Conta Poupança.");
            cp.Saque(valor);
            Console.WriteLine($@"Saldo: R$ {cp.Saldo:F2}");

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($@"Resgate Total da Conta Poupança."); 
            Console.WriteLine("Saldo para resgate: {cp.Saldo:F2}");
            cp.ResgateTotal();
            Console.WriteLine($@"Saldo: R$ {cp.Saldo:F2}");

            Console.ReadLine();
        }
    }
}
