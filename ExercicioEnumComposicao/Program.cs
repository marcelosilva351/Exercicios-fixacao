using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumComposicao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CLIENTE -");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Data nascimento: ");
            DateTime dataNascimentoCliente = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nomeCliente, emailCliente, dataNascimentoCliente);

            Console.WriteLine("PEDIDO -");
            Console.Write("Status pedido: ");
            StatusPedido statuspedido;
            while (true)
            {
                if(Enum.TryParse<StatusPedido>(Console.ReadLine(), out StatusPedido statusPedido)){
                    statuspedido = statusPedido;
                    break;
                }
                else
                {
                    Console.WriteLine("Nao existe este status de pedido");
                    continue;
                }
            }
            Pedido pedido = new Pedido(statuspedido, cliente);

            Console.WriteLine("Quantidade de itens: ");
            int quantidadeItens = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeItens; i++)
            {
                Console.Write("Nome produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço produto: ");
                double precoProduto = double.Parse(Console.ReadLine());
                Produto produto = new Produto(nomeProduto, precoProduto);
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                pedido.AdicionarItem(new Item(produto, quantidade, precoProduto));
            }

            Console.WriteLine("DADOS PEDIDO:");
            Console.WriteLine($"Data pedido: {pedido.Data.ToString("yyyy/MM/dd")}");
            Console.WriteLine($"Status do pedido: {pedido.Status}");
            Console.WriteLine($"CLIENTE: {pedido.cliente.Nome} ({pedido.cliente.DataNascimento.ToString("yyyy/MM/dd")} - {pedido.cliente.Email})");

            Console.WriteLine("ITENS DO PEDIDO - ");
            pedido.listarItens();
            Console.WriteLine("Total pedido: " + pedido.TotalPedido());
            Console.ReadLine();
            
             
           
        }
    }
}
