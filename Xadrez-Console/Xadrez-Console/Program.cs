using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada){
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("ORIGEM =>  ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("DESTINO =>  ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();


                    partida.executaMovimento(origem, destino);
                }

                
            }
            catch (TabuleiroException t)
            {
                Console.WriteLine(t.Message);
            }

            

        }
    }
}
