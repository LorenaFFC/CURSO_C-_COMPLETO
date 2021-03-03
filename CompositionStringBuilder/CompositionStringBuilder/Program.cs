using CompositionStringBuilder.Entities;
using System;

namespace CompositionStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Comment c1 = new Comment("Sucesso");
            Comment c2 = new Comment("Opa!!! Boa Sorte");
            Comment c3 = new Comment("Sucesso Lorenaaaa");

            Post p1 = new Post(
                DateTime.Parse("21/08/2019"),
                "Novo Trabalho",
                "Comecei no meu novo trabalho",
                13
                );

            p1.AddComment(c1);
            p1.AddComment(c2);
            p1.AddComment(c3);

            Console.WriteLine(p1);
        }
    }
}
