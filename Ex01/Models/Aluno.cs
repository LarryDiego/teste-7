namespace Ex01.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public List<double> Notas { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Notas = new List<double>();
        }
        public void AdicionarNota(double n)
        {
            Notas.Add(n);
        }

        public double Media()
        {
            double somaNotas = 0;
            foreach (double nota in Notas)
            {
                somaNotas += nota;
            }
            return somaNotas / Notas.Count;
        }

        public string Situacao()
        {
            double media = Media();
            if (media >= 7)
            {
                return "Aprovado";
            }
            else if (media >= 5)
            {
                return "Recuperação";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}