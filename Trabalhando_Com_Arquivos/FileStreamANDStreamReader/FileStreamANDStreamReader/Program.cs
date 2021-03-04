using System;
using System.IO;

namespace FileStreamANDStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FILE STREAM!");

            string path = @"C:\Users\loren\Desktop\C# Completo\TrabalhandoComArquivos\ReadFile\File1.txt"; //ORIGEM
            FileStream fs = null;
            StreamReader sr = null;

            // Primeiro associa um FileStream associado ao arquivo - Depois:
            // associa o StreamReader associado ao FileStream


            try
            {
                // Instanciou o FileStream associado ao arquivo
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                // Agora podemos acessar as informações do arquivo
                string line = sr.ReadLine();
                Console.WriteLine("UTILIZANDO FileStream E StreamReader:    ");
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) sr.Close();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FILE STREAM DE FORMA OTIMIZADA");


            try
            {
                // o File.Opentext ja instancia de forma automatica
                sr = File.OpenText(path);
                // PARA LER TODAS AS LINHAS DO ARQUIVO E NAO SOMENTE A PRIMEIRA:
                Console.WriteLine("UTILIZANDO FileStream E StreamReader DE FORMA OTIMIZADA:    ");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
