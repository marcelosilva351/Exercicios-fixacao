using System;
using System.IO;
using System.Collections.Generic;

namespace ExercicioArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivoProdutos = @"c:\folder\products.txt";
            try
            {
                string[] linhasArquivoProdutos = File.ReadAllLines(caminhoArquivoProdutos);

                string nomePastaArquivo = Path.GetDirectoryName(caminhoArquivoProdutos);
                string PastaNova = nomePastaArquivo + @"\out";
                string arquivoNovo = PastaNova + @"\sumary.csv";
                Directory.CreateDirectory(PastaNova);
                List<Produto> produtos = new List<Produto>();

               using(StreamWriter streamWriter = File.AppendText(arquivoNovo)){
                    foreach (string linha in linhasArquivoProdutos)
                    {
                        string[] dadosProdutos = linha.Split(',');
                        string nomeProduto = dadosProdutos[0];
                        double precoProduto = double.Parse(dadosProdutos[1]);
                        int quantidadeProdutos = int.Parse(dadosProdutos[2]);

                        produtos.Add(new Produto(nomeProduto, precoProduto, quantidadeProdutos));   
                    }

                    foreach (Produto produto in produtos)
                    {
                        streamWriter.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}, subTotal: {produto.PrecoTotal()}");
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
