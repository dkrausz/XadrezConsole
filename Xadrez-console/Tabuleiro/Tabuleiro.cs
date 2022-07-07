﻿

namespace Xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        
        }

        public Peca peca(int linha, int coluna)
        {
            return _pecas[linha, coluna];
        }

        public void ColocarPeca(Peca peca, Posicao pos)
        {
            _pecas[pos.Linha, pos.Coluna] = peca;
            peca.Posicao = pos;

        }
    }
}
