using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } // pode ser acessada somente pela subclasse dela
        public int qtdeMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtdeMovimento, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qtdeMovimento = 0;
            this.tab = tab;
        }
    }
}
