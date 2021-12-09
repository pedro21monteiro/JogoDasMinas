namespace Projeto_de_Lab3
{
    partial class ViewPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonComecarMenu = new System.Windows.Forms.Button();
            this.comboBoxDificuldade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rankingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUtilizador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxModoDeJogo = new System.Windows.Forms.ComboBox();
            this.textBox_utilizador = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(93, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo Das Minas";
            // 
            // buttonComecarMenu
            // 
            this.buttonComecarMenu.Location = new System.Drawing.Point(192, 290);
            this.buttonComecarMenu.Name = "buttonComecarMenu";
            this.buttonComecarMenu.Size = new System.Drawing.Size(121, 23);
            this.buttonComecarMenu.TabIndex = 1;
            this.buttonComecarMenu.Text = "Começar";
            this.buttonComecarMenu.UseVisualStyleBackColor = true;
            this.buttonComecarMenu.Click += new System.EventHandler(this.buttonComecarMenu_Click);
            // 
            // comboBoxDificuldade
            // 
            this.comboBoxDificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDificuldade.FormattingEnabled = true;
            this.comboBoxDificuldade.Items.AddRange(new object[] {
            "Fácil",
            "Médio"});
            this.comboBoxDificuldade.Location = new System.Drawing.Point(192, 263);
            this.comboBoxDificuldade.Name = "comboBoxDificuldade";
            this.comboBoxDificuldade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDificuldade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dificuldade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "© Pedro Monteiro, Sergio Oliveira, Daniel Monteiro, 2020";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankingsToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.signToolStripMenuItem,
            this.logInToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rankingsToolStripMenuItem
            // 
            this.rankingsToolStripMenuItem.Name = "rankingsToolStripMenuItem";
            this.rankingsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.rankingsToolStripMenuItem.Text = "Rankings";
            this.rankingsToolStripMenuItem.Click += new System.EventHandler(this.rankingsToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // signToolStripMenuItem
            // 
            this.signToolStripMenuItem.Name = "signToolStripMenuItem";
            this.signToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.signToolStripMenuItem.Text = "Sign In";
            this.signToolStripMenuItem.Click += new System.EventHandler(this.signToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.logInToolStripMenuItem.Text = "Login";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click_1);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelUtilizador
            // 
            this.labelUtilizador.AutoSize = true;
            this.labelUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilizador.Location = new System.Drawing.Point(96, 195);
            this.labelUtilizador.Name = "labelUtilizador";
            this.labelUtilizador.Size = new System.Drawing.Size(90, 20);
            this.labelUtilizador.TabIndex = 10;
            this.labelUtilizador.Text = "Utilizador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modo:";
            // 
            // comboBoxModoDeJogo
            // 
            this.comboBoxModoDeJogo.AutoCompleteCustomSource.AddRange(new string[] {
            "Standalone",
            "Online"});
            this.comboBoxModoDeJogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModoDeJogo.FormattingEnabled = true;
            this.comboBoxModoDeJogo.Items.AddRange(new object[] {
            "Standalone",
            "Online"});
            this.comboBoxModoDeJogo.Location = new System.Drawing.Point(192, 229);
            this.comboBoxModoDeJogo.Name = "comboBoxModoDeJogo";
            this.comboBoxModoDeJogo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModoDeJogo.TabIndex = 12;
            // 
            // textBox_utilizador
            // 
            this.textBox_utilizador.Location = new System.Drawing.Point(193, 194);
            this.textBox_utilizador.Name = "textBox_utilizador";
            this.textBox_utilizador.ReadOnly = true;
            this.textBox_utilizador.Size = new System.Drawing.Size(120, 20);
            this.textBox_utilizador.TabIndex = 13;
            // 
            // ViewPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 350);
            this.Controls.Add(this.textBox_utilizador);
            this.Controls.Add(this.comboBoxModoDeJogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUtilizador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDificuldade);
            this.Controls.Add(this.buttonComecarMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewPrincipal";
            this.Text = "Jogo Das Minas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComecarMenu;
        private System.Windows.Forms.ComboBox comboBoxDificuldade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rankingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem signToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxModoDeJogo;
        public System.Windows.Forms.Label labelUtilizador;
        private System.Windows.Forms.TextBox textBox_utilizador;
    }
}

