using System;
using System.IO;

namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bloco Using!");

            string path = @"C:\Users\loren\Desktop\C# Completo\Trabalhando_Com_Arquivos\Arquivos_Teste\File1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
