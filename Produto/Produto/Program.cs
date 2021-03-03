using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Nome:" );
            string nome = Console.ReadLine();
            Console.WriteLine("Preco:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           Console.WriteLine("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);


            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " +   p);
            Console.WriteLine();
            Console.Write("Digite o numero de produto a ser adicionado no estoque:  ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);
            Console.WriteLine("Dados do Atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o numero de produto a ser removido no estoque:  ");
            int qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine("Dados do Atualizados: " + p);
        }
    }
}
