
using Xadrez_console.tabuleiro;

namespace Xadrez_console.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R ";
        }
    }
}
