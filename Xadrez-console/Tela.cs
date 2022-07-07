using Xadrez_console.tabuleiro;
using System;

namespace Xadrez_console
{
    internal class Tela
    {

        public static void imprimirTaabuleito(Tabuleiro tab)
        {
            for(int i=0; i< tab.Linhas; i++)
            {

                for(int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.peca(i,j));
                    }

                }
                Console.WriteLine();

            }
        }
    }
}
