using tabuleiro;

namespace xadrez {
    class PosicaoXadez {

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }
        public Posicao toPosicao() {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString() {
            return "" + coluna + linha;
        }
    }
}
