using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Lab3
{
    class Jogador
    {
        public string Email { get; set; }
        public string Pais { get; set; }//País
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int Numero_Jogos_Ganhos { get; set; }
        public int Numero_Jogos_Perdidos { get; set; }
        public string Password { get; set; }
        public int Pontos { get; set; }
        public int Tempo_Facil { get; set; }
        public int Tempo_Medio { get; set; }
        public string Username { get; set; }
    
 

        public void Alterar_Conta()
        {
            throw new System.NotImplementedException();
        }

        public void Verificar_Login()
        {
            throw new System.NotImplementedException();
        }

        public void Criar_Conta()
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar_Pontos()
        {
            throw new System.NotImplementedException();
        }
    }
}
