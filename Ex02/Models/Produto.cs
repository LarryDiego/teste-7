namespace Ex02.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public double PrecoBase { get; set; }
        public string Categoria { get; set; }

        public Produto(string nome, double precoBase, string categoria)
        {
            Nome = nome;
            PrecoBase = precoBase;
            Categoria = categoria;
        }

        public double AplicarDesconto()
        {
            double desconto;
            if (Categoria == "Eletronico")
            {
                desconto = PrecoBase * 0.15;
            }
            else if (Categoria == "Vestuario")
            {
                desconto = PrecoBase * 0.10;
            }
            else
            {
                desconto = PrecoBase * 0.05;
            }
            return desconto;
        }

        public double PrecoFinal(double desconto)
        {
            return PrecoBase - desconto;
        }
    }
}