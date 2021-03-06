
namespace Xadrez_console.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }    
        public Cor Cor { get;protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QteMovimentos = 0;  
        }

        public void IncrementarMovimentos()
        {
            QteMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis(); 
    }
}
