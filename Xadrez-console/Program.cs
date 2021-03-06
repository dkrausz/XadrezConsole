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

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.imprimirTaabuleito(partida.Tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partida.Tabuleiro.Peca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTaabuleito(partida.Tabuleiro, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                    partida.ExecutaMovimento(origem, destino);


                }           
                            
                             

            }

            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);    
            }

            Console.ReadLine();
        }
    }
}
