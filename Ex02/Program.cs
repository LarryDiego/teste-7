using System;
using System.Globalization;
using Ex02.Models;

namespace Ex02
{
  class Program
  {
    static List<Produto> produtos = new List<Produto>();
    static void Main(string[] args)
    {
      // OBS: USAR . PARA DIGITAR AS NOTAS E NAO ,
      // OBS2: Escrever categorias SEM acento
      CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

      for (int i = 0; i < 2; i++)
      {
        Console.Write("Informe o nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Informe o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Informe a categoria do produto: ");
        string categoria = Console.ReadLine();

        Produto produto = new Produto(nome, preco, categoria);
        produtos.Add(produto);
        Console.WriteLine();
      }

      foreach (var produto in produtos)
      {
        double desconto = produto.AplicarDesconto();
        Console.WriteLine($"Nome: {produto.Nome} - Categoria: {produto.Categoria} - Preço base: R$ {produto.PrecoBase:F2} - Preço com desconto: R$ {produto.PrecoFinal(desconto):F2}");
      }
    }
  }
}