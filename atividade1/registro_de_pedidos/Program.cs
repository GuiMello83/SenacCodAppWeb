using System;
using System.Collections.Generic;

namespace registro_de_pedidos
{
    class ItemPedido
    {
        public String descricao;
        public double valor;
        public double quantidade;

        public ItemPedido(String d, double v, double q)
        {
            descricao = d;
            valor = v;
            quantidade = q;
        }

    }
    class Pedido
    {
        private List<ItemPedido> itemPedido;

        public Pedido()
        {
            itemPedido = new List<ItemPedido>();
        }
        public void AdicionaPedido(ItemPedido item)
        {
            itemPedido.Add(item);
        }
        public double TotalizaPedido()
        {
            double total = 0;
            foreach (var item in itemPedido)
            {
                total = total + item.valor * item.quantidade;
            }
            return total;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            String descricao;
            double valor, quantidade;
            char fim = 's';
            Pedido novoPedido = new Pedido();

            do
            {
                Console.Clear();
                Console.WriteLine("=========== PEDIDOS ===========");
                Console.WriteLine("Digite a descrição do pedido:");
                descricao = Console.ReadLine();
                Console.WriteLine("Digite o valor unitário do pedido:");
                valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade desse pedido:");
                quantidade = double.Parse(Console.ReadLine());


                ItemPedido novoItemPedido = new ItemPedido(descricao, valor, quantidade);
                novoPedido.AdicionaPedido(novoItemPedido);
                Console.WriteLine("Quer adicionar mais pedidos? (s/n)");
                fim = Convert.ToChar(Console.ReadLine());


            } while (fim == 's');

            Console.WriteLine("O valor do total dos pedidos foi de R$" + novoPedido.TotalizaPedido());


        }
    }
}
