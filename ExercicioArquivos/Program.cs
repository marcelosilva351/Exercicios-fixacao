using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExercicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\produtosRevisaoo\produtos.txt";
            List<Produto> produtos = new List<Produto>();
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                string pastaCaminho = Path.GetDirectoryName(caminho);
                string novaPasta = pastaCaminho + @"\out";
                Directory.CreateDirectory(novaPasta);
                string novoCaminho = novaPasta + @"\sumary.docx";

                using(StreamWriter streamWriter = File.AppendText(novoCaminho))
                {
                    foreach (string linha in linhas)
                    {
                        string[] dadosProdutos = linha.Split(',');
                        string nomeProduto = dadosProdutos[0];
                        double precoProduto = double.Parse(dadosProdutos[1]);
                        int quantidadeProduto = int.Parse(dadosProdutos[2]);
                        Produto produtoAdd = new Produto(nomeProduto, precoProduto, quantidadeProduto);
                        produtos.Add(produtoAdd);
                        streamWriter.WriteLine($"{nomeProduto},{precoProduto},{produtoAdd.precoTotal()}");
                    }
                }

                    
                    
            }
            catch (IOException e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
