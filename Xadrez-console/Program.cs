﻿using System;
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
                    Console.Write("Origem ");

                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino ");

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
