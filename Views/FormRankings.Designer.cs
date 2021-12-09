namespace Projeto_de_Lab3
{
    partial class FormRankings
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.standaloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fácilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fácilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.médioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standaloneToolStripMenuItem,
            this.onlineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // standaloneToolStripMenuItem
            // 
            this.standaloneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fácilToolStripMenuItem,
            this.médioToolStripMenuItem});
            this.standaloneToolStripMenuItem.Name = "standaloneToolStripMenuItem";
            this.standaloneToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.standaloneToolStripMenuItem.Text = "Standalone";
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fácilToolStripMenuItem1,
            this.médioToolStripMenuItem1});
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.onlineToolStripMenuItem.Text = "Online";
            // 
            // fácilToolStripMenuItem
            // 
            this.fácilToolStripMenuItem.Name = "fácilToolStripMenuItem";
            this.fácilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fácilToolStripMenuItem.Text = "Fácil";
            // 
            // médioToolStripMenuItem
            // 
            this.médioToolStripMenuItem.Name = "médioToolStripMenuItem";
            this.médioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.médioToolStripMenuItem.Text = "Médio";
            // 
            // fácilToolStripMenuItem1
            // 
            this.fácilToolStripMenuItem1.Name = "fácilToolStripMenuItem1";
            this.fácilToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fácilToolStripMenuItem1.Text = "Fácil";
            // 
            // médioToolStripMenuItem1
            // 
            this.médioToolStripMenuItem1.Name = "médioToolStripMenuItem1";
            this.médioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.médioToolStripMenuItem1.Text = "Médio";
            // 
            // FormRankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 315);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRankings";
            this.Text = "FormRankings";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem standaloneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fácilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fácilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem médioToolStripMenuItem1;
    }
}