using System;
using System.Globalization;
using Ex05.Models;

namespace Ex05
{
  class Program
  {
    static void Main(string[] args)
    {
      // OBS: USAR . PARA DIGITAR AS NOTAS E NAO ,
      CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
      LojaOnline carrinho = new LojaOnline();

      for (int i = 1; i <= 3; i++)
      {
        Console.Write("Informe o nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Informe a quantidade de itens: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("Informe o preço da unidade desse produto: ");
        double precoUnidade = double.Parse(Console.ReadLine());

        ItemCompra item = new ItemCompra(nome, quantidade, precoUnidade);
        carrinho.AdicionarItem(item);
      }
      Console.WriteLine("--- LISTA DE COMPRAS ---");
      carrinho.ListarItens();
      Console.WriteLine("--- TOTAL DO CARRINHO ---");
      Console.WriteLine($"Total: R$ {carrinho.TotalCarrinho():F2}");
    }
  }
}
