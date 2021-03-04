using System;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string sourcePath = @"C:\Users\loren\Desktop\C# Completo\Trabalhando_Com_Arquivos\Arquivos_Teste\File1.txt"; //ORIGEM
            string targetPath = @"C:\Users\loren\Desktop\C# Completo\Trabalhando_Com_Arquivos\Arquivos_Teste\File2.txt"; //DESTINO

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
           

            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }


        }
    }
}
