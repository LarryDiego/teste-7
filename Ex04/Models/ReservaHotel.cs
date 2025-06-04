namespace Ex04.Models
{
    public class ReservaHotel
    {
        public string NomeHospede { get; set; }
        public int Dias { get; set; }
        public double ValorDiaria { get; set; }

        public ReservaHotel(string nomeHospede, int dias, double valorDiaria)
        {
            NomeHospede = nomeHospede;
            Dias = dias;
            ValorDiaria = valorDiaria;
        }

        public double ValorTotal()
        {
            return Dias * ValorDiaria;
        }

        public bool Validar()
        {
            if (Dias <= 0 || ValorDiaria < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ResumoReserva()
        {
            Console.WriteLine($"Nome: {NomeHospede} - Total: R$ {ValorTotal():F2} - Situação da reserva: {(Validar() ? "Válida" : "Inválida")}");
        }
    }
}