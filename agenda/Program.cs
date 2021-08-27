using System;
using System.Collections.Generic;

namespace agenda
{
    
    class ItemContato
    {

        public String nome, email, endereco;

        public ItemContato(String n, String e, String d)
        {

            nome = n;
            email = e;
            endereco = d;
        }
    }

    class Contato
    {
        private List<ItemContato> itemContato;

        public Contato()
        {
            itemContato = new List<ItemContato>();
        }
        public void AdicionaContato(ItemContato item)
        {
            itemContato.Add(item);
        }

        public int TotalizaContatos()
        {
            int total = 0;
            foreach (var item in itemContato)
            {
                total++; //isso é a mesma coisa que total = total + 1 e também e´a mesma coisa de total += 1; valor dos pedidos será o val.Unit * quantidade
                //na atividade 1 sera total = total + item.valorUnitario * item.quantidade
            }
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String nome, email, endereco;
            char fim = 's';

            Contato novoContato = new Contato();

            do
            {
                Console.Clear();
                Console.WriteLine("== AGENDA DE CONTATOS ==");
                Console.WriteLine("Digite o nome");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o email");
                email = Console.ReadLine();
                Console.WriteLine("Digite o endereço");
                endereco = Console.ReadLine();

                ItemContato novoItemContato = new ItemContato(nome, email, endereco);
                novoContato.AdicionaContato(novoItemContato);
                Console.WriteLine("Quer adicionar mais contatos na agenda? (s/n)");
                fim = Convert.ToChar(Console.ReadLine());

            } while (fim == 's');

            Console.WriteLine("Total de contatos: " + novoContato.TotalizaContatos());
            
        }
    }
}
