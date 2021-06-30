using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumComposicao
{
    class Pedido
    {

        public DateTime Data { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente cliente { get; set; }

        List<Item> itens = new List<Item>();

        public Pedido(StatusPedido status, Cliente cliente)
        {
            Data = DateTime.Now;
            Status = status;
            this.cliente = cliente;
        }

        public void listarItens()
        {
            foreach (Item item in itens)
            {
                Console.WriteLine(item);
            }
        }
        public void AdicionarItem(Item item)
        {
            itens.Add(item);
        }

        public void Remover(int id)
        {
            foreach (Item item in itens)
            {
                if(item.IdItem == id)
                {
                    itens.Remove(item);
                }
            }
        }


        public double TotalPedido()
        {
            double total = 0;
            foreach (Item item in itens)
            {
                total += item.SubTotal();
            }
            return total;
        }
    }
}
