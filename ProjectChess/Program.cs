using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace ProjectChess
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 4));

                Tela.imprimirTabuleiro(tab);

                Console.WriteLine();
                PosicaoXadrez pos = new PosicaoXadrez('e', 5);
                Console.WriteLine(pos);
                Console.WriteLine();
                Console.WriteLine(pos.toPosicao());
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}