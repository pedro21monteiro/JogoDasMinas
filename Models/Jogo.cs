using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_de_Lab3
{
    class Jogo
    {
        public string Dificuldade { get; set; }
        public int Duracao { get; set; }
        public int Id { get; set; }
        public string Modo { get; set; }
        public Tabuleiro _tabuleiro { get; set; }
        public Jogador _jogador { get; set; }

        

        public Boolean Jogo_Acabou()
        {
            throw new System.NotImplementedException();
        }

        public void Ranking()
        {
            throw new System.NotImplementedException();
        }

        // a funçao modo de jogo consoante a dificuldade vai alterar os valores do tabuleiro
        public void Modo_de_Jogo()
        {
            _tabuleiro = new Tabuleiro();
            _jogador= new Jogador();

            if (Dificuldade == "Facil") 
            {
                _tabuleiro.Dimensao = 9;
                _tabuleiro.Numero_de_Minas = 10;
                
            }
            if (Dificuldade == "Medio")
            {
                _tabuleiro.Dimensao = 16;
                _tabuleiro.Numero_de_Minas = 40;
              
            }
            //basicamente vai defenir a dimensão e numero de minas conforme a dificuldade de jogo e depois vai gerar o 
            //tabuleiro inicial que é só imagens de butões
            _tabuleiro.Criar_Tabuleiro_Inicial();
            
        }
    }
}
