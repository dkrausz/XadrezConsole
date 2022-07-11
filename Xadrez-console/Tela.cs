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
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.Colunas; j++)
                {
                    
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimePeca(tab.Peca(i, j));
                    }

                }
                Console.WriteLine();


            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimePeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca + " " );
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca + " ");
                Console.ForegroundColor = aux;  
            }
        }
    }
}
 