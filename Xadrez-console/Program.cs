using System;
using Xadrez_console.tabuleiro;
using Xadrez_console.xadrez;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez posicao = new PosicaoXadrez('a', 1);

                Console.WriteLine(posicao);

            Console.WriteLine(posicao.ToPosicao());
            Console.ReadLine();
        }
    }
}
