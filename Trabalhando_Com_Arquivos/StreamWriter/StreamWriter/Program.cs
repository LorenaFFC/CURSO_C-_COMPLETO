using System;
using System.IO;

namespace StreamWriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StreamWriter");

            string sourcepath = @"C:\Users\loren\Desktop\C# Completo\Trabalhando_Com_Arquivos\Arquivos_Teste\File1.txt";
            string targetpath = @"C:\Users\loren\Desktop\C# Completo\Trabalhando_Com_Arquivos\Arquivos_Teste\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("OCORREU UM ERRO:");
                Console.WriteLine(e.Message);
            }


        }
    }
}
