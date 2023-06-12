namespace SistemanalizFinal
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyunaGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oynaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncuSkorlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunKurallarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurallarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunaGirişToolStripMenuItem,
            this.skorlarToolStripMenuItem,
            this.oyunKurallarıToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oyunaGirişToolStripMenuItem
            // 
            this.oyunaGirişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oynaToolStripMenuItem});
            this.oyunaGirişToolStripMenuItem.Name = "oyunaGirişToolStripMenuItem";
            this.oyunaGirişToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.oyunaGirişToolStripMenuItem.Text = "Oyuna Giriş ";
            // 
            // oynaToolStripMenuItem
            // 
            this.oynaToolStripMenuItem.Name = "oynaToolStripMenuItem";
            this.oynaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oynaToolStripMenuItem.Text = "Oyna";
            this.oynaToolStripMenuItem.Click += new System.EventHandler(this.oynaToolStripMenuItem_Click);
            // 
            // skorlarToolStripMenuItem
            // 
            this.skorlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyuncuSkorlarıToolStripMenuItem});
            this.skorlarToolStripMenuItem.Name = "skorlarToolStripMenuItem";
            this.skorlarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.skorlarToolStripMenuItem.Text = "Skorlar";
            // 
            // oyuncuSkorlarıToolStripMenuItem
            // 
            this.oyuncuSkorlarıToolStripMenuItem.Name = "oyuncuSkorlarıToolStripMenuItem";
            this.oyuncuSkorlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oyuncuSkorlarıToolStripMenuItem.Text = "Oyuncu skorları";
            this.oyuncuSkorlarıToolStripMenuItem.Click += new System.EventHandler(this.oyuncuSkorlarıToolStripMenuItem_Click);
            // 
            // oyunKurallarıToolStripMenuItem
            // 
            this.oyunKurallarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurallarToolStripMenuItem});
            this.oyunKurallarıToolStripMenuItem.Name = "oyunKurallarıToolStripMenuItem";
            this.oyunKurallarıToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.oyunKurallarıToolStripMenuItem.Text = "Oyun kuralları";
            // 
            // kurallarToolStripMenuItem
            // 
            this.kurallarToolStripMenuItem.Name = "kurallarToolStripMenuItem";
            this.kurallarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kurallarToolStripMenuItem.Text = "Kurallar";
            this.kurallarToolStripMenuItem.Click += new System.EventHandler(this.kurallarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passaparola Oyununa Hoşgeldiniz : )";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaSayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunaGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oynaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyuncuSkorlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyunKurallarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurallarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}