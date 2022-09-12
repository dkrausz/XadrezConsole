using System;
using Xadrez_console.tabuleiro;
using Xadrez_console.xadrez;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {


            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.Terminada)
            {
                try
                {


                    Console.Clear();
                    Tela.imprimirTaabuleito(partida.Tabuleiro);
                    Console.WriteLine();
                    Console.WriteLine("Turno: " + partida.Turno);
                    Console.WriteLine("Aguardando a jogada: " + partida.JogadorAtual);


                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    partida.ValidaPosicaoDeOrigem(origem);


                    bool[,] posicoesPossiveis = partida.Tabuleiro.Peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTaabuleito(partida.Tabuleiro, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ValidarPosicaoDeDestino(origem, destino);
                    partida.RealizaJogada(origem, destino);


                }




                catch (TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }

            Console.ReadLine();
        }
    }
}
