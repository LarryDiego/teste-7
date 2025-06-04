namespace Ex03.Models
{
    public class ContaInvestimento
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double TaxaJuros { get; set; }

        public ContaInvestimento(string titular, double saldo, double taxaJuros)
        {
            Titular = titular;
            Saldo = saldo;
            TaxaJuros = taxaJuros;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito precisa ser MAIOR que R$ 0.00");
                return;
            }

            Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque precisa ser MAIOR que R$ 0.00");
                return;
            }

            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque!");
                return;
            }

            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
        }

        public double CalcularRendimento(int meses)
        {
            double rendimentoTotal = 0, taxaJurosMensal = TaxaJuros / 12;
            if (meses <= 0)
            {
                Console.WriteLine("O rendimento precisa ser de pelo menos 1 mês, então seu rendimento será R$ 0.00");
                return rendimentoTotal;
            }

            double saldoSimulado = Saldo;

            for (int i = 1; i <= meses; i++)
            {
                double rendimentoMensal = 0;
                rendimentoMensal += saldoSimulado * taxaJurosMensal / 100;
                rendimentoTotal += rendimentoMensal;
                saldoSimulado += rendimentoMensal;
            }
            return rendimentoTotal;
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"Nome: {Titular} - Saldo: {Saldo:F2} - Rendimento em 12 meses: R$ {CalcularRendimento(12):F2}");
        }
    }
}