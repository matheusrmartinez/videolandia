namespace GUI
{
    partial class frmPrincipal
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
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gêneroFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personagensFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gênerosFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoLocaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoLocaçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.devoluçãoToolStripMenuItem,
            this.artistasToolStripMenuItem,
            this.gêneroFilmeToolStripMenuItem,
            this.personagensFilmeToolStripMenuItem,
            this.gênerosFilmeToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemToolStripMenuItem.Text = "Item";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            this.locaçãoToolStripMenuItem.Click += new System.EventHandler(this.locaçãoToolStripMenuItem_Click);
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devoluçãoToolStripMenuItem.Text = "Devolução";
            this.devoluçãoToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoToolStripMenuItem_Click);
            // 
            // artistasToolStripMenuItem
            // 
            this.artistasToolStripMenuItem.Name = "artistasToolStripMenuItem";
            this.artistasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.artistasToolStripMenuItem.Text = "Artistas";
            this.artistasToolStripMenuItem.Click += new System.EventHandler(this.artistasToolStripMenuItem_Click);
            // 
            // gêneroFilmeToolStripMenuItem
            // 
            this.gêneroFilmeToolStripMenuItem.Name = "gêneroFilmeToolStripMenuItem";
            this.gêneroFilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gêneroFilmeToolStripMenuItem.Text = "Gênero";
            this.gêneroFilmeToolStripMenuItem.Click += new System.EventHandler(this.gêneroFilmeToolStripMenuItem_Click);
            // 
            // personagensFilmeToolStripMenuItem
            // 
            this.personagensFilmeToolStripMenuItem.Name = "personagensFilmeToolStripMenuItem";
            this.personagensFilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personagensFilmeToolStripMenuItem.Text = "Personagens Filme";
            this.personagensFilmeToolStripMenuItem.Click += new System.EventHandler(this.personagensFilmeToolStripMenuItem_Click);
            // 
            // gênerosFilmeToolStripMenuItem
            // 
            this.gênerosFilmeToolStripMenuItem.Name = "gênerosFilmeToolStripMenuItem";
            this.gênerosFilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gênerosFilmeToolStripMenuItem.Text = "Gêneros Filme";
            this.gênerosFilmeToolStripMenuItem.Click += new System.EventHandler(this.gênerosFilmeToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem1,
            this.itemToolStripMenuItem1,
            this.clienteToolStripMenuItem1});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // funcionárioToolStripMenuItem1
            // 
            this.funcionárioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendentesDevoluçãoToolStripMenuItem});
            this.funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            this.funcionárioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.funcionárioToolStripMenuItem1.Text = "Funcionário";
            // 
            // pendentesDevoluçãoToolStripMenuItem
            // 
            this.pendentesDevoluçãoToolStripMenuItem.Name = "pendentesDevoluçãoToolStripMenuItem";
            this.pendentesDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pendentesDevoluçãoToolStripMenuItem.Text = "Pendentes Devolução";
            this.pendentesDevoluçãoToolStripMenuItem.Click += new System.EventHandler(this.pendentesDevoluçãoToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem1
            // 
            this.itemToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoLocaçõesToolStripMenuItem});
            this.itemToolStripMenuItem1.Name = "itemToolStripMenuItem1";
            this.itemToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.itemToolStripMenuItem1.Text = "Item";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoLocaçõesToolStripMenuItem1});
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // históricoLocaçõesToolStripMenuItem
            // 
            this.históricoLocaçõesToolStripMenuItem.Name = "históricoLocaçõesToolStripMenuItem";
            this.históricoLocaçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.históricoLocaçõesToolStripMenuItem.Text = "Histórico Locações";
            this.históricoLocaçõesToolStripMenuItem.Click += new System.EventHandler(this.históricoLocaçõesToolStripMenuItem_Click);
            // 
            // históricoLocaçõesToolStripMenuItem1
            // 
            this.históricoLocaçõesToolStripMenuItem1.Name = "históricoLocaçõesToolStripMenuItem1";
            this.históricoLocaçõesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.históricoLocaçõesToolStripMenuItem1.Text = "Histórico Locações";
            this.históricoLocaçõesToolStripMenuItem1.Click += new System.EventHandler(this.históricoLocaçõesToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 725);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Videolandia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pendentesDevoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gêneroFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personagensFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gênerosFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem históricoLocaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem históricoLocaçõesToolStripMenuItem1;
    }
}

