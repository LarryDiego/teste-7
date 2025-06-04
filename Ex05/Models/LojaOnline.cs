namespace Ex05.Models
{
    public class LojaOnline
    {
        public List<ItemCompra> listaCompras = new List<ItemCompra>();

        public void AdicionarItem(ItemCompra item)
        {
            listaCompras.Add(item);
        }

        public double TotalCarrinho()
        {
            double total = 0;
            foreach (var item in listaCompras)
            {
                total += item.PrecoUnidade * item.Quantidade;
            }
            return total;
        }

        public void ListarItens()
        {
            foreach (var item in listaCompras)
            {
                Console.WriteLine(item);
            }
        }
    }
}