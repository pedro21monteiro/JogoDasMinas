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
 public partial class SignIn : Form
    {
        public SignIn()
        {

            InitializeComponent();

        }
        // Jogador[] RegistarJogadores = new Jogador[5];

        Jogador[] CriarJogadores = new Jogador[1000];

    private void label4_Click(object sender, EventArgs e)
        {

        }



        public void CriarAContaEmFicheiro()
        {
           
            int i = LerDoFicheiro();// o i vai ser o numero do ultimo jogador existente no vetor

            //meter dados no novo jogador
            i++;//i++ pois é mais uma posição para um novo jogador
       
            CriarJogadores[i] = new Jogador();
            CriarJogadores[i].Username = textBoxUserNameSignIn.Text;
            CriarJogadores[i].Password = textBoxPasswordSignIn.Text;
            CriarJogadores[i].Nome = textBoxNomeSignIn.Text;
            CriarJogadores[i].Apelido = textBoxApelidoSignIn.Text;
            CriarJogadores[i].Pais = textBoxPaisSignIn.Text;
            CriarJogadores[i].Numero_Jogos_Ganhos = 0;
            CriarJogadores[i].Numero_Jogos_Perdidos = 0;
            CriarJogadores[i].Tempo_Facil = 999;
            CriarJogadores[i].Tempo_Medio = 999;

           //escrever os jogadores que já existem e o novo jogador
            int a;
            StreamWriter escritor = new StreamWriter("ContasJogoMinas.txt");
            for (a = 0; a <= i; a++)
            {
                    escritor.WriteLine(CriarJogadores[a].Username + ";" + CriarJogadores[a].Password + ";" +
                    CriarJogadores[a].Nome + ";" + CriarJogadores[a].Apelido + ";" + CriarJogadores[a].Pais + ";" +
                    CriarJogadores[a].Numero_Jogos_Ganhos + ";" + CriarJogadores[a].Numero_Jogos_Perdidos + ";" + CriarJogadores[a].Tempo_Facil + ";" +
                    CriarJogadores[a].Tempo_Medio + ";");
            }
            escritor.Close();           
        }
        //AAAAA;AAAAA;AAAAA;AAAAA;AAAAA;9999;9999;9999;9999;

        //vai buscar os jogadors ao ficheiro e retorn o numero de jogadores
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
        private bool UserNameExiste(string _UserName)
        {
            bool valor = false;
            int i = LerDoFicheiro();
            int a;
            for (a = 0; a < i; a++)
            {
                if(CriarJogadores[a].Username == _UserName || valor)
                {
                    valor = true;
                }
            }
            return valor;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonCriarConta_Click_1(object sender, EventArgs e)
        {
            
            if(textBoxNomeSignIn.Text.Length >= 3)
            {
                if (textBoxApelidoSignIn.Text.Length >= 3)
                {
                    if (textBoxPaisSignIn.Text.Length >= 3)
                    {
                        if (textBoxUserNameSignIn.Text.Length >= 3)
                        {
                            if (UserNameExiste(textBoxUserNameSignIn.Text) == false)
                            {
                                if (textBoxPasswordSignIn.Text.Length >= 5)
                                {
                                    if (textBoxRepetirPasswordSignIn.Text == textBoxPasswordSignIn.Text)
                                    {
                                        //Aqui vai ser a criação da conta 
                                        CriarAContaEmFicheiro();
                                        MessageBox.Show("Conta criada com sucesso !!!");
                                        this.Close();
                                    }
                                    else MessageBox.Show("PassWord tem de ser igual ao Repetir Password");
                                }
                                else MessageBox.Show("Password tem de ter no minimo 5 caracteres");
                            }
                            else MessageBox.Show("O UserName já existe");
                        }
                        else MessageBox.Show("UserName tem de ter no minimo 3 caracteres");
                    }
                    else MessageBox.Show("Pais tem de ter no minimo 5 caracteres");
                }
                else MessageBox.Show("Apelido tem de ter no minimo 3 caracteres");
            }
            else MessageBox.Show("Nome tem de ter no minimo 3 caracteres");
    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    
}
