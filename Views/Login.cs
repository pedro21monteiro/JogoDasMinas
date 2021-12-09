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
using System.Threading;

namespace Projeto_de_Lab3
{
    public partial class Login : Form
    {

        // ViewPrincipal InstanciaDoViewPrincipal;

        private string username_player;

        public string Username_player
        {
            get { return username_player; }
            set{ username_player = value; }
        }

        public Login()//ViewPrincipal dlgViewPrincipal
        {
            InitializeComponent();
            //   InstanciaDoViewPrincipal = dlgViewPrincipal;
           
        }

        Jogador[] LogarJogadores = new Jogador[100];
        

        

        private bool UserNameExiste(string _UserName)
        {
            bool valor = false;
            int i = LerDoFicheiro();
            int a;
            for (a = 0; a < i; a++)
            {
                if (LogarJogadores[a].Username == _UserName || valor)
                {
                    valor = true;
                }
            }
            return valor;
        }

        private Jogador JogadorDoLogin(string _UserName)
        {
            
            int i = LerDoFicheiro();
            int a;
            int b = -1;
            for (a = 0; a < i; a++)
            {
                if (LogarJogadores[a].Username == _UserName)
                {
                    b = a;
                }
               
            }
            if (b != -1)
            {
                return LogarJogadores[b];
            }
            else return null;
        }

        public int LerDoFicheiro()
        {
            using (StreamReader leitor = new StreamReader("ContasJogoMinas.txt"))
            {
                //  File.ReadAllLines("ContasJogoMinas.txt");
                int i = 0;
                while (!leitor.EndOfStream)
                {
                    LogarJogadores[i] = new Jogador();
                    string linha = leitor.ReadLine();

                    string[] valores = linha.Split(';');

                    LogarJogadores[i].Username = valores[0];
                    LogarJogadores[i].Password = valores[1];
                    LogarJogadores[i].Nome = valores[2];
                    LogarJogadores[i].Apelido = valores[3];
                    LogarJogadores[i].Pais = valores[4];
                    LogarJogadores[i].Numero_Jogos_Ganhos = int.Parse(valores[5]);
                    LogarJogadores[i].Numero_Jogos_Perdidos = int.Parse(valores[6]);
                    LogarJogadores[i].Tempo_Facil = int.Parse(valores[7]);
                    LogarJogadores[i].Tempo_Medio = int.Parse(valores[8]);

                    i++;
                }
                leitor.Close();
                i--;
                return i;//numero do ultimo jogador existente no vetor

            }

        }

    
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (UserNameExiste(textBoxUserNameLogin.Text) == true)
            {
                if(JogadorDoLogin(textBoxUserNameLogin.Text).Password == textBoxPasswordLogin.Text)
                {
                   
                    username_player = textBoxUserNameLogin.Text;


                    MessageBox.Show("Login Efetuado com sucesso");


                    this.Close();

                }

                else MessageBox.Show("PassWord está incorreta");

            }
            else MessageBox.Show("UserName não existe");


        }

       
    }
}
