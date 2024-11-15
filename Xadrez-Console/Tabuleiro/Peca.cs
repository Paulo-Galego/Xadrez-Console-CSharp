﻿

namespace tabuleiro
{
    public class Peca
    {
        public Peca(Tabuleiro tab,Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }

        public Posicao  posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; set; }
        public Tabuleiro tab { get; protected set; }
    }
}
