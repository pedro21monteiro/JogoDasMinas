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
    public partial class ViewPrincipal : Form
    {
        

        //Criar variável global da classe que vai armazenar o objeto da classe FormDificuldadeMedia e FormDificuldadeFacil

        

       
        public ViewPrincipal()
        {
            InitializeComponent();
            
           
            //Inicializar as variáveis e objetos sempre no constructor das classes
        }



        private void buttonSairMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonComecarMenu_Click(object sender, EventArgs e)
        {
            if (comboBoxDificuldade.Text == "")
            {
                MessageBox.Show("ERRO!! Tem de escolher uma dificuldade.");
            }
            if (comboBoxDificuldade.Text == "Fácil")
            {
                FormJogarDificuldadeFacil dlgfacil = new FormJogarDificuldadeFacil(textBox_utilizador.Text);

                if (dlgfacil.ShowDialog() == DialogResult.OK)
                {
                    
                }

            }
            if (comboBoxDificuldade.Text == "Médio")
            {
                FormJogarDificuldadeMedia dlgMedia = new FormJogarDificuldadeMedia();
                if (dlgMedia.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

      


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjuda dlgAjuda = new FormAjuda();
            dlgAjuda.ShowDialog();
        }

        private void rankingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRankings dlgRankings = new FormRankings();
            dlgRankings.ShowDialog();
        }

     

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login dlgLogin = new Login();
            dlgLogin.ShowDialog();
        }

        private void signToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn dlgSignIn = new SignIn();
            dlgSignIn.ShowDialog();
        }

        private void logInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Login dlgLogin = new Login();
            if (dlgLogin.ShowDialog()==DialogResult.OK) {

            }
   
            textBox_utilizador.Text = dlgLogin.Username_player;
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
