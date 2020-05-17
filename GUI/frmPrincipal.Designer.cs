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
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dezÚltimasLocaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.artistasToolStripMenuItem});
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
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devoluçãoToolStripMenuItem.Text = "Devolução";
            // 
            // artistasToolStripMenuItem
            // 
            this.artistasToolStripMenuItem.Name = "artistasToolStripMenuItem";
            this.artistasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.artistasToolStripMenuItem.Text = "Artistas";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem1,
            this.locaçãoToolStripMenuItem1});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // funcionárioToolStripMenuItem1
            // 
            this.funcionárioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendentesDevoluçãoToolStripMenuItem});
            this.funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            this.funcionárioToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.funcionárioToolStripMenuItem1.Text = "Funcionário";
            // 
            // pendentesDevoluçãoToolStripMenuItem
            // 
            this.pendentesDevoluçãoToolStripMenuItem.Name = "pendentesDevoluçãoToolStripMenuItem";
            this.pendentesDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pendentesDevoluçãoToolStripMenuItem.Text = "Pendentes Devolução";
            // 
            // locaçãoToolStripMenuItem1
            // 
            this.locaçãoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dezÚltimasLocaçõesToolStripMenuItem});
            this.locaçãoToolStripMenuItem1.Name = "locaçãoToolStripMenuItem1";
            this.locaçãoToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.locaçãoToolStripMenuItem1.Text = "Locação";
            // 
            // dezÚltimasLocaçõesToolStripMenuItem
            // 
            this.dezÚltimasLocaçõesToolStripMenuItem.Name = "dezÚltimasLocaçõesToolStripMenuItem";
            this.dezÚltimasLocaçõesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.dezÚltimasLocaçõesToolStripMenuItem.Text = "Dez últimas locações";
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
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dezÚltimasLocaçõesToolStripMenuItem;
    }
}

