using System;
using System.IO;
namespace Arquivo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\Arquivos\file1.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                //fileStream  = new FileStream(caminho, FileMode.Open);
                streamReader = File.OpenText(caminho);

                while (!streamReader.EndOfStream)
                {
                    string linha = streamReader.ReadLine();
                    Console.WriteLine(linha);

                }
                Console.ReadLine();



            }catch(IOException e)
            {

            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }

                /*
                if(fileStream != null)
                {
                    fileStream.Close();
                }
                */

            }
        }
    }
}
