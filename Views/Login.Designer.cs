namespace Projeto_de_Lab3
{
    partial class Login
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
            this.labelNomeUtilizador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserNameLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeUtilizador
            // 
            this.labelNomeUtilizador.AutoSize = true;
            this.labelNomeUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUtilizador.Location = new System.Drawing.Point(80, 34);
            this.labelNomeUtilizador.Name = "labelNomeUtilizador";
            this.labelNomeUtilizador.Size = new System.Drawing.Size(98, 20);
            this.labelNomeUtilizador.TabIndex = 0;
            this.labelNomeUtilizador.Text = "UserName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // textBoxUserNameLogin
            // 
            this.textBoxUserNameLogin.Location = new System.Drawing.Point(184, 34);
            this.textBoxUserNameLogin.Name = "textBoxUserNameLogin";
            this.textBoxUserNameLogin.Size = new System.Drawing.Size(142, 20);
            this.textBoxUserNameLogin.TabIndex = 2;
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(184, 73);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(142, 20);
            this.textBoxPasswordLogin.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(138, 114);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(92, 32);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 158);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.textBoxUserNameLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNomeUtilizador);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeUtilizador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserNameLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.Button buttonLogin;
    }
}