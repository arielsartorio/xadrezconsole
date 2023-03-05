using System;
using System.Collections.Generic;
using Tabuleiro;

namespace ProjectChess
{
    class Program
    {
        public static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);
        }
    }
}