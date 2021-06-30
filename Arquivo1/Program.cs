using System;
using System.IO;

namespace Arquivo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"c:\Arquivos\file1.txt";
            string caminhoCopia = @"c:\Arquivos\file2.txt";
            
            try
            {
                FileInfo fileInfo = new FileInfo(caminhoArquivo);
               // fileInfo.CopyTo(caminhoCopia);

                string[] linhas = File.ReadAllLines(caminhoArquivo);
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
                Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
