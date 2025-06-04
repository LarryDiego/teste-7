using System;
using System.Globalization;
using Ex01.Models;

namespace Ex01
{
  class Program
  {
    static void Main(string[] args)
    {
      // OBS: USAR . PARA DIGITAR AS NOTAS E NAO ,
      CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
      Console.Write("Informe o nome do Aluno: ");
      string nome = Console.ReadLine();

      Console.Write("Informe a primeira nota: ");
      double nota1 = double.Parse(Console.ReadLine());

      Console.Write("Informe a segunda nota: ");
      double nota2 = double.Parse(Console.ReadLine());

      Console.Write("Informe a terceira nota: ");
      double nota3 = double.Parse(Console.ReadLine());

      Aluno aluno = new Aluno(nome);
      aluno.AdicionarNota(nota1);
      aluno.AdicionarNota(nota2);
      aluno.AdicionarNota(nota3);

      Console.WriteLine($"Nome aluno: {aluno.Nome} - Média: {aluno.Media()} - Situação: {aluno.Situacao()}");
    }
  }
}