using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Lab3
{
    class Tabuleiro
    {

        public int[,] MatrizFacil { get; set; }
        public int[,] MatrizMedia { get; set; }
        public int Dimensao { get; set; }
        public int Numero_de_Minas { get; set; }
        public Quadrado quadrado { get; set; }

        public void Atualizar_Tabuleiro()
        {
            throw new System.NotImplementedException();
        }

        public void Criar_Tabuleiro_Inicial()
        {
            //vai receber a dimensão do jogo e definir os desenhos todos a Imagem vazia com Butão
            if (Dimensao == 9)
            {
                //vamos ter de inicializar a matriz, e como este metodo é logo o primeiro a ser usada vamos inicializar aqui
                MatrizFacil = new int[9, 9];

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        MatrizFacil[i, j] = 19;// quadrados escondidos sera tudo maioir que 10  logo vou por um numero >10 ex 19
                    }
                }
            }
            if (Dimensao == 16)
            {
                //vamos ter de inicializar a matriz, e como este metodo é logo o primeiro a ser usada vamos inicializar aqui
                MatrizMedia = new int[16, 16];
                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        MatrizMedia[i, j] = 19;
                    }
                }

            }

        }
        //--------------------------------------------------------------------------------------------

        public void Criar_Tabuleiro_Primeiro_Click(int _x, int _y)
        {//vai entrar na função as coordenadas do primeiro click e nessa posião o quadrado tem de estar vazio
            if (Dimensao == 9)
            {// jogo facil logo 10 minas tem de aparecer no tabuleiro

                int minas = 10;
                int i, j;

                MatrizFacil[_x, _y] = 5;
                //apartir desta coordenada será criado todo o tabuleiro
                // á volta do quadrado branco não pode ter nenhuma bomba

                //código 21, quadrados que não podem ser bombas mas podem ser números
                for (i = -1; i <= 1; i++)
                {
                    for (j = -1; j <= 1; j++)
                    {
                        if (_x + i >= 0 && _x + i <= 8 && _y + j >= 0 && _y + j <= 8 && (i != 0 || j != 0)) {
                            MatrizFacil[_x + i, _y + j] = 21;// quadrados escondidos sera tudo maioir que 10  logo vou por um numero >10 ex 19
                        }
                    }
                }

                //vamos meter as minas de forma aleatória pelo tabuleiro
                while (minas != 0)
                {
                    for (i = 0; i < 9; i++)
                    {
                        for (j = 0; j < 9; j++)
                        {
                            //cada quadrado só pode ter no maximo 4 minas á volta

                            if (MatrizFacil[i, j] == 19 &&
                                Aleatorio_Mina(Contador_de_quadrados_nao_preenchidos("Facil"), minas) == true &&
                                Minas_a_volta_quadrado(i, j) <= 0) {
                                //se a matrir estiver 19(livre) e a funçao mina dar true vamos por uma mina nessa posição
                                MatrizFacil[i, j] = 16;//ainda vamos ter de alterar para mina escondida
                                minas--;
                            }

                        }
                    }
                }
                //depois de as minas estarem definidas vamos meter os numeros e os quadrados vazios
                int numeroDeMinasAVolta;
                for (i = 0; i < 9; i++)
                {
                    for (j = 0; j < 9; j++)
                    {
                        numeroDeMinasAVolta = Minas_a_volta_quadrado(i, j);

                        if (numeroDeMinasAVolta ==  0 && MatrizFacil[i, j] != 8 && MatrizFacil[i, j] != 16 && MatrizFacil[i, j] != 5)
                        {
                            MatrizFacil[i, j] = 15;
                        }
                        if (numeroDeMinasAVolta == 1 && MatrizFacil[i, j] != 8 && MatrizFacil[i, j] != 16 && MatrizFacil[i, j] != 5)
                        {
                            MatrizFacil[i, j] = 11;
                        }
                        if (numeroDeMinasAVolta == 2 && MatrizFacil[i, j] != 8 && MatrizFacil[i, j] != 16 && MatrizFacil[i, j] != 5)
                        {
                            MatrizFacil[i, j] = 12;
                        }
                        if (numeroDeMinasAVolta == 3 && MatrizFacil[i, j] != 8 && MatrizFacil[i, j] != 16 && MatrizFacil[i, j] != 5)
                        {
                            MatrizFacil[i, j] = 13;
                        }
                        if (numeroDeMinasAVolta == 4 && MatrizFacil[i, j] != 8 && MatrizFacil[i, j] != 16 && MatrizFacil[i, j] != 5)
                        {
                            MatrizFacil[i, j] = 14;
                        }

                    }
                }
                //no final temos de meter todos os quadrados vazios que estão juntos à mostra
                int n = 5;//numero superior a metade da dimensao do tabuleiro
                int quadradosvaziosamostra;
                while (n != 0)
                {
                    for (i = 0; i < 9; i++)
                    {
                        for (j = 0; j < 9; j++)
                        {

                            quadradosvaziosamostra = Quadrados_vazios_a_mostra_a_volta_quadrado(i, j);

                            if (MatrizFacil[i, j] == 15 && quadradosvaziosamostra > 0)
                            {
                                MatrizFacil[i, j] = 5;
                            }
                            //agora por numeros à volta de quadrado vazio à mostra
                            if (MatrizFacil[i, j] == 11 && quadradosvaziosamostra > 0)
                            {
                                MatrizFacil[i, j] = 1;
                            }
                            if (MatrizFacil[i, j] == 12 && quadradosvaziosamostra > 0)
                            {
                                MatrizFacil[i, j] = 2;
                            }
                            if (MatrizFacil[i, j] == 13 && quadradosvaziosamostra > 0)
                            {
                                MatrizFacil[i, j] = 3;
                            }
                            if (MatrizFacil[i, j] == 14 && quadradosvaziosamostra > 0)
                            {
                                MatrizFacil[i, j] = 4;
                            }

                        }
                    }
                    n--;
                }


            }


            if (Dimensao == 16)
            {// jogo facil logo 10 minas tem de aparecer no tabuleiro

                int minas = 40;
                int i, j;

                MatrizFacil[_x, _y] = 5;
                //apartir desta coordenada será criado todo o tabuleiro
                // á volta do quadrado branco não pode ter nenhuma bomba

                //código 21, quadrados que não podem ser bombas mas podem ser números
                for (i = -1; i <= 1; i++)
                {
                    for (j = -1; j <= 1; j++)
                    {
                        if (_x + i >= 0 && _x + i <= 8 && _y + j >= 0 && _y + j <= 8 && (i != 0 || j != 0))
                        {
                            MatrizMedia[_x + i, _y + j] = 21;// quadrados escondidos sera tudo maioir que 10  logo vou por um numero >10 ex 19
                        }
                    }
                }

                //vamos meter as minas de forma aleatória pelo tabuleiro
                while (minas != 0)
                {
                    for (i = 0; i < 16; i++)
                    {
                        for (j = 0; j < 16; j++)
                        {
                            //cada quadrado só pode ter no maximo 4 minas á volta

                            if (MatrizMedia[i, j] == 19 &&
                                Aleatorio_Mina(Contador_de_quadrados_nao_preenchidos("Facil"), minas) == true &&
                                Minas_a_volta_quadrado(i, j) <= 0)
                            {
                                //se a matrir estiver 19(livre) e a funçao mina dar true vamos por uma mina nessa posição
                                MatrizMedia[i, j] = 16;//ainda vamos ter de alterar para mina escondida
                                minas--;
                            }

                        }
                    }
                }
                //depois de as minas estarem definidas vamos meter os numeros e os quadrados vazios
                int numeroDeMinasAVolta;
                for (i = 0; i < 16; i++)
                {
                    for (j = 0; j < 16; j++)
                    {
                        numeroDeMinasAVolta = Minas_a_volta_quadrado(i, j);

                        if (numeroDeMinasAVolta == 0 && MatrizMedia[i, j] != 8 && MatrizMedia[i, j] != 16 && MatrizMedia[i, j] != 5)
                        {
                            MatrizMedia[i, j] = 15;
                        }
                        if (numeroDeMinasAVolta == 1 && MatrizMedia[i, j] != 8 && MatrizMedia[i, j] != 16 && MatrizMedia[i, j] != 5)
                        {
                            MatrizMedia[i, j] = 11;
                        }
                        if (numeroDeMinasAVolta == 2 && MatrizMedia[i, j] != 8 && MatrizMedia[i, j] != 16 && MatrizMedia[i, j] != 5)
                        {
                            MatrizMedia[i, j] = 12;
                        }
                        if (numeroDeMinasAVolta == 3 && MatrizMedia[i, j] != 8 && MatrizMedia[i, j] != 16 && MatrizMedia[i, j] != 5)
                        {
                            MatrizMedia[i, j] = 13;
                        }
                        if (numeroDeMinasAVolta == 4 && MatrizMedia[i, j] != 8 && MatrizMedia[i, j] != 16 && MatrizMedia[i, j] != 5)
                        {
                            MatrizMedia[i, j] = 14;
                        }

                    }
                }
                //no final temos de meter todos os quadrados vazios que estão juntos à mostra
                int n = 10;//numero superior a metade da dimensao do tabuleiro
                int quadradosvaziosamostra;
                while (n != 0)
                {
                    for (i = 0; i < 16; i++)
                    {
                        for (j = 0; j < 16; j++)
                        {

                            quadradosvaziosamostra = Quadrados_vazios_a_mostra_a_volta_quadrado(i, j);

                            if (MatrizMedia[i, j] == 15 && quadradosvaziosamostra > 0)
                            {
                                MatrizMedia[i, j] = 5;
                            }
                            //agora por numeros à volta de quadrado vazio à mostra
                            if (MatrizMedia[i, j] == 11 && quadradosvaziosamostra > 0)
                            {
                                MatrizMedia[i, j] = 1;
                            }
                            if (MatrizMedia[i, j] == 12 && quadradosvaziosamostra > 0)
                            {
                                MatrizMedia[i, j] = 2;
                            }
                            if (MatrizMedia[i, j] == 13 && quadradosvaziosamostra > 0)
                            {
                                MatrizMedia[i, j] = 3;
                            }
                            if (MatrizMedia[i, j] == 14 && quadradosvaziosamostra > 0)
                            {
                                MatrizMedia[i, j] = 4;
                            }

                        }
                    }
                    n--;
                }


            }

        }

        //---------------------------------------------------------------------------------------------

        public bool Aleatorio_Mina(int _Quadrados_nao_preenchidos, int _minas)
        {

            Random randNum = new Random();
            int aleatorio = randNum.Next(1, _Quadrados_nao_preenchidos);

            if (aleatorio <= _minas)
            {
                return true;
            }
            else return false;

        }
        //----------------------------------------------------------------------------------



        //-----------------------------------------------------------------------------------

        //----------------------------------------------------------------------------------

        public int Contador_de_quadrados_nao_preenchidos(string _dificuldade)
        {
            int quadrados_nao_preenchidos = 0;
            if (_dificuldade == "Facil")
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizFacil[i, j] == 19)
                        {
                            quadrados_nao_preenchidos++;
                        }
                    }
                }
                return quadrados_nao_preenchidos;
            }
            if (_dificuldade == "Media")
            {
                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (MatrizMedia[i, j] == 19)
                        {
                            quadrados_nao_preenchidos++;
                        }
                    }
                }
                return quadrados_nao_preenchidos;
            }
            else return 0;
        }

        //------------------------------------------------------------------------------------

        public bool Verificar_se_peca_esta_escondida(int _x, int _y)
        {// vamos precisar des função pois se clicar num peça já à mostra o jogo não vai fazer nada
            if (Dimensao == 9)
            {
                if (MatrizFacil[_x, _y] > 10)
                {
                    return true;
                }
                else return false;
            }
            if (Dimensao == 16)
            {
                if (MatrizMedia[_x, _y] > 10)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        //--------------------------------------------------------------------------------------------------------------
        public int Minas_a_volta_quadrado(int _x, int _y)
        {
            int minas = 0;
            if (Dimensao == 9)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (_x + i >= 0 && _x + i <= 8 && _y + j >= 0 && _y + j <= 8)
                        {
                            if (MatrizFacil[_x + i, _y + j] == 8 || MatrizFacil[_x + i, _y + j] == 16)
                            {
                                minas++;
                            }
                        }
                    }
                }
            }
            if (Dimensao == 16)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (_x + i >= 0 && _x + i <= 15 && _y + j >= 0 && _y + j <= 15)
                        {
                            if (MatrizMedia[_x + i, _y + j] == 8 || MatrizMedia[_x + i, _y + j] == 16)
                            {
                                minas++;
                            }
                        }
                    }
                }
            }
            return minas;
        }
        //-------------------------------------------------------------------------------------------------------------
        public int Quadrados_vazios_a_mostra_a_volta_quadrado(int _x, int _y)
        {
            int QuadradosVazios = 0;
            if (Dimensao == 9)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (_x + i >= 0 && _x + i <= 8 && _y + j >= 0 && _y + j <= 8 && (i != 0 || j != 0))
                        {
                            if (MatrizFacil[_x + i, _y + j] == 5)
                            {
                                QuadradosVazios++;
                            }
                        }
                    }
                }
            }
            if (Dimensao == 16)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (_x + i >= 0 && _x + i <= 15 && _y + j >= 0 && _y + j <= 15 && (i != 0 || j != 0))
                        {
                            if (MatrizMedia[_x + i, _y + j] == 5)
                            {
                                QuadradosVazios++;
                            }
                        }
                    }
                }
            }
            return QuadradosVazios;
        }
        //--------------------------------------------------------------------------------------------------------------
        public bool Tem_Mina(int _x, int _y)
        {
            if (Dimensao == 9)
            {
                if (MatrizFacil[_x, _y] == 16)//16 codigo da mina escondida
                {
                    return true;
                }
                else return false;
            }
            if (Dimensao == 16)
            {
                if (MatrizMedia[_x, _y] == 16)
                {
                    return true;
                }
                else return false;
            }
            else return false;

        }
        //---------------------------------------------------------------------------------
        public bool Verificar_se_e_1_click()
        {
            bool verdade = true;
            if (Dimensao == 9)
            {
                
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizFacil[i, j] == 19 && verdade == true)
                        {
                            verdade = true;
                        }
                        else verdade = false;
                    }
                }
            }
            if (Dimensao == 16)
            {

                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (MatrizMedia[i, j] == 19 && verdade == true)
                        {
                            verdade = true;
                        }
                        else verdade = false;
                    }
                }

            }
            return verdade;
        }

        //-----------------------------------------------------------------------
        public void Click_Normal(int _x,int _y)
        {
            if (Dimensao == 9)
            {//se clicar num numero mostra o numero
                if (MatrizFacil[_x, _y] == 11)
                {
                    MatrizFacil[_x, _y] = 1;
                }
                if (MatrizFacil[_x, _y] == 12)
                {
                    MatrizFacil[_x, _y] = 2;
                }
                if (MatrizFacil[_x, _y] == 13)
                {
                    MatrizFacil[_x, _y] = 3;
                }
                if (MatrizFacil[_x, _y] == 14)
                {
                    MatrizFacil[_x, _y] = 4;
                }
                //se clicar num espaço em branco vai ter de mostrar os espaços em branco colados a este
                int n = 5;//numero superior a metade da dimensao do tabuleiro
                int i, j;
                if (MatrizFacil[_x, _y] == 15)
                {
                    MatrizFacil[_x, _y] = 5;
                    int Quadrados_Vazios_a_mostra;
                    while (n != 0)
                    {
                        for (i = 0; i < 9; i++)
                        {
                            for (j = 0; j < 9; j++)
                            {
                                Quadrados_Vazios_a_mostra = Quadrados_vazios_a_mostra_a_volta_quadrado(i, j);
                                if (MatrizFacil[i, j] == 15 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 5;
                                }
                                //agora por numeros à volta de quadrado vazio à mostra
                                if (MatrizFacil[i, j] == 11 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 1;
                                }
                                if (MatrizFacil[i, j] == 12 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 2;
                                }
                                if (MatrizFacil[i, j] == 13 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 3;
                                }
                                if (MatrizFacil[i, j] == 14 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 4;
                                }

                            }
                        }
                        n--;
                    }
                }
                //se clicar na mina vai ter de acabar o jogo e aparecer a mina vermelha
                if (MatrizFacil[_x, _y] == 16)
                {
                    MatrizFacil[_x, _y] = 9;
                }

            }

            if (Dimensao == 16)
            {
                //se clicar num numero mostra o numero
                if (MatrizMedia[_x, _y] == 11)
                {
                    MatrizMedia[_x, _y] = 1;
                }
                if (MatrizMedia[_x, _y] == 12)
                {
                    MatrizMedia[_x, _y] = 2;
                }
                if (MatrizMedia[_x, _y] == 13)
                {
                    MatrizMedia[_x, _y] = 3;
                }
                if (MatrizMedia[_x, _y] == 14)
                {
                    MatrizMedia[_x, _y] = 4;
                }
                //se clicar num espaço em branco vai ter de mostrar os espaços em branco colados a este
                int n = 10;//numero superior a metade da dimensao do tabuleiro
                int i, j;

                if (MatrizMedia[_x, _y] == 15)
                {
                    MatrizMedia[_x, _y] = 5;
                    int Quadrados_Vazios_a_mostra;

                        while (n != 0)
                    {
                        for (i = 0; i < 16; i++)
                        {
                            for (j = 0; j < 16; j++)
                            {
                                Quadrados_Vazios_a_mostra = Quadrados_vazios_a_mostra_a_volta_quadrado(i, j);
                                if (MatrizFacil[i, j] == 15 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 5;
                                }
                                //agora por numeros à volta de quadrado vazio à mostra
                                if (MatrizFacil[i, j] == 11 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 1;
                                }
                                if (MatrizFacil[i, j] == 12 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 2;
                                }
                                if (MatrizFacil[i, j] == 13 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 3;
                                }
                                if (MatrizFacil[i, j] == 14 && Quadrados_Vazios_a_mostra > 0)
                                {
                                    MatrizFacil[i, j] = 4;
                                }

                            }
                        }
                        n--;
                    }
                }
                //se clicar na mina vai ter de acabar o jogo e aparecer a mina vermelha
                if (MatrizMedia[_x, _y] == 16)
                {
                    MatrizMedia[_x, _y] = 9;
                }

            }

        }
        //-----------------------------------------------------------------------
        public void Click_Lado_Direito(int _x, int _y)
        {

            if (Dimensao == 9)
            {
                //meter bandeiras
                if (MatrizFacil[_x, _y] < 20)
                {
                    if (MatrizFacil[_x, _y] == 11)
                    {
                        MatrizFacil[_x, _y] = 31;
                    }
                    if (MatrizFacil[_x, _y] == 12)
                    {
                        MatrizFacil[_x, _y] = 32;
                    }
                    if (MatrizFacil[_x, _y] == 13)
                    {
                        MatrizFacil[_x, _y] = 33;
                    }
                    if (MatrizFacil[_x, _y] == 14)
                    {
                        MatrizFacil[_x, _y] = 34;
                    }
                    if (MatrizFacil[_x, _y] == 15)
                    {
                        MatrizFacil[_x, _y] = 35;
                    }
                    if (MatrizFacil[_x, _y] == 16)
                    {
                        MatrizFacil[_x, _y] = 36;
                    }
                    //atualizar o valoe de minas
                }
                else
                {        //tirar bandeiras
                    if (MatrizFacil[_x, _y] == 31)
                    {
                        MatrizFacil[_x, _y] = 11;
                    }
                    if (MatrizFacil[_x, _y] == 32)
                    {
                        MatrizFacil[_x, _y] = 12;
                    }
                    if (MatrizFacil[_x, _y] == 33)
                    {
                        MatrizFacil[_x, _y] = 13;
                    }
                    if (MatrizFacil[_x, _y] == 34)
                    {
                        MatrizFacil[_x, _y] = 14;
                    }
                    if (MatrizFacil[_x, _y] == 35)
                    {
                        MatrizFacil[_x, _y] = 15;
                    }
                    if (MatrizFacil[_x, _y] == 36)
                    {
                        MatrizFacil[_x, _y] = 16;
                    }
                }
                Numero_de_Minas = 10;
                if (Contador_Bandeiras() <= 10)
                {
                    Numero_de_Minas = Numero_de_Minas - Contador_Bandeiras();
                }
                if (Contador_Bandeiras() > 10)
                {
                    Numero_de_Minas = 0;
                }
            }
            if (Dimensao == 16)
            {
                //meter bandeiras
                if (MatrizMedia[_x, _y] < 20)
                {
                    if (MatrizMedia[_x, _y] == 11)
                    {
                        MatrizMedia[_x, _y] = 31;
                    }
                    if (MatrizMedia[_x, _y] == 12)
                    {
                        MatrizMedia[_x, _y] = 32;
                    }
                    if (MatrizMedia[_x, _y] == 13)
                    {
                        MatrizMedia[_x, _y] = 33;
                    }
                    if (MatrizMedia[_x, _y] == 14)
                    {
                        MatrizMedia[_x, _y] = 34;
                    }
                    if (MatrizMedia[_x, _y] == 15)
                    {
                        MatrizMedia[_x, _y] = 35;
                    }
                    if (MatrizMedia[_x, _y] == 16)
                    {
                        MatrizMedia[_x, _y] = 36;
                    }
                    //atualizar o valoe de minas
                }
                else
                {        //tirar bandeiras
                    if (MatrizMedia[_x, _y] == 31)
                    {
                        MatrizMedia[_x, _y] = 11;
                    }
                    if (MatrizMedia[_x, _y] == 32)
                    {
                        MatrizMedia[_x, _y] = 12;
                    }
                    if (MatrizMedia[_x, _y] == 33)
                    {
                        MatrizMedia[_x, _y] = 13;
                    }
                    if (MatrizMedia[_x, _y] == 34)
                    {
                        MatrizMedia[_x, _y] = 14;
                    }
                    if (MatrizMedia[_x, _y] == 35)
                    {
                        MatrizMedia[_x, _y] = 15;
                    }
                    if (MatrizMedia[_x, _y] == 36)
                    {
                        MatrizMedia[_x, _y] = 16;
                    }
                }
                Numero_de_Minas = 40;
                if (Contador_Bandeiras() <= 40)
                {
                    Numero_de_Minas = Numero_de_Minas - Contador_Bandeiras();
                }
                if (Contador_Bandeiras() > 40)
                {
                    Numero_de_Minas = 0;
                }
            }
        }

        public int Contador_Bandeiras()
        {
            int Bandeiras = 0;
            if (Dimensao == 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizFacil[i, j] < 37 && MatrizFacil[i, j] > 30)
                        {
                            Bandeiras++;
                        }
                    }
                }
                return Bandeiras;
            }
            if (Dimensao == 16)
            {
                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (MatrizMedia[i, j] < 37 && MatrizMedia[i, j] > 30)
                        {
                            Bandeiras++;
                        }
                    }
                }
                return Bandeiras;
            }
            else return 0;
        }

        //-----------------------------------------------------------------------
        public int Terminou_jogo()
        {
            int i, j;
            bool ganhou = true;
            bool perdeu = false;
            //o jogo termina quando todos os numeros e quadrados brancos já não estão escondidos 
            //logo só termina quando no tabuleiro tiver apenas: numeros ou quadrados vazios, minas escondidas, bandeiras(com mina escondida)
            if (Dimensao == 9)
            {
                for (i = 0; i < 9; i++)
                {
                    for (j = 0; j < 9; j++)
                    {
                        if ((MatrizFacil[i, j] <= 5 || MatrizFacil[i, j] == 16 || MatrizFacil[i, j] == 36) && ganhou)
                        {
                            ganhou = true;                       
                        }
                        else ganhou = false;//logo basta 1 dar falso dá tudo falso
                      
                    }
                }

                for (i = 0; i < 9; i++)
                {
                    for (j = 0; j < 9; j++)
                    {
                        if ((MatrizFacil[i, j] == 9) || perdeu)
                        {
                            perdeu = true;
                        }
                        else perdeu = false;//logo basta 1 dar verdade dá tudo verdade

                    }
                }
                if (ganhou == false && perdeu == false)
                {
                    return 0;//o jogo não terminou
                }
                if (ganhou == true && perdeu == false)
                {
                    return 1;//o jogo terminou e ganhou
                }
                if (ganhou == false && perdeu == true)
                {
                    return 2;//o jogo terminou e perdeu
                }
                else return 0;
            }
            if (Dimensao == 16)
            {
                for (i = 0; i < 16; i++)
                {
                    for (j = 0; j < 16; j++)
                    {
                        if ((MatrizMedia[i, j] <= 5 || MatrizMedia[i, j] == 16 || MatrizMedia[i, j] == 36) && ganhou)
                        {
                            ganhou = true;
                        }
                        else ganhou = false;//logo basta 1 dar falso dá tudo falso

                    }
                }

                for (i = 0; i < 16; i++)
                {
                    for (j = 0; j < 16; j++)
                    {
                        if ((MatrizMedia[i, j] == 9) || perdeu)
                        {
                            perdeu = true;
                        }
                        else perdeu = false;//logo basta 1 dar verdade dá tudo verdade

                    }
                }
                if (ganhou == false && perdeu == false)
                {
                    return 0;//o jogo não terminou
                }
                if (ganhou == true && perdeu == false)
                {
                    return 1;//o jogo terminou e ganhou
                }
                if (ganhou == false && perdeu == true)
                {
                    return 2;//o jogo terminou e perdeu
                }
                else return 0;
            }
            else return 0;

        }

        public void FreezeTabuleiro()
        {
            int i, j;

            if (Dimensao == 9)
            {
                for (i = 0; i < 9; i++)
                {
                    for (j = 0; j < 9; j++)
                    {
                        //quadrados à mostra ou butão
                        if (MatrizFacil[i, j] == 1)
                        {
                            MatrizFacil[i, j] = 41;
                        }
                        if (MatrizFacil[i, j] == 2)
                        {
                            MatrizFacil[i, j] = 42;
                        }
                        if (MatrizFacil[i, j] == 3)
                        {
                            MatrizFacil[i, j] = 43;
                        }
                        if (MatrizFacil[i, j] == 4)
                        {
                            MatrizFacil[i, j] = 44;
                        }
                        if (MatrizFacil[i, j] == 5)
                        {
                            MatrizFacil[i, j] = 45;
                        }
                        if (MatrizFacil[i, j] == 6)
                        {
                            MatrizFacil[i, j] = 46;
                        }
                        if (MatrizFacil[i, j] == 8)
                        {
                            MatrizFacil[i, j] = 48;
                        }
                        if (MatrizFacil[i, j] == 9)
                        {
                            MatrizFacil[i, j] = 49;
                        }
                        //quadrados escondidos
                        if (MatrizFacil[i, j] > 10 && MatrizFacil[i, j] < 20)
                        {
                            MatrizFacil[i, j] = 46;
                        }
                        //quadrados com bandeiras
                        if (MatrizFacil[i, j] > 30 && MatrizFacil[i, j] < 40)
                        {
                            MatrizFacil[i, j] = 47;
                        }
                    }
                }

            }
            if (Dimensao == 16)
            {
                for (i = 0; i < 16; i++)
                {
                    for (j = 0; j < 16; j++)
                    {
                        //quadrados à mostra ou butão
                        if (MatrizMedia[i, j] == 1)
                        {
                            MatrizMedia[i, j] = 41;
                        }
                        if (MatrizMedia[i, j] == 2)
                        {
                            MatrizMedia[i, j] = 42;
                        }
                        if (MatrizMedia[i, j] == 3)
                        {
                            MatrizMedia[i, j] = 43;
                        }
                        if (MatrizMedia[i, j] == 4)
                        {
                            MatrizMedia[i, j] = 44;
                        }
                        if (MatrizMedia[i, j] == 5)
                        {
                            MatrizMedia[i, j] = 45;
                        }
                        if (MatrizMedia[i, j] == 6)
                        {
                            MatrizMedia[i, j] = 46;
                        }
                        if (MatrizMedia[i, j] == 8)
                        {
                            MatrizMedia[i, j] = 48;
                        }
                        if (MatrizMedia[i, j] == 9)
                        {
                            MatrizMedia[i, j] = 49;
                        }
                        //quadrados escondidos
                        if (MatrizMedia[i, j] > 10 && MatrizMedia[i, j] < 20)
                        {
                            MatrizMedia[i, j] = 46;
                        }
                        //quadrados com bandeiras
                        if (MatrizMedia[i, j] > 30 && MatrizMedia[i, j] < 40)
                        {
                            MatrizMedia[i, j] = 47;
                        }
                    }
                }

              

            }
        }
    }
}
