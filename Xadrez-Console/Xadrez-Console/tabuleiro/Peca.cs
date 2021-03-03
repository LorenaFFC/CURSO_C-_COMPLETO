using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.tabuleiro
{
   abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } // pode ser acessada somente pela subclasse dela
        public int qtdeMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdeMovimento = 0;
            this.tab = tab;
        }

        public void incrementarQtdeMovimento()
        {
            qtdeMovimento++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i = 0; i< tab.linhas; i++)
            {
                for (int j = 0; j < tab.linhas; j++)
                {
                    if(mat[i, j ])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
