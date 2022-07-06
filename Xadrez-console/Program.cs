using System;
using Xadrez_console.Tabuleiro;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao posicao = new Posicao(3, 4);

            Console.WriteLine(posicao);
        }
    }
}
