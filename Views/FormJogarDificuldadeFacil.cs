using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Projeto_de_Lab3
{
    public partial class FormJogarDificuldadeFacil : Form
    {
        Jogo Facil;
        private int Tempo;
        string tempoString;
        string MinasString;
        PictureBox[,] TabuleiroPictureBox = new PictureBox[9, 9];
        Jogador[] CriarJogadores = new Jogador[1000];

        // pasta_aplicacao = "";
        public FormJogarDificuldadeFacil()
        {
            InitializeComponent();
        }

        public FormJogarDificuldadeFacil(string username) 
        {
            InitializeComponent();
            Facil = new Jogo();
            
            Facil.Dificuldade = "Facil";
            //este modo já inicializa o tabuleiro de jogo
            Facil.Modo_de_Jogo();
            Facil._jogador.Username = username;
        }
     

        private void FormJogarDificuldade_Load(object sender, EventArgs e)
        {
            Facil._tabuleiro.Criar_Tabuleiro_Inicial();
            timerDificuldadeFacil.Stop();
            Tempo = 0;
            labelTempo.Text = "000";
            labelMinas.Text = "010";
            Facil._tabuleiro.Numero_de_Minas = 10;

            Atualizar_quadrados();
        }

        //--------------------------------FUNCAO ATUALIZAR QUADRADOS------------------------------------
        private void Atualizar_quadrados()
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    TabuleiroPictureBox[i, j] = new PictureBox();
                }
            }

            //criamos uma matriz de pictureBox para o codigo ser mais pequeno


            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    //---------------------DAS PEÇAS ESCONDIDAS----------------------------
                    if (Facil._tabuleiro.MatrizFacil[i, j] > 10 && Facil._tabuleiro.MatrizFacil[i, j] < 25)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazioButao;
                    }
                    //---------------------DAS PEÇAS Bandeira----------------------------
                    if (Facil._tabuleiro.MatrizFacil[i, j] > 30 && Facil._tabuleiro.MatrizFacil[i, j] < 40)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Bandeira;
                    }
                    //-------------------------PEÇAS A MOSTRA-----------------------------
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 1)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero1;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 2)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero2;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 3)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero3;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 4)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero4;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 5)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazio;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 6 || (Facil._tabuleiro.MatrizFacil[i, j] > 10 && Facil._tabuleiro.MatrizFacil[i, j] < 25))
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazioButao;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 8)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Mina;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 9)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.MinaVermelha;
                    }
                    //-------------------------PEÇAS Do Freeze-----------------------------
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 41)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero1;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 42)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero2;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 43)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero3;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 44)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Numero4;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 45)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazio;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 46 )
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.QuadradoVazioButao;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 47)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Bandeira;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 48)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.Mina;
                    }
                    if (Facil._tabuleiro.MatrizFacil[i, j] == 49)
                    {
                        TabuleiroPictureBox[i, j].Image = global::Projeto_de_Lab3.Imagens.MinaVermelha;
                    }
                }
            }

            // Agora a cada picturebux do nosso windForm Vamos por a imagem correspondente á matriz de picturebx
            pictureBoxFacil_00I00.Image = TabuleiroPictureBox[0, 0].Image;
            pictureBoxFacil_00I01.Image = TabuleiroPictureBox[0, 1].Image;
            pictureBoxFacil_00I02.Image = TabuleiroPictureBox[0, 2].Image;
            pictureBoxFacil_00I03.Image = TabuleiroPictureBox[0, 3].Image;
            pictureBoxFacil_00I04.Image = TabuleiroPictureBox[0, 4].Image;
            pictureBoxFacil_00I05.Image = TabuleiroPictureBox[0, 5].Image;
            pictureBoxFacil_00I06.Image = TabuleiroPictureBox[0, 6].Image;
            pictureBoxFacil_00I07.Image = TabuleiroPictureBox[0, 7].Image;
            pictureBoxFacil_00I08.Image = TabuleiroPictureBox[0, 8].Image;

            pictureBoxFacil_01I00.Image = TabuleiroPictureBox[1, 0].Image;
            pictureBoxFacil_01I01.Image = TabuleiroPictureBox[1, 1].Image;
            pictureBoxFacil_01I02.Image = TabuleiroPictureBox[1, 2].Image;
            pictureBoxFacil_01I03.Image = TabuleiroPictureBox[1, 3].Image;
            pictureBoxFacil_01I04.Image = TabuleiroPictureBox[1, 4].Image;
            pictureBoxFacil_01I05.Image = TabuleiroPictureBox[1, 5].Image;
            pictureBoxFacil_01I06.Image = TabuleiroPictureBox[1, 6].Image;
            pictureBoxFacil_01I07.Image = TabuleiroPictureBox[1, 7].Image;
            pictureBoxFacil_01I08.Image = TabuleiroPictureBox[1, 8].Image;

            pictureBoxFacil_02I00.Image = TabuleiroPictureBox[2, 0].Image;
            pictureBoxFacil_02I01.Image = TabuleiroPictureBox[2, 1].Image;
            pictureBoxFacil_02I02.Image = TabuleiroPictureBox[2, 2].Image;
            pictureBoxFacil_02I03.Image = TabuleiroPictureBox[2, 3].Image;
            pictureBoxFacil_02I04.Image = TabuleiroPictureBox[2, 4].Image;
            pictureBoxFacil_02I05.Image = TabuleiroPictureBox[2, 5].Image;
            pictureBoxFacil_02I06.Image = TabuleiroPictureBox[2, 6].Image;
            pictureBoxFacil_02I07.Image = TabuleiroPictureBox[2, 7].Image;
            pictureBoxFacil_02I08.Image = TabuleiroPictureBox[2, 8].Image;

            pictureBoxFacil_03I00.Image = TabuleiroPictureBox[3, 0].Image;
            pictureBoxFacil_03I01.Image = TabuleiroPictureBox[3, 1].Image;
            pictureBoxFacil_03I02.Image = TabuleiroPictureBox[3, 2].Image;
            pictureBoxFacil_03I03.Image = TabuleiroPictureBox[3, 3].Image;
            pictureBoxFacil_03I04.Image = TabuleiroPictureBox[3, 4].Image;
            pictureBoxFacil_03I05.Image = TabuleiroPictureBox[3, 5].Image;
            pictureBoxFacil_03I06.Image = TabuleiroPictureBox[3, 6].Image;
            pictureBoxFacil_03I07.Image = TabuleiroPictureBox[3, 7].Image;
            pictureBoxFacil_03I08.Image = TabuleiroPictureBox[3, 8].Image;

            pictureBoxFacil_04I00.Image = TabuleiroPictureBox[4, 0].Image;
            pictureBoxFacil_04I01.Image = TabuleiroPictureBox[4, 1].Image;
            pictureBoxFacil_04I02.Image = TabuleiroPictureBox[4, 2].Image;
            pictureBoxFacil_04I03.Image = TabuleiroPictureBox[4, 3].Image;
            pictureBoxFacil_04I04.Image = TabuleiroPictureBox[4, 4].Image;
            pictureBoxFacil_04I05.Image = TabuleiroPictureBox[4, 5].Image;
            pictureBoxFacil_04I06.Image = TabuleiroPictureBox[4, 6].Image;
            pictureBoxFacil_04I07.Image = TabuleiroPictureBox[4, 7].Image;
            pictureBoxFacil_04I08.Image = TabuleiroPictureBox[4, 8].Image;

            pictureBoxFacil_05I00.Image = TabuleiroPictureBox[5, 0].Image;
            pictureBoxFacil_05I01.Image = TabuleiroPictureBox[5, 1].Image;
            pictureBoxFacil_05I02.Image = TabuleiroPictureBox[5, 2].Image;
            pictureBoxFacil_05I03.Image = TabuleiroPictureBox[5, 3].Image;
            pictureBoxFacil_05I04.Image = TabuleiroPictureBox[5, 4].Image;
            pictureBoxFacil_05I05.Image = TabuleiroPictureBox[5, 5].Image;
            pictureBoxFacil_05I06.Image = TabuleiroPictureBox[5, 6].Image;
            pictureBoxFacil_05I07.Image = TabuleiroPictureBox[5, 7].Image;
            pictureBoxFacil_05I08.Image = TabuleiroPictureBox[5, 8].Image;

            pictureBoxFacil_06I00.Image = TabuleiroPictureBox[6, 0].Image;
            pictureBoxFacil_06I01.Image = TabuleiroPictureBox[6, 1].Image;
            pictureBoxFacil_06I02.Image = TabuleiroPictureBox[6, 2].Image;
            pictureBoxFacil_06I03.Image = TabuleiroPictureBox[6, 3].Image;
            pictureBoxFacil_06I04.Image = TabuleiroPictureBox[6, 4].Image;
            pictureBoxFacil_06I05.Image = TabuleiroPictureBox[6, 5].Image;
            pictureBoxFacil_06I06.Image = TabuleiroPictureBox[6, 6].Image;
            pictureBoxFacil_06I07.Image = TabuleiroPictureBox[6, 7].Image;
            pictureBoxFacil_06I08.Image = TabuleiroPictureBox[6, 8].Image;

            pictureBoxFacil_07I00.Image = TabuleiroPictureBox[7, 0].Image;
            pictureBoxFacil_07I01.Image = TabuleiroPictureBox[7, 1].Image;
            pictureBoxFacil_07I02.Image = TabuleiroPictureBox[7, 2].Image;
            pictureBoxFacil_07I03.Image = TabuleiroPictureBox[7, 3].Image;
            pictureBoxFacil_07I04.Image = TabuleiroPictureBox[7, 4].Image;
            pictureBoxFacil_07I05.Image = TabuleiroPictureBox[7, 5].Image;
            pictureBoxFacil_07I06.Image = TabuleiroPictureBox[7, 6].Image;
            pictureBoxFacil_07I07.Image = TabuleiroPictureBox[7, 7].Image;
            pictureBoxFacil_07I08.Image = TabuleiroPictureBox[7, 8].Image;

            pictureBoxFacil_08I00.Image = TabuleiroPictureBox[8, 0].Image;
            pictureBoxFacil_08I01.Image = TabuleiroPictureBox[8, 1].Image;
            pictureBoxFacil_08I02.Image = TabuleiroPictureBox[8, 2].Image;
            pictureBoxFacil_08I03.Image = TabuleiroPictureBox[8, 3].Image;
            pictureBoxFacil_08I04.Image = TabuleiroPictureBox[8, 4].Image;
            pictureBoxFacil_08I05.Image = TabuleiroPictureBox[8, 5].Image;
            pictureBoxFacil_08I06.Image = TabuleiroPictureBox[8, 6].Image;
            pictureBoxFacil_08I07.Image = TabuleiroPictureBox[8, 7].Image;
            pictureBoxFacil_08I08.Image = TabuleiroPictureBox[8, 8].Image;

        }


        private void timer1_Tick(object sender, EventArgs e)
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
            labelTempo.Text = tempoString;

            //------------------------CONTADOR DE MINAS------------------------------

            if (Facil._tabuleiro.Numero_de_Minas <= 9)
            {
                MinasString = "00" + Facil._tabuleiro.Numero_de_Minas.ToString();
            }
            if (Facil._tabuleiro.Numero_de_Minas <= 99 && Facil._tabuleiro.Numero_de_Minas > 9)
            {
                MinasString = "0" + Facil._tabuleiro.Numero_de_Minas.ToString();
            }
            if (Facil._tabuleiro.Numero_de_Minas > 99)
            {
                MinasString = "" + Facil._tabuleiro.Numero_de_Minas.ToString();
            }

            labelMinas.Text = MinasString;
            if (Tempo >= 999)//fim do tempo
            {
                timerDificuldadeFacil.Stop();
                MensagemPerdeu();
                Facil._tabuleiro.FreezeTabuleiro();
            }
        }

        private void picturebox_recomecar_facil_Click(object sender, EventArgs e)
        {
            Facil._tabuleiro.Criar_Tabuleiro_Inicial();
            timerDificuldadeFacil.Stop();
            Tempo = 0;
            labelTempo.Text = "000";
            labelMinas.Text = "010";
            Facil._tabuleiro.Numero_de_Minas = 10;

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
            if (Facil._tabuleiro.Verificar_se_e_1_click() == true)
            {
                Facil._tabuleiro.Criar_Tabuleiro_Primeiro_Click(_x,_y);
                timerDificuldadeFacil.Start();
                Atualizar_quadrados();
            }
            else
            {
                Facil._tabuleiro.Click_Normal(_x, _y);
                Atualizar_quadrados();

                if (Facil._tabuleiro.Terminou_jogo() == 1)//terminou o jogo e ganhou
                {
                    timerDificuldadeFacil.Stop();
                    MensagemGanhou();
                    Facil._tabuleiro.FreezeTabuleiro();
                    //-------------------------
                   

                }
             
                if (Facil._tabuleiro.Terminou_jogo() == 2)//terminou o jogo e perdeu
                {
                    timerDificuldadeFacil.Stop();
                    MensagemPerdeu();
                    Facil._tabuleiro.FreezeTabuleiro();

                    //----------------------------
                    
                    Facil._jogador.Numero_Jogos_Perdidos++;
                    AtualizarDadosDaconta();


                }
            }

        
        }
    
        private void ClickLadoDireito(int _x, int _y)
        {
            Facil._tabuleiro.Click_Lado_Direito(_x, _y);
            Atualizar_quadrados();
        }

        //-----------------------------Ficheiros--------------------------
        public int LerDoFicheiro()
        {
            using (StreamReader leitor = new StreamReader("ContasJogoMinas.txt"))
            {
                //  File.ReadAllLines("ContasJogoMinas.txt");
                int i = 0;
                while (!leitor.EndOfStream)
                {
                    CriarJogadores[i] = new Jogador();
                    string linha = leitor.ReadLine();

                    string[] valores = linha.Split(';');

                    CriarJogadores[i].Username = valores[0];
                    CriarJogadores[i].Password = valores[1];
                    CriarJogadores[i].Nome = valores[2];
                    CriarJogadores[i].Apelido = valores[3];
                    CriarJogadores[i].Pais = valores[4];
                    CriarJogadores[i].Numero_Jogos_Ganhos = int.Parse(valores[5]);
                    CriarJogadores[i].Numero_Jogos_Perdidos = int.Parse(valores[6]);
                    CriarJogadores[i].Tempo_Facil = int.Parse(valores[7]);
                    CriarJogadores[i].Tempo_Medio = int.Parse(valores[8]);

                    i++;
                }
                leitor.Close();
                i--;
                return i;//numero do ultimo jogador existente no vetor

            }

        }
        public void AtualizarDadosDaconta()
        {
            int i= LerDoFicheiro();
            int a = 0; // possiçao do bloco de notas onde se encontra a conta
            int j;
            for (j = 0 ; j <= i; j++)
            {
                if (CriarJogadores[j].Username == Facil._jogador.Username){
                    a = j;
                }

            }
            //atualizar os valores

            CriarJogadores[a].Username = Facil._jogador.Username;
            CriarJogadores[a].Password = Facil._jogador.Password;
            CriarJogadores[a].Nome = Facil._jogador.Nome;
            CriarJogadores[a].Apelido = Facil._jogador.Apelido;
            CriarJogadores[a].Pais = Facil._jogador.Pais;
            CriarJogadores[a].Numero_Jogos_Ganhos = Facil._jogador.Numero_Jogos_Ganhos;
            CriarJogadores[a].Numero_Jogos_Perdidos = Facil._jogador.Numero_Jogos_Perdidos;
            CriarJogadores[a].Tempo_Facil = Facil._jogador.Tempo_Facil;
            CriarJogadores[a].Tempo_Medio = Facil._jogador.Tempo_Medio;
            //agora vai escrever os nomes todos de novo no ficheiro
            int b;
            StreamWriter escritor = new StreamWriter("ContasJogoMinas.txt");
            for (b = 0; b <= i; b++)
            {
                escritor.WriteLine(CriarJogadores[b].Username + ";" + CriarJogadores[b].Password + ";" +
                CriarJogadores[b].Nome + ";" + CriarJogadores[b].Apelido + ";" + CriarJogadores[b].Pais + ";" +
                CriarJogadores[b].Numero_Jogos_Ganhos + ";" + CriarJogadores[b].Numero_Jogos_Perdidos + ";" + CriarJogadores[b].Tempo_Facil + ";" +
                CriarJogadores[b].Tempo_Medio + ";");
            }
            escritor.Close();
        }

        //----------------------------------PICTURE BOX TODAS-------------------------------------------------
        private void pictureBoxFacil_00I00_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_00I01_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_00I02_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_00I03_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_00I04_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_00I05_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_00I06_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_00I07_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_00I08_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_01I00_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_01I01_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_01I02_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_01I03_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_01I04_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_01I05_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_01I06_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_01I07_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_01I08_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_02I00_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_02I01_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_02I02_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_02I03_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_02I04_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_02I05_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_02I06_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_02I07_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_02I08_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_03I00_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_03I01_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_03I02_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_03I03_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_03I04_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_03I05_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_03I06_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_03I07_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_03I08_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_04I00_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_04I01_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_04I02_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_04I03_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_04I04_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_04I05_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_04I06_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_04I07_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_04I08_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_05I00_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_05I01_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_05I02_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_05I03_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_05I04_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_05I05_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_05I06_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_05I07_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_05I08_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_06I00_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_06I01_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_06I02_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_06I03_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_06I04_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_06I05_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_06I06_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_06I07_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_06I08_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_07I00_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_07I01_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_07I02_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_07I03_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_07I04_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_07I05_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_07I06_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_07I07_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_07I08_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_08I00_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_08I01_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_08I02_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_08I03_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_08I04_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_08I05_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_08I06_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_08I07_Click(object sender, MouseEventArgs e)
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

        private void pictureBoxFacil_08I08_Click(object sender, MouseEventArgs e)
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
    }
}
