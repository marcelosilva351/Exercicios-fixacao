using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adicionar quantos produtos?");
            int quantidadeProdutosAdd = int.Parse(Console.ReadLine());
            List<Produto> produtos = new List<Produto>();

            for (int i = 0; i < quantidadeProdutosAdd; i++)
            {
                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço: ");
                double precoProduto = double.Parse(Console.ReadLine());
                Console.Write("Tipo do produto (n/u/i): ");
                string decisaoTipoProduto = Console.ReadLine().ToLower();

                switch (decisaoTipoProduto)
                {
                    case "n":
                        produtos.Add(new Produto(nomeProduto, precoProduto));
                        break;
                    case "i":
                        Console.WriteLine("Valor imposto: ");
                        double valorImposto = double.Parse(Console.ReadLine());
                        produtos.Add(new ProdutoImportado(nomeProduto, precoProduto, valorImposto));
                        break;
                    case "u":
                        Console.WriteLine("Data de fabricação: ");
                        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                        produtos.Add(new ProdutoUsad(nomeProduto, precoProduto, dataFabricacao));
                        break;
                    default:
                        Console.WriteLine("não existe esse tipo de produto");
                        i--;
                        continue;
                        
                }

            }

            Console.WriteLine("PRODUTOS: ");
            foreach  (Produto produto in produtos)
            {
                Console.WriteLine(produto.TagProduto());
            }
            Console.ReadLine();
        }
    }
}
