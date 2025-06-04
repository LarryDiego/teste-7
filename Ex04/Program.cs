using System;
using System.Globalization;
using Ex04.Models;

namespace Ex04
{
  class Program
  {
    static List<ReservaHotel> reservasValidas = new List<ReservaHotel>();
    static void Main(string[] args)
    {
      // OBS: USAR . PARA DIGITAR AS NOTAS E NAO ,
      CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

      for (int i = 1; i <= 3; i++)
      {
        Console.Write("Informe o nome do hospede: ");
        string nome = Console.ReadLine();

        Console.Write("Informe a quantidade de dias (pelo menos 1 dia): ");
        int dias = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor da diária: ");
        double valorDiaria = double.Parse(Console.ReadLine());

        ReservaHotel reserva = new ReservaHotel(nome, dias, valorDiaria);

        if (reserva.Validar())
        {
          reservasValidas.Add(reserva);
          Console.WriteLine("Reserva cadastrada com sucesso!");
        }
        else
        {
          Console.WriteLine("Não foi possível cadastrar sua reserva. Os valores de dias e valor da diária devem ser positivos");
        }
      }
      foreach (var reserva in reservasValidas)
      {
        reserva.ResumoReserva();
      }
    }
  }
}