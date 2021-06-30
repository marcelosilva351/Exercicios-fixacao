using System;
using System.IO;
using System.Collections.Generic;
namespace Arquivo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\Arquivos\file1.txt";
            string caminhoDestitno = @"c:\Arquivos\file1UppeCase.txt";


            string[] linhas = File.ReadAllLines(caminho);
            using (StreamWriter streamWriter = File.AppendText(caminhoDestitno))
            {
                foreach (string linha in linhas)
                {
                    streamWriter.WriteLine(linha.ToUpper());
                }

            }

            //Directorys

            string caminhoDiretorio = @"c:\folder";
            Console.WriteLine("SUB PASTAS: ");
            IEnumerable<string> folder = Directory.EnumerateDirectories(caminhoDiretorio, "*.*", SearchOption.AllDirectories);

            foreach (string folders in folder)
            {
                Console.WriteLine(folders);
            }

            Console.WriteLine("ARQUIVOS:");
            IEnumerable<string> arquivos = Directory.EnumerateFiles(caminhoDiretorio, "*.*", SearchOption.AllDirectories);

            foreach (string arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            
        }
    }
}
