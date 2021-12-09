using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Lab3
{
    public partial class FormJogarDificuldadeMedia : Form
    {
        Jogo Medio;
        private int Tempo;
        string tempoString;
        string MinasString;
        PictureBox[,] TabuleiroPictureBox = new PictureBox[16, 16];

        public FormJogarDificuldadeMedia()
        {
            InitializeComponent();
            Medio = new Jogo();

            Medio.Dificuldade = "Medio";
            //este modo já inicializa o tabuleiro de jogo
            Medio.Modo_de_Jogo();
        }

        private void FormJogarDificuldadeMedia_Load(object sender, EventArgs e)
        {
            Medio._tabuleiro.Criar_Tabuleiro_Inicial();
            timerDificuldadeMedia.Stop();
            Tempo = 0;
            labelTempoJogoMedio.Text = "000";
            labelMinas.Text = "040";
            Medio._tabuleiro.Numero_de_Minas = 40;

            Atualizar_quadrados();
        }
        //--------------------------------FUNCAO ATUALIZAR QUADRADOS------------------------------------
        private void Atualizar_quadrados()
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < 16; i++)
            {
                for (j = 0; j < 16; j++)
                {
                    TabuleiroPictureBox[i, j] = new PictureBox();
                }
            }

            //criamos uma matriz de pictureBox para o codigo ser mais pequeno
            for (i = 0; i < 16; i++)
            {
                for (j = 0; j < 16; j++)
                {
                    //---------------------DAS PEÇAS ESCONDIDAS----------------------------
                    if (Medio._tabuleiro.MatrizMedia[i, j] > 10 && Medio._tabuleiro.MatrizMedia[i, j] < 25)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazioButao;
                    }
                    //---------------------DAS PEÇAS Bandeira----------------------------
                    if (Medio._tabuleiro.MatrizMedia[i, j] > 30 && Medio._tabuleiro.MatrizMedia[i, j] < 40)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Bandeira;
                    }
                    //-------------------------PEÇAS A MOSTRA-----------------------------
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 1)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero1;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 2)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero2;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 3)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero3;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 4)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero4;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 5)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazio;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 6 || (Medio._tabuleiro.MatrizMedia[i, j] > 10 && Medio._tabuleiro.MatrizMedia[i, j] < 25))
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazioButao;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 8)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Mina;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 9)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.MinaVermelha;
                    }
                    //-------------------------PEÇAS Do Freeze-----------------------------
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 41)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero1;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 42)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero2;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 43)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero3;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 44)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero4;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 45)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazio;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 46)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazioButao;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 47)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Bandeira;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 48)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Mina;
                    }
                    if (Medio._tabuleiro.MatrizMedia[i, j] == 49)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.MinaVermelha;
                    }
                }
            }

            // Agora a cada picturebux do nosso windForm Vamos por a imagem correspondente á matriz de picturebx
            pictureBoxMedio_00I00.Image = TabuleiroPictureBox[0, 0].Image;
            pictureBoxMedio_00I01.Image = TabuleiroPictureBox[0, 1].Image;
            pictureBoxMedio_00I02.Image = TabuleiroPictureBox[0, 2].Image;
            pictureBoxMedio_00I03.Image = TabuleiroPictureBox[0, 3].Image;
            pictureBoxMedio_00I04.Image = TabuleiroPictureBox[0, 4].Image;
            pictureBoxMedio_00I05.Image = TabuleiroPictureBox[0, 5].Image;
            pictureBoxMedio_00I06.Image = TabuleiroPictureBox[0, 6].Image;
            pictureBoxMedio_00I07.Image = TabuleiroPictureBox[0, 7].Image;
            pictureBoxMedio_00I08.Image = TabuleiroPictureBox[0, 8].Image;
            pictureBoxMedio_00I09.Image = TabuleiroPictureBox[0, 9].Image;
            pictureBoxMedio_00I10.Image = TabuleiroPictureBox[0, 10].Image;
            pictureBoxMedio_00I11.Image = TabuleiroPictureBox[0, 11].Image;
            pictureBoxMedio_00I12.Image = TabuleiroPictureBox[0, 12].Image;
            pictureBoxMedio_00I13.Image = TabuleiroPictureBox[0, 13].Image;
            pictureBoxMedio_00I14.Image = TabuleiroPictureBox[0, 14].Image;
            pictureBoxMedio_00I15.Image = TabuleiroPictureBox[0, 15].Image;
            pictureBoxMedio_01I00.Image = TabuleiroPictureBox[1, 0].Image;
            pictureBoxMedio_01I01.Image = TabuleiroPictureBox[1, 1].Image;
            pictureBoxMedio_01I02.Image = TabuleiroPictureBox[1, 2].Image;
            pictureBoxMedio_01I03.Image = TabuleiroPictureBox[1, 3].Image;
            pictureBoxMedio_01I04.Image = TabuleiroPictureBox[1, 4].Image;
            pictureBoxMedio_01I05.Image = TabuleiroPictureBox[1, 5].Image;
            pictureBoxMedio_01I06.Image = TabuleiroPictureBox[1, 6].Image;
            pictureBoxMedio_01I07.Image = TabuleiroPictureBox[1, 7].Image;
            pictureBoxMedio_01I08.Image = TabuleiroPictureBox[1, 8].Image;
            pictureBoxMedio_01I09.Image = TabuleiroPictureBox[1, 9].Image;
            pictureBoxMedio_01I10.Image = TabuleiroPictureBox[1, 10].Image;
            pictureBoxMedio_01I11.Image = TabuleiroPictureBox[1, 11].Image;
            pictureBoxMedio_01I12.Image = TabuleiroPictureBox[1, 12].Image;
            pictureBoxMedio_01I13.Image = TabuleiroPictureBox[1, 13].Image;
            pictureBoxMedio_01I14.Image = TabuleiroPictureBox[1, 14].Image;
            pictureBoxMedio_01I15.Image = TabuleiroPictureBox[1, 15].Image;
            pictureBoxMedio_02I00.Image = TabuleiroPictureBox[2, 0].Image;
            pictureBoxMedio_02I01.Image = TabuleiroPictureBox[2, 1].Image;
            pictureBoxMedio_02I02.Image = TabuleiroPictureBox[2, 2].Image;
            pictureBoxMedio_02I03.Image = TabuleiroPictureBox[2, 3].Image;
            pictureBoxMedio_02I04.Image = TabuleiroPictureBox[2, 4].Image;
            pictureBoxMedio_02I05.Image = TabuleiroPictureBox[2, 5].Image;
            pictureBoxMedio_02I06.Image = TabuleiroPictureBox[2, 6].Image;
            pictureBoxMedio_02I07.Image = TabuleiroPictureBox[2, 7].Image;
            pictureBoxMedio_02I08.Image = TabuleiroPictureBox[2, 8].Image;
            pictureBoxMedio_02I09.Image = TabuleiroPictureBox[2, 9].Image;
            pictureBoxMedio_02I10.Image = TabuleiroPictureBox[2, 10].Image;
            pictureBoxMedio_02I11.Image = TabuleiroPictureBox[2, 11].Image;
            pictureBoxMedio_02I12.Image = TabuleiroPictureBox[2, 12].Image;
            pictureBoxMedio_02I13.Image = TabuleiroPictureBox[2, 13].Image;
            pictureBoxMedio_02I14.Image = TabuleiroPictureBox[2, 14].Image;
            pictureBoxMedio_02I15.Image = TabuleiroPictureBox[2, 15].Image;
            pictureBoxMedio_03I00.Image = TabuleiroPictureBox[3, 0].Image;
            pictureBoxMedio_03I01.Image = TabuleiroPictureBox[3, 1].Image;
            pictureBoxMedio_03I02.Image = TabuleiroPictureBox[3, 2].Image;
            pictureBoxMedio_03I03.Image = TabuleiroPictureBox[3, 3].Image;
            pictureBoxMedio_03I04.Image = TabuleiroPictureBox[3, 4].Image;
            pictureBoxMedio_03I05.Image = TabuleiroPictureBox[3, 5].Image;
            pictureBoxMedio_03I06.Image = TabuleiroPictureBox[3, 6].Image;
            pictureBoxMedio_03I07.Image = TabuleiroPictureBox[3, 7].Image;
            pictureBoxMedio_03I08.Image = TabuleiroPictureBox[3, 8].Image;
            pictureBoxMedio_03I09.Image = TabuleiroPictureBox[3, 9].Image;
            pictureBoxMedio_03I10.Image = TabuleiroPictureBox[3, 10].Image;
            pictureBoxMedio_03I11.Image = TabuleiroPictureBox[3, 11].Image;
            pictureBoxMedio_03I12.Image = TabuleiroPictureBox[3, 12].Image;
            pictureBoxMedio_03I13.Image = TabuleiroPictureBox[3, 13].Image;
            pictureBoxMedio_03I14.Image = TabuleiroPictureBox[3, 14].Image;
            pictureBoxMedio_03I15.Image = TabuleiroPictureBox[3, 15].Image;
            pictureBoxMedio_04I00.Image = TabuleiroPictureBox[4, 0].Image;
            pictureBoxMedio_04I01.Image = TabuleiroPictureBox[4, 1].Image;
            pictureBoxMedio_04I02.Image = TabuleiroPictureBox[4, 2].Image;
            pictureBoxMedio_04I03.Image = TabuleiroPictureBox[4, 3].Image;
            pictureBoxMedio_04I04.Image = TabuleiroPictureBox[4, 4].Image;
            pictureBoxMedio_04I05.Image = TabuleiroPictureBox[4, 5].Image;
            pictureBoxMedio_04I06.Image = TabuleiroPictureBox[4, 6].Image;
            pictureBoxMedio_04I07.Image = TabuleiroPictureBox[4, 7].Image;
            pictureBoxMedio_04I08.Image = TabuleiroPictureBox[4, 8].Image;
            pictureBoxMedio_04I09.Image = TabuleiroPictureBox[4, 9].Image;
            pictureBoxMedio_04I10.Image = TabuleiroPictureBox[4, 10].Image;
            pictureBoxMedio_04I11.Image = TabuleiroPictureBox[4, 11].Image;
            pictureBoxMedio_04I12.Image = TabuleiroPictureBox[4, 12].Image;
            pictureBoxMedio_04I13.Image = TabuleiroPictureBox[4, 13].Image;
            pictureBoxMedio_04I14.Image = TabuleiroPictureBox[4, 14].Image;
            pictureBoxMedio_04I15.Image = TabuleiroPictureBox[4, 15].Image;
            pictureBoxMedio_05I00.Image = TabuleiroPictureBox[5, 0].Image;
            pictureBoxMedio_05I01.Image = TabuleiroPictureBox[5, 1].Image;
            pictureBoxMedio_05I02.Image = TabuleiroPictureBox[5, 2].Image;
            pictureBoxMedio_05I03.Image = TabuleiroPictureBox[5, 3].Image;
            pictureBoxMedio_05I04.Image = TabuleiroPictureBox[5, 4].Image;
            pictureBoxMedio_05I05.Image = TabuleiroPictureBox[5, 5].Image;
            pictureBoxMedio_05I06.Image = TabuleiroPictureBox[5, 6].Image;
            pictureBoxMedio_05I07.Image = TabuleiroPictureBox[5, 7].Image;
            pictureBoxMedio_05I08.Image = TabuleiroPictureBox[5, 8].Image;
            pictureBoxMedio_05I09.Image = TabuleiroPictureBox[5, 9].Image;
            pictureBoxMedio_05I10.Image = TabuleiroPictureBox[5, 10].Image;
            pictureBoxMedio_05I11.Image = TabuleiroPictureBox[5, 11].Image;
            pictureBoxMedio_05I12.Image = TabuleiroPictureBox[5, 12].Image;
            pictureBoxMedio_05I13.Image = TabuleiroPictureBox[5, 13].Image;
            pictureBoxMedio_05I14.Image = TabuleiroPictureBox[5, 14].Image;
            pictureBoxMedio_05I15.Image = TabuleiroPictureBox[5, 15].Image;
            pictureBoxMedio_06I00.Image = TabuleiroPictureBox[6, 0].Image;
            pictureBoxMedio_06I01.Image = TabuleiroPictureBox[6, 1].Image;
            pictureBoxMedio_06I02.Image = TabuleiroPictureBox[6, 2].Image;
            pictureBoxMedio_06I03.Image = TabuleiroPictureBox[6, 3].Image;
            pictureBoxMedio_06I04.Image = TabuleiroPictureBox[6, 4].Image;
            pictureBoxMedio_06I05.Image = TabuleiroPictureBox[6, 5].Image;
            pictureBoxMedio_06I06.Image = TabuleiroPictureBox[6, 6].Image;
            pictureBoxMedio_06I07.Image = TabuleiroPictureBox[6, 7].Image;
            pictureBoxMedio_06I08.Image = TabuleiroPictureBox[6, 8].Image;
            pictureBoxMedio_06I09.Image = TabuleiroPictureBox[6, 9].Image;
            pictureBoxMedio_06I10.Image = TabuleiroPictureBox[6, 10].Image;
            pictureBoxMedio_06I11.Image = TabuleiroPictureBox[6, 11].Image;
            pictureBoxMedio_06I12.Image = TabuleiroPictureBox[6, 12].Image;
            pictureBoxMedio_06I13.Image = TabuleiroPictureBox[6, 13].Image;
            pictureBoxMedio_06I14.Image = TabuleiroPictureBox[6, 14].Image;
            pictureBoxMedio_06I15.Image = TabuleiroPictureBox[6, 15].Image;
            pictureBoxMedio_07I00.Image = TabuleiroPictureBox[7, 0].Image;
            pictureBoxMedio_07I01.Image = TabuleiroPictureBox[7, 1].Image;
            pictureBoxMedio_07I02.Image = TabuleiroPictureBox[7, 2].Image;
            pictureBoxMedio_07I03.Image = TabuleiroPictureBox[7, 3].Image;
            pictureBoxMedio_07I04.Image = TabuleiroPictureBox[7, 4].Image;
            pictureBoxMedio_07I05.Image = TabuleiroPictureBox[7, 5].Image;
            pictureBoxMedio_07I06.Image = TabuleiroPictureBox[7, 6].Image;
            pictureBoxMedio_07I07.Image = TabuleiroPictureBox[7, 7].Image;
            pictureBoxMedio_07I08.Image = TabuleiroPictureBox[7, 8].Image;
            pictureBoxMedio_07I09.Image = TabuleiroPictureBox[7, 9].Image;
            pictureBoxMedio_07I10.Image = TabuleiroPictureBox[7, 10].Image;
            pictureBoxMedio_07I11.Image = TabuleiroPictureBox[7, 11].Image;
            pictureBoxMedio_07I12.Image = TabuleiroPictureBox[7, 12].Image;
            pictureBoxMedio_07I13.Image = TabuleiroPictureBox[7, 13].Image;
            pictureBoxMedio_07I14.Image = TabuleiroPictureBox[7, 14].Image;
            pictureBoxMedio_07I15.Image = TabuleiroPictureBox[7, 15].Image;
            pictureBoxMedio_08I00.Image = TabuleiroPictureBox[8, 0].Image;
            pictureBoxMedio_08I01.Image = TabuleiroPictureBox[8, 1].Image;
            pictureBoxMedio_08I02.Image = TabuleiroPictureBox[8, 2].Image;
            pictureBoxMedio_08I03.Image = TabuleiroPictureBox[8, 3].Image;
            pictureBoxMedio_08I04.Image = TabuleiroPictureBox[8, 4].Image;
            pictureBoxMedio_08I05.Image = TabuleiroPictureBox[8, 5].Image;
            pictureBoxMedio_08I06.Image = TabuleiroPictureBox[8, 6].Image;
            pictureBoxMedio_08I07.Image = TabuleiroPictureBox[8, 7].Image;
            pictureBoxMedio_08I08.Image = TabuleiroPictureBox[8, 8].Image;
            pictureBoxMedio_08I09.Image = TabuleiroPictureBox[8, 9].Image;
            pictureBoxMedio_08I10.Image = TabuleiroPictureBox[8, 10].Image;
            pictureBoxMedio_08I11.Image = TabuleiroPictureBox[8, 11].Image;
            pictureBoxMedio_08I12.Image = TabuleiroPictureBox[8, 12].Image;
            pictureBoxMedio_08I13.Image = TabuleiroPictureBox[8, 13].Image;
            pictureBoxMedio_08I14.Image = TabuleiroPictureBox[8, 14].Image;
            pictureBoxMedio_08I15.Image = TabuleiroPictureBox[8, 15].Image;
            pictureBoxMedio_09I00.Image = TabuleiroPictureBox[9, 0].Image;
            pictureBoxMedio_09I01.Image = TabuleiroPictureBox[9, 1].Image;
            pictureBoxMedio_09I02.Image = TabuleiroPictureBox[9, 2].Image;
            pictureBoxMedio_09I03.Image = TabuleiroPictureBox[9, 3].Image;
            pictureBoxMedio_09I04.Image = TabuleiroPictureBox[9, 4].Image;
            pictureBoxMedio_09I05.Image = TabuleiroPictureBox[9, 5].Image;
            pictureBoxMedio_09I06.Image = TabuleiroPictureBox[9, 6].Image;
            pictureBoxMedio_09I07.Image = TabuleiroPictureBox[9, 7].Image;
            pictureBoxMedio_09I08.Image = TabuleiroPictureBox[9, 8].Image;
            pictureBoxMedio_09I09.Image = TabuleiroPictureBox[9, 9].Image;
            pictureBoxMedio_09I10.Image = TabuleiroPictureBox[9, 10].Image;
            pictureBoxMedio_09I11.Image = TabuleiroPictureBox[9, 11].Image;
            pictureBoxMedio_09I12.Image = TabuleiroPictureBox[9, 12].Image;
            pictureBoxMedio_09I13.Image = TabuleiroPictureBox[9, 13].Image;
            pictureBoxMedio_09I14.Image = TabuleiroPictureBox[9, 14].Image;
            pictureBoxMedio_09I15.Image = TabuleiroPictureBox[9, 15].Image;
            pictureBoxMedio_10I00.Image = TabuleiroPictureBox[10, 0].Image;
            pictureBoxMedio_10I01.Image = TabuleiroPictureBox[10, 1].Image;
            pictureBoxMedio_10I02.Image = TabuleiroPictureBox[10, 2].Image;
            pictureBoxMedio_10I03.Image = TabuleiroPictureBox[10, 3].Image;
            pictureBoxMedio_10I04.Image = TabuleiroPictureBox[10, 4].Image;
            pictureBoxMedio_10I05.Image = TabuleiroPictureBox[10, 5].Image;
            pictureBoxMedio_10I06.Image = TabuleiroPictureBox[10, 6].Image;
            pictureBoxMedio_10I07.Image = TabuleiroPictureBox[10, 7].Image;
            pictureBoxMedio_10I08.Image = TabuleiroPictureBox[10, 8].Image;
            pictureBoxMedio_10I09.Image = TabuleiroPictureBox[10, 9].Image;
            pictureBoxMedio_10I10.Image = TabuleiroPictureBox[10, 10].Image;
            pictureBoxMedio_10I11.Image = TabuleiroPictureBox[10, 11].Image;
            pictureBoxMedio_10I12.Image = TabuleiroPictureBox[10, 12].Image;
            pictureBoxMedio_10I13.Image = TabuleiroPictureBox[10, 13].Image;
            pictureBoxMedio_10I14.Image = TabuleiroPictureBox[10, 14].Image;
            pictureBoxMedio_10I15.Image = TabuleiroPictureBox[10, 15].Image;
            pictureBoxMedio_11I00.Image = TabuleiroPictureBox[11, 0].Image;
            pictureBoxMedio_11I01.Image = TabuleiroPictureBox[11, 1].Image;
            pictureBoxMedio_11I02.Image = TabuleiroPictureBox[11, 2].Image;
            pictureBoxMedio_11I03.Image = TabuleiroPictureBox[11, 3].Image;
            pictureBoxMedio_11I04.Image = TabuleiroPictureBox[11, 4].Image;
            pictureBoxMedio_11I05.Image = TabuleiroPictureBox[11, 5].Image;
            pictureBoxMedio_11I06.Image = TabuleiroPictureBox[11, 6].Image;
            pictureBoxMedio_11I07.Image = TabuleiroPictureBox[11, 7].Image;
            pictureBoxMedio_11I08.Image = TabuleiroPictureBox[11, 8].Image;
            pictureBoxMedio_11I09.Image = TabuleiroPictureBox[11, 9].Image;
            pictureBoxMedio_11I10.Image = TabuleiroPictureBox[11, 10].Image;
            pictureBoxMedio_11I11.Image = TabuleiroPictureBox[11, 11].Image;
            pictureBoxMedio_11I12.Image = TabuleiroPictureBox[11, 12].Image;
            pictureBoxMedio_11I13.Image = TabuleiroPictureBox[11, 13].Image;
            pictureBoxMedio_11I14.Image = TabuleiroPictureBox[11, 14].Image;
            pictureBoxMedio_11I15.Image = TabuleiroPictureBox[11, 15].Image;
            pictureBoxMedio_12I00.Image = TabuleiroPictureBox[12, 0].Image;
            pictureBoxMedio_12I01.Image = TabuleiroPictureBox[12, 1].Image;
            pictureBoxMedio_12I02.Image = TabuleiroPictureBox[12, 2].Image;
            pictureBoxMedio_12I03.Image = TabuleiroPictureBox[12, 3].Image;
            pictureBoxMedio_12I04.Image = TabuleiroPictureBox[12, 4].Image;
            pictureBoxMedio_12I05.Image = TabuleiroPictureBox[12, 5].Image;
            pictureBoxMedio_12I06.Image = TabuleiroPictureBox[12, 6].Image;
            pictureBoxMedio_12I07.Image = TabuleiroPictureBox[12, 7].Image;
            pictureBoxMedio_12I08.Image = TabuleiroPictureBox[12, 8].Image;
            pictureBoxMedio_12I09.Image = TabuleiroPictureBox[12, 9].Image;
            pictureBoxMedio_12I10.Image = TabuleiroPictureBox[12, 10].Image;
            pictureBoxMedio_12I11.Image = TabuleiroPictureBox[12, 11].Image;
            pictureBoxMedio_12I12.Image = TabuleiroPictureBox[12, 12].Image;
            pictureBoxMedio_12I13.Image = TabuleiroPictureBox[12, 13].Image;
            pictureBoxMedio_12I14.Image = TabuleiroPictureBox[12, 14].Image;
            pictureBoxMedio_12I15.Image = TabuleiroPictureBox[12, 15].Image;
            pictureBoxMedio_13I00.Image = TabuleiroPictureBox[13, 0].Image;
            pictureBoxMedio_13I01.Image = TabuleiroPictureBox[13, 1].Image;
            pictureBoxMedio_13I02.Image = TabuleiroPictureBox[13, 2].Image;
            pictureBoxMedio_13I03.Image = TabuleiroPictureBox[13, 3].Image;
            pictureBoxMedio_13I04.Image = TabuleiroPictureBox[13, 4].Image;
            pictureBoxMedio_13I05.Image = TabuleiroPictureBox[13, 5].Image;
            pictureBoxMedio_13I06.Image = TabuleiroPictureBox[13, 6].Image;
            pictureBoxMedio_13I07.Image = TabuleiroPictureBox[13, 7].Image;
            pictureBoxMedio_13I08.Image = TabuleiroPictureBox[13, 8].Image;
            pictureBoxMedio_13I09.Image = TabuleiroPictureBox[13, 9].Image;
            pictureBoxMedio_13I10.Image = TabuleiroPictureBox[13, 10].Image;
            pictureBoxMedio_13I11.Image = TabuleiroPictureBox[13, 11].Image;
            pictureBoxMedio_13I12.Image = TabuleiroPictureBox[13, 12].Image;
            pictureBoxMedio_13I13.Image = TabuleiroPictureBox[13, 13].Image;
            pictureBoxMedio_13I14.Image = TabuleiroPictureBox[13, 14].Image;
            pictureBoxMedio_13I15.Image = TabuleiroPictureBox[13, 15].Image;
            pictureBoxMedio_14I00.Image = TabuleiroPictureBox[14, 0].Image;
            pictureBoxMedio_14I01.Image = TabuleiroPictureBox[14, 1].Image;
            pictureBoxMedio_14I02.Image = TabuleiroPictureBox[14, 2].Image;
            pictureBoxMedio_14I03.Image = TabuleiroPictureBox[14, 3].Image;
            pictureBoxMedio_14I04.Image = TabuleiroPictureBox[14, 4].Image;
            pictureBoxMedio_14I05.Image = TabuleiroPictureBox[14, 5].Image;
            pictureBoxMedio_14I06.Image = TabuleiroPictureBox[14, 6].Image;
            pictureBoxMedio_14I07.Image = TabuleiroPictureBox[14, 7].Image;
            pictureBoxMedio_14I08.Image = TabuleiroPictureBox[14, 8].Image;
            pictureBoxMedio_14I09.Image = TabuleiroPictureBox[14, 9].Image;
            pictureBoxMedio_14I10.Image = TabuleiroPictureBox[14, 10].Image;
            pictureBoxMedio_14I11.Image = TabuleiroPictureBox[14, 11].Image;
            pictureBoxMedio_14I12.Image = TabuleiroPictureBox[14, 12].Image;
            pictureBoxMedio_14I13.Image = TabuleiroPictureBox[14, 13].Image;
            pictureBoxMedio_14I14.Image = TabuleiroPictureBox[14, 14].Image;
            pictureBoxMedio_14I15.Image = TabuleiroPictureBox[14, 15].Image;
            pictureBoxMedio_15I00.Image = TabuleiroPictureBox[15, 0].Image;
            pictureBoxMedio_15I01.Image = TabuleiroPictureBox[15, 1].Image;
            pictureBoxMedio_15I02.Image = TabuleiroPictureBox[15, 2].Image;
            pictureBoxMedio_15I03.Image = TabuleiroPictureBox[15, 3].Image;
            pictureBoxMedio_15I04.Image = TabuleiroPictureBox[15, 4].Image;
            pictureBoxMedio_15I05.Image = TabuleiroPictureBox[15, 5].Image;
            pictureBoxMedio_15I06.Image = TabuleiroPictureBox[15, 6].Image;
            pictureBoxMedio_15I07.Image = TabuleiroPictureBox[15, 7].Image;
            pictureBoxMedio_15I08.Image = TabuleiroPictureBox[15, 8].Image;
            pictureBoxMedio_15I09.Image = TabuleiroPictureBox[15, 9].Image;
            pictureBoxMedio_15I10.Image = TabuleiroPictureBox[15, 10].Image;
            pictureBoxMedio_15I11.Image = TabuleiroPictureBox[15, 11].Image;
            pictureBoxMedio_15I12.Image = TabuleiroPictureBox[15, 12].Image;
            pictureBoxMedio_15I13.Image = TabuleiroPictureBox[15, 13].Image;
            pictureBoxMedio_15I14.Image = TabuleiroPictureBox[15, 14].Image;
            pictureBoxMedio_15I15.Image = TabuleiroPictureBox[15, 15].Image;
        }

        private void timerDificuldadeMedia_Tick_1(object sender, EventArgs e)
        {
            //------------------------CONTADOR DE TEMPO------------------------------

            Tempo++;
            if (Tempo <= 9)
            {
                tempoString = "00" + Tempo.ToString();
            }
            if (Tempo <= 99 && Tempo > 9)
            {
                tempoString = "0" + Tempo.ToString();
            }
            if (Tempo > 99)
            {
                tempoString = "" + Tempo.ToString();
            }
            labelTempoJogoMedio.Text = tempoString;
            if (Tempo >= 999)//fim do tempo
            {
                timerDificuldadeMedia.Stop();
                MensagemPerdeu();
                Medio._tabuleiro.FreezeTabuleiro();
            }

            //------------------------CONTADOR DE MINAS------------------------------

            if (Medio._tabuleiro.Numero_de_Minas <= 9)
            {
                MinasString = "00" + Medio._tabuleiro.Numero_de_Minas.ToString();
            }
            if (Medio._tabuleiro.Numero_de_Minas <= 99 && Medio._tabuleiro.Numero_de_Minas > 9)
            {
                MinasString = "0" + Medio._tabuleiro.Numero_de_Minas.ToString();
            }
            if (Medio._tabuleiro.Numero_de_Minas > 99)
            {
                MinasString = "" + Medio._tabuleiro.Numero_de_Minas.ToString();
            }

            labelMinas.Text = MinasString;
        }
      


        //picture box recomeçar click
        private void pictureBoxRecomecarDificuldadeMedia_Click(object sender, EventArgs e)
        {
            Medio._tabuleiro.Criar_Tabuleiro_Inicial();
            timerDificuldadeMedia.Stop();
            Tempo = 0;
            labelTempoJogoMedio.Text = "000";
            labelMinas.Text = "040";
            Medio._tabuleiro.Numero_de_Minas = 40;
            
            Atualizar_quadrados();
        }

        private void MensagemGanhou()
        {
            MessageBox.Show("Ganhou");
        }
        private void MensagemPerdeu()
        {
            MessageBox.Show("Perdeu");
        }

        private void ClickLadoEsquerdo(int _x, int _y)
        {
            if (Medio._tabuleiro.Verificar_se_e_1_click() == true)
            {
                timerDificuldadeMedia.Start();
                Medio._tabuleiro.Criar_Tabuleiro_Primeiro_Click(_x, _y);
               
            }
            else
            {
                Medio._tabuleiro.Click_Normal(_x, _y);
                Atualizar_quadrados();
                if (Medio._tabuleiro.Terminou_jogo() == 1)//terminou o jogo e ganhou
                {
                    timerDificuldadeMedia.Stop();
                    MensagemGanhou();
                    Medio._tabuleiro.FreezeTabuleiro();

                    //agora aqui vamos ter de implementar os registos em ficheiro

                }
                if (Medio._tabuleiro.Terminou_jogo() == 2)//terminou o jogo e perdeu
                {
                    timerDificuldadeMedia.Stop();
                    MensagemPerdeu();
                    Medio._tabuleiro.FreezeTabuleiro();
                }
            }
            Atualizar_quadrados();
        }

        private void ClickLadoDireito(int _x, int _y)
        {
            Medio._tabuleiro.Click_Lado_Direito(_x, _y);
            Atualizar_quadrados();
        }

        //----------------------------------PICTURE BOX TODAS-------------------------------------------------

        private void pictureBoxMedio_00I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 0);
            }
        }
        private void pictureBoxMedio_00I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 1);
            }
        }
        private void pictureBoxMedio_00I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 2);
            }
        }
        private void pictureBoxMedio_00I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 3);
            }
        }
        private void pictureBoxMedio_00I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 4);
            }
        }
        private void pictureBoxMedio_00I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 5);
            }
        }
        private void pictureBoxMedio_00I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 6);
            }
        }
        private void pictureBoxMedio_00I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 7);
            }
        }
        private void pictureBoxMedio_00I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 8);
            }
        }
        private void pictureBoxMedio_00I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 9);
            }
        }
        private void pictureBoxMedio_00I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 10);
            }
        }
        private void pictureBoxMedio_00I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 11);
            }
        }
        private void pictureBoxMedio_00I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 12);
            }
        }
        private void pictureBoxMedio_00I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 13);
            }
        }
        private void pictureBoxMedio_00I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 14);
            }
        }
        private void pictureBoxMedio_00I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(0, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(0, 15);
            }
        }
        private void pictureBoxMedio_01I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 0);
            }
        }
        private void pictureBoxMedio_01I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 1);
            }
        }
        private void pictureBoxMedio_01I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 2);
            }
        }
        private void pictureBoxMedio_01I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 3);
            }
        }
        private void pictureBoxMedio_01I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 4);
            }
        }
        private void pictureBoxMedio_01I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 5);
            }
        }
        private void pictureBoxMedio_01I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 6);
            }
        }
        private void pictureBoxMedio_01I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 7);
            }
        }
        private void pictureBoxMedio_01I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 8);
            }
        }
        private void pictureBoxMedio_01I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 9);
            }
        }
        private void pictureBoxMedio_01I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 10);
            }
        }
        private void pictureBoxMedio_01I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 11);
            }
        }
        private void pictureBoxMedio_01I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 12);
            }
        }
        private void pictureBoxMedio_01I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 13);
            }
        }
        private void pictureBoxMedio_01I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 14);
            }
        }
        private void pictureBoxMedio_01I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(1, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(1, 15);
            }
        }
        private void pictureBoxMedio_02I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 0);
            }
        }
        private void pictureBoxMedio_02I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 1);
            }
        }
        private void pictureBoxMedio_02I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 2);
            }
        }
        private void pictureBoxMedio_02I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 3);
            }
        }
        private void pictureBoxMedio_02I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 4);
            }
        }
        private void pictureBoxMedio_02I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 5);
            }
        }
        private void pictureBoxMedio_02I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 6);
            }
        }
        private void pictureBoxMedio_02I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 7);
            }
        }
        private void pictureBoxMedio_02I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 8);
            }
        }
        private void pictureBoxMedio_02I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 9);
            }
        }
        private void pictureBoxMedio_02I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 10);
            }
        }
        private void pictureBoxMedio_02I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 11);
            }
        }
        private void pictureBoxMedio_02I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 12);
            }
        }
        private void pictureBoxMedio_02I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 13);
            }
        }
        private void pictureBoxMedio_02I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 14);
            }
        }
        private void pictureBoxMedio_02I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(2, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(2, 15);
            }
        }
        private void pictureBoxMedio_03I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 0);
            }
        }
        private void pictureBoxMedio_03I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 1);
            }
        }
        private void pictureBoxMedio_03I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 2);
            }
        }
        private void pictureBoxMedio_03I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 3);
            }
        }
        private void pictureBoxMedio_03I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 4);
            }
        }
        private void pictureBoxMedio_03I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 5);
            }
        }
        private void pictureBoxMedio_03I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 6);
            }
        }
        private void pictureBoxMedio_03I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 7);
            }
        }
        private void pictureBoxMedio_03I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 8);
            }
        }
        private void pictureBoxMedio_03I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 9);
            }
        }
        private void pictureBoxMedio_03I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 10);
            }
        }
        private void pictureBoxMedio_03I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 11);
            }
        }
        private void pictureBoxMedio_03I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 12);
            }
        }
        private void pictureBoxMedio_03I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 13);
            }
        }
        private void pictureBoxMedio_03I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 14);
            }
        }
        private void pictureBoxMedio_03I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(3, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(3, 15);
            }
        }
        private void pictureBoxMedio_04I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 0);
            }
        }
        private void pictureBoxMedio_04I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 1);
            }
        }
        private void pictureBoxMedio_04I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 2);
            }
        }
        private void pictureBoxMedio_04I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 3);
            }
        }
        private void pictureBoxMedio_04I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 4);
            }
        }
        private void pictureBoxMedio_04I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 5);
            }
        }
        private void pictureBoxMedio_04I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 6);
            }
        }
        private void pictureBoxMedio_04I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 7);
            }
        }
        private void pictureBoxMedio_04I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 8);
            }
        }
        private void pictureBoxMedio_04I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 9);
            }
        }
        private void pictureBoxMedio_04I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 10);
            }
        }
        private void pictureBoxMedio_04I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 11);
            }
        }
        private void pictureBoxMedio_04I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 12);
            }
        }
        private void pictureBoxMedio_04I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 13);
            }
        }
        private void pictureBoxMedio_04I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 14);
            }
        }
        private void pictureBoxMedio_04I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(4, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(4, 15);
            }
        }
        private void pictureBoxMedio_05I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 0);
            }
        }
        private void pictureBoxMedio_05I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 1);
            }
        }
        private void pictureBoxMedio_05I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 2);
            }
        }
        private void pictureBoxMedio_05I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 3);
            }
        }
        private void pictureBoxMedio_05I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 4);
            }
        }
        private void pictureBoxMedio_05I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 5);
            }
        }
        private void pictureBoxMedio_05I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 6);
            }
        }
        private void pictureBoxMedio_05I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 7);
            }
        }
        private void pictureBoxMedio_05I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 8);
            }
        }
        private void pictureBoxMedio_05I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 9);
            }
        }
        private void pictureBoxMedio_05I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 10);
            }
        }
        private void pictureBoxMedio_05I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 11);
            }
        }
        private void pictureBoxMedio_05I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 12);
            }
        }
        private void pictureBoxMedio_05I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 13);
            }
        }
        private void pictureBoxMedio_05I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 14);
            }
        }
        private void pictureBoxMedio_05I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(5, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(5, 15);
            }
        }
        private void pictureBoxMedio_06I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 0);
            }
        }
        private void pictureBoxMedio_06I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 1);
            }
        }
        private void pictureBoxMedio_06I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 2);
            }
        }
        private void pictureBoxMedio_06I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 3);
            }
        }
        private void pictureBoxMedio_06I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 4);
            }
        }
        private void pictureBoxMedio_06I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 5);
            }
        }
        private void pictureBoxMedio_06I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 6);
            }
        }
        private void pictureBoxMedio_06I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 7);
            }
        }
        private void pictureBoxMedio_06I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 8);
            }
        }
        private void pictureBoxMedio_06I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 9);
            }
        }
        private void pictureBoxMedio_06I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 10);
            }
        }
        private void pictureBoxMedio_06I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 11);
            }
        }
        private void pictureBoxMedio_06I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 12);
            }
        }
        private void pictureBoxMedio_06I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 13);
            }
        }
        private void pictureBoxMedio_06I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 14);
            }
        }
        private void pictureBoxMedio_06I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(6, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(6, 15);
            }
        }
        private void pictureBoxMedio_07I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 0);
            }
        }
        private void pictureBoxMedio_07I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 1);
            }
        }
        private void pictureBoxMedio_07I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 2);
            }
        }
        private void pictureBoxMedio_07I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 3);
            }
        }
        private void pictureBoxMedio_07I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 4);
            }
        }
        private void pictureBoxMedio_07I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 5);
            }
        }
        private void pictureBoxMedio_07I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 6);
            }
        }
        private void pictureBoxMedio_07I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 7);
            }
        }
        private void pictureBoxMedio_07I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 8);
            }
        }
        private void pictureBoxMedio_07I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 9);
            }
        }
        private void pictureBoxMedio_07I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 10);
            }
        }
        private void pictureBoxMedio_07I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 11);
            }
        }
        private void pictureBoxMedio_07I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 12);
            }
        }
        private void pictureBoxMedio_07I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 13);
            }
        }
        private void pictureBoxMedio_07I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 14);
            }
        }
        private void pictureBoxMedio_07I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(7, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(7, 15);
            }
        }
        private void pictureBoxMedio_08I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 0);
            }
        }
        private void pictureBoxMedio_08I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 1);
            }
        }
        private void pictureBoxMedio_08I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 2);
            }
        }
        private void pictureBoxMedio_08I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 3);
            }
        }
        private void pictureBoxMedio_08I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 4);
            }
        }
        private void pictureBoxMedio_08I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 5);
            }
        }
        private void pictureBoxMedio_08I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 6);
            }
        }
        private void pictureBoxMedio_08I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 7);
            }
        }
        private void pictureBoxMedio_08I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 8);
            }
        }
        private void pictureBoxMedio_08I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 9);
            }
        }
        private void pictureBoxMedio_08I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 10);
            }
        }
        private void pictureBoxMedio_08I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 11);
            }
        }
        private void pictureBoxMedio_08I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 12);
            }
        }
        private void pictureBoxMedio_08I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 13);
            }
        }
        private void pictureBoxMedio_08I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 14);
            }
        }
        private void pictureBoxMedio_08I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(8, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(8, 15);
            }
        }
        private void pictureBoxMedio_09I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 0);
            }
        }
        private void pictureBoxMedio_09I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 1);
            }
        }
        private void pictureBoxMedio_09I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 2);
            }
        }
        private void pictureBoxMedio_09I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 3);
            }
        }
        private void pictureBoxMedio_09I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 4);
            }
        }
        private void pictureBoxMedio_09I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 5);
            }
        }
        private void pictureBoxMedio_09I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 6);
            }
        }
        private void pictureBoxMedio_09I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 7);
            }
        }
        private void pictureBoxMedio_09I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 8);
            }
        }
        private void pictureBoxMedio_09I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 9);
            }
        }
        private void pictureBoxMedio_09I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 10);
            }
        }
        private void pictureBoxMedio_09I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 11);
            }
        }
        private void pictureBoxMedio_09I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 12);
            }
        }
        private void pictureBoxMedio_09I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 13);
            }
        }
        private void pictureBoxMedio_09I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 14);
            }
        }
        private void pictureBoxMedio_09I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(9, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(9, 15);
            }
        }
        private void pictureBoxMedio_10I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 0);
            }
        }
        private void pictureBoxMedio_10I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 1);
            }
        }
        private void pictureBoxMedio_10I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 2);
            }
        }
        private void pictureBoxMedio_10I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 3);
            }
        }
        private void pictureBoxMedio_10I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 4);
            }
        }
        private void pictureBoxMedio_10I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 5);
            }
        }
        private void pictureBoxMedio_10I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 6);
            }
        }
        private void pictureBoxMedio_10I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 7);
            }
        }
        private void pictureBoxMedio_10I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 8);
            }
        }
        private void pictureBoxMedio_10I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 9);
            }
        }
        private void pictureBoxMedio_10I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 10);
            }
        }
        private void pictureBoxMedio_10I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 11);
            }
        }
        private void pictureBoxMedio_10I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 12);
            }
        }
        private void pictureBoxMedio_10I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 13);
            }
        }
        private void pictureBoxMedio_10I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 14);
            }
        }
        private void pictureBoxMedio_10I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(10, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(10, 15);
            }
        }
        private void pictureBoxMedio_11I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 0);
            }
        }
        private void pictureBoxMedio_11I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 1);
            }
        }
        private void pictureBoxMedio_11I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 2);
            }
        }
        private void pictureBoxMedio_11I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 3);
            }
        }
        private void pictureBoxMedio_11I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 4);
            }
        }
        private void pictureBoxMedio_11I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 5);
            }
        }
        private void pictureBoxMedio_11I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 6);
            }
        }
        private void pictureBoxMedio_11I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 7);
            }
        }
        private void pictureBoxMedio_11I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 8);
            }
        }
        private void pictureBoxMedio_11I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 9);
            }
        }
        private void pictureBoxMedio_11I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 10);
            }
        }
        private void pictureBoxMedio_11I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 11);
            }
        }
        private void pictureBoxMedio_11I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 12);
            }
        }
        private void pictureBoxMedio_11I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 13);
            }
        }
        private void pictureBoxMedio_11I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 14);
            }
        }
        private void pictureBoxMedio_11I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(11, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(11, 15);
            }
        }
        private void pictureBoxMedio_12I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 0);
            }
        }
        private void pictureBoxMedio_12I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 1);
            }
        }
        private void pictureBoxMedio_12I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 2);
            }
        }
        private void pictureBoxMedio_12I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 3);
            }
        }
        private void pictureBoxMedio_12I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 4);
            }
        }
        private void pictureBoxMedio_12I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 5);
            }
        }
        private void pictureBoxMedio_12I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 6);
            }
        }
        private void pictureBoxMedio_12I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 7);
            }
        }
        private void pictureBoxMedio_12I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 8);
            }
        }
        private void pictureBoxMedio_12I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 9);
            }
        }
        private void pictureBoxMedio_12I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 10);
            }
        }
        private void pictureBoxMedio_12I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 11);
            }
        }
        private void pictureBoxMedio_12I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 12);
            }
        }
        private void pictureBoxMedio_12I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 13);
            }
        }
        private void pictureBoxMedio_12I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 14);
            }
        }
        private void pictureBoxMedio_12I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(12, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(12, 15);
            }
        }
        private void pictureBoxMedio_13I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 0);
            }
        }
        private void pictureBoxMedio_13I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 1);
            }
        }
        private void pictureBoxMedio_13I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 2);
            }
        }
        private void pictureBoxMedio_13I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 3);
            }
        }
        private void pictureBoxMedio_13I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 4);
            }
        }
        private void pictureBoxMedio_13I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 5);
            }
        }
        private void pictureBoxMedio_13I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 6);
            }
        }
        private void pictureBoxMedio_13I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 7);
            }
        }
        private void pictureBoxMedio_13I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 8);
            }
        }
        private void pictureBoxMedio_13I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 9);
            }
        }
        private void pictureBoxMedio_13I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 10);
            }
        }
        private void pictureBoxMedio_13I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 11);
            }
        }
        private void pictureBoxMedio_13I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 12);
            }
        }
        private void pictureBoxMedio_13I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 13);
            }
        }
        private void pictureBoxMedio_13I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 14);
            }
        }
        private void pictureBoxMedio_13I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(13, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(13, 15);
            }
        }
        private void pictureBoxMedio_14I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 0);
            }
        }
        private void pictureBoxMedio_14I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 1);
            }
        }
        private void pictureBoxMedio_14I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 2);
            }
        }
        private void pictureBoxMedio_14I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 3);
            }
        }
        private void pictureBoxMedio_14I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 4);
            }
        }
        private void pictureBoxMedio_14I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 5);
            }
        }
        private void pictureBoxMedio_14I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 6);
            }
        }
        private void pictureBoxMedio_14I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 7);
            }
        }
        private void pictureBoxMedio_14I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 8);
            }
        }
        private void pictureBoxMedio_14I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 9);
            }
        }
        private void pictureBoxMedio_14I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 10);
            }
        }
        private void pictureBoxMedio_14I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 11);
            }
        }
        private void pictureBoxMedio_14I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 12);
            }
        }
        private void pictureBoxMedio_14I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 13);
            }
        }
        private void pictureBoxMedio_14I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 14);
            }
        }
        private void pictureBoxMedio_14I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(14, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(14, 15);
            }
        }
        private void pictureBoxMedio_15I00_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 0);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 0);
            }
        }
        private void pictureBoxMedio_15I01_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 1);
            }
        }
        private void pictureBoxMedio_15I02_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 2);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 2);
            }
        }
        private void pictureBoxMedio_15I03_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 3);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 3);
            }
        }
        private void pictureBoxMedio_15I04_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 4);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 4);
            }
        }
        private void pictureBoxMedio_15I05_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 5);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 5);
            }
        }
        private void pictureBoxMedio_15I06_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 6);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 6);
            }
        }
        private void pictureBoxMedio_15I07_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 7);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 7);
            }
        }
        private void pictureBoxMedio_15I08_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 8);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 8);
            }
        }
        private void pictureBoxMedio_15I09_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 9);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 9);
            }
        }
        private void pictureBoxMedio_15I10_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 10);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 10);
            }
        }
        private void pictureBoxMedio_15I11_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 11);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 11);
            }
        }
        private void pictureBoxMedio_15I12_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 12);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 12);
            }
        }
        private void pictureBoxMedio_15I13_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 13);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 13);
            }
        }
        private void pictureBoxMedio_15I14_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 14);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 14);
            }
        }
        private void pictureBoxMedio_15I15_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickLadoEsquerdo(15, 15);
            }
            if (e.Button == MouseButtons.Right)
            {
                ClickLadoDireito(15, 15);
            }
        }


    }       


}
