using System.Collections.Generic;
namespace atividade_2.Models
{
    public class Pedido
    {
        private static List<ItemPedido> listaDeItens = new List<ItemPedido>();

        public void AdicionaPedido(ItemPedido pedido)
        {
            listaDeItens.Add(pedido);
        }

        public static double TotalizaPedido()
        {
            double total = 0;

            foreach (var lista in listaDeItens)
            {
                total = total + lista.valor * lista.quantidade;
            }
            return total;

        }
        public List<ItemPedido> ListaPedido()
        {
            return listaDeItens;
        }
        
    }
}