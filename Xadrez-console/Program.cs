using System;
using Xadrez_console.tabuleiro;
using Xadrez_console.xadrez;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(4, 4));
                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(2, 3));
                tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(4, 7));

                Tela.imprimirTaabuleito(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);    
            }

            Console.ReadLine();
        }
    }
}
