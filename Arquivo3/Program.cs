using System;
using System.IO;
namespace Arquivo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\Arquivos\file1.txt";
            /*
           using(FileStream fileStream = new FileStream(caminho, FileMode.Open))
           {
               using(StreamReader streamReader = new StreamReader(fileStream))
               {
                   while (!streamReader.EndOfStream)
                   {
                       string linha = streamReader.ReadLine();
                       Console.WriteLine(linha);
                   }
               }

           }
            */

            try
            {
                using(StreamReader streamReader = File.OpenText(caminho))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string linha = streamReader.ReadLine();
                        Console.WriteLine(linha);
                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
