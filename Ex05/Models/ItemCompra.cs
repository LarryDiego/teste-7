namespace Ex05.Models
{
    public class ItemCompra
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnidade { get; set; }

        public ItemCompra(string nomeProduto, int quantidade, double precoUnidade)
        {
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            PrecoUnidade = precoUnidade;
        }

        public override string ToString()
        {
            return $"- Nome do produto: {NomeProduto} - Quantidade: {Quantidade} - Preço unidade: R$ {PrecoUnidade:F2} - Total desse produto: R$ {(PrecoUnidade * Quantidade):F2}";
        }

    }
}