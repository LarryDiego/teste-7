using System;
using System.Globalization;
using Ex03.Models;

namespace Ex03
{
  class Program
  {
    static void Main(string[] args)
    {
      // OBS: USAR . PARA DIGITAR AS NOTAS E NAO ,
      CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

      Console.Write("Informe o nome do titular: ");
      string titular = Console.ReadLine();

      Console.Write("Informe o saldo inicial da conta: ");
      double saldo = double.Parse(Console.ReadLine());

      Console.Write("Informe a taxa de juros anual: ");
      double taxaJuros = double.Parse(Console.ReadLine());

      ContaInvestimento conta = new ContaInvestimento(titular, saldo, taxaJuros);

      Console.Write("Informe o valor do depósito: ");
      double deposito = double.Parse(Console.ReadLine());
      conta.Depositar(deposito);

      Console.Write("Informe o valor do saque: ");
      double saque = double.Parse(Console.ReadLine());
      conta.Sacar(saque);

      Console.Write("Informe a quantidade de meses para descobrir o rendimento desse tempo: ");
      int meses = int.Parse(Console.ReadLine());
      double rendimento = conta.CalcularRendimento(meses);
      Console.WriteLine($"O saldo de R$ {conta.Saldo:F2} iria render R${rendimento:F2} no período de {meses} meses");

      conta.ExibirResumo();

    }
  }
}