namespace Projeto_de_Lab3
{
    partial class SignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNomeSignIn = new System.Windows.Forms.TextBox();
            this.textBoxPasswordSignIn = new System.Windows.Forms.TextBox();
            this.textBoxRepetirPasswordSignIn = new System.Windows.Forms.TextBox();
            this.textBoxUserNameSignIn = new System.Windows.Forms.TextBox();
            this.textBoxApelidoSignIn = new System.Windows.Forms.TextBox();
            this.buttonCriarConta = new System.Windows.Forms.Button();
            this.textBoxPaisSignIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apelido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserName:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Repetir Password:";
            // 
            // textBoxNomeSignIn
            // 
            this.textBoxNomeSignIn.Location = new System.Drawing.Point(183, 29);
            this.textBoxNomeSignIn.Name = "textBoxNomeSignIn";
            this.textBoxNomeSignIn.Size = new System.Drawing.Size(200, 20);
            this.textBoxNomeSignIn.TabIndex = 6;
            // 
            // textBoxPasswordSignIn
            // 
            this.textBoxPasswordSignIn.Location = new System.Drawing.Point(181, 175);
            this.textBoxPasswordSignIn.Name = "textBoxPasswordSignIn";
            this.textBoxPasswordSignIn.Size = new System.Drawing.Size(200, 20);
            this.textBoxPasswordSignIn.TabIndex = 7;
            // 
            // textBoxRepetirPasswordSignIn
            // 
            this.textBoxRepetirPasswordSignIn.Location = new System.Drawing.Point(181, 214);
            this.textBoxRepetirPasswordSignIn.Name = "textBoxRepetirPasswordSignIn";
            this.textBoxRepetirPasswordSignIn.Size = new System.Drawing.Size(200, 20);
            this.textBoxRepetirPasswordSignIn.TabIndex = 8;
            // 
            // textBoxUserNameSignIn
            // 
            this.textBoxUserNameSignIn.Location = new System.Drawing.Point(181, 136);
            this.textBoxUserNameSignIn.Name = "textBoxUserNameSignIn";
            this.textBoxUserNameSignIn.Size = new System.Drawing.Size(200, 20);
            this.textBoxUserNameSignIn.TabIndex = 9;
            // 
            // textBoxApelidoSignIn
            // 
            this.textBoxApelidoSignIn.Location = new System.Drawing.Point(183, 69);
            this.textBoxApelidoSignIn.Name = "textBoxApelidoSignIn";
            this.textBoxApelidoSignIn.Size = new System.Drawing.Size(200, 20);
            this.textBoxApelidoSignIn.TabIndex = 10;
            // 
            // buttonCriarConta
            // 
            this.buttonCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarConta.Location = new System.Drawing.Point(140, 265);
            this.buttonCriarConta.Name = "buttonCriarConta";
            this.buttonCriarConta.Size = new System.Drawing.Size(134, 23);
            this.buttonCriarConta.TabIndex = 11;
            this.buttonCriarConta.Text = "Criar Conta";
            this.buttonCriarConta.UseVisualStyleBackColor = true;
            this.buttonCriarConta.Click += new System.EventHandler(this.buttonCriarConta_Click_1);
            // 
            // textBoxPaisSignIn
            // 
            this.textBoxPaisSignIn.Location = new System.Drawing.Point(183, 103);
            this.textBoxPaisSignIn.Name = "textBoxPaisSignIn";
            this.textBoxPaisSignIn.Size = new System.Drawing.Size(200, 20);
            this.textBoxPaisSignIn.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "País:";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 321);
            this.Controls.Add(this.textBoxPaisSignIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCriarConta);
            this.Controls.Add(this.textBoxApelidoSignIn);
            this.Controls.Add(this.textBoxUserNameSignIn);
            this.Controls.Add(this.textBoxRepetirPasswordSignIn);
            this.Controls.Add(this.textBoxPasswordSignIn);
            this.Controls.Add(this.textBoxNomeSignIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNomeSignIn;
        private System.Windows.Forms.TextBox textBoxPasswordSignIn;
        private System.Windows.Forms.TextBox textBoxRepetirPasswordSignIn;
        private System.Windows.Forms.TextBox textBoxUserNameSignIn;
        private System.Windows.Forms.TextBox textBoxApelidoSignIn;
        private System.Windows.Forms.Button buttonCriarConta;
        private System.Windows.Forms.TextBox textBoxPaisSignIn;
        private System.Windows.Forms.Label label6;
    }
}