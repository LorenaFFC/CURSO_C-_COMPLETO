using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryANDDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listando SubPastas das Pastas");
            Console.WriteLine();

            string path = @"C:\Users\loren\Desktop\C# Completo\Trabalhando_Com_Arquivos\Arquivos_Teste";

            try
            {
               IEnumerable<string> folders =Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders");

                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine();
                Console.WriteLine("Listando Arquivos");
                Console.WriteLine();
                IEnumerable<string> arquivos = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("arquivos");

                foreach (string a in arquivos)
                {
                    Console.WriteLine(a);
                }

                Console.WriteLine();
                Console.WriteLine("Criando Pasta");

                Directory.CreateDirectory(path + "\\NOVAPASTA");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro:   ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
