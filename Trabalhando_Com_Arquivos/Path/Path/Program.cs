using System;
using System.IO;

namespace Path1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Path");

            string path = @"C:\Users\loren\Desktop\C# Completo\Trabalhando_Com_Arquivos\Arquivos_Teste\File1.txt";

            Console.WriteLine("DirectorySeparatorChar:  " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator:  " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName:  " + Path.GetDirectoryName(path)) ;
            Console.WriteLine("GetFileName:  " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension:  " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension:  " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath:  " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath:  " + Path.GetTempPath());

        }
    }
}
