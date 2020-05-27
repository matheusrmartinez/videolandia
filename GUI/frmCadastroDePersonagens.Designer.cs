namespace GUI
{
    partial class frmCadastroDePersonagens
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
            this.cmbFilme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artista = new System.Windows.Forms.Label();
            this.cmbArtista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePersonagem = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbFilme
            // 
            this.cmbFilme.FormattingEnabled = true;
            this.cmbFilme.Location = new System.Drawing.Point(140, 10);
            this.cmbFilme.Name = "cmbFilme";
            this.cmbFilme.Size = new System.Drawing.Size(154, 21);
            this.cmbFilme.TabIndex = 0;
            this.cmbFilme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbFilme_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o filme: ";
            // 
            // artista
            // 
            this.artista.AutoSize = true;
            this.artista.Location = new System.Drawing.Point(12, 40);
            this.artista.Name = "artista";
            this.artista.Size = new System.Drawing.Size(100, 13);
            this.artista.TabIndex = 2;
            this.artista.Text = "Selecione o artista: ";
            // 
            // cmbArtista
            // 
            this.cmbArtista.FormattingEnabled = true;
            this.cmbArtista.Location = new System.Drawing.Point(140, 37);
            this.cmbArtista.Name = "cmbArtista";
            this.cmbArtista.Size = new System.Drawing.Size(154, 21);
            this.cmbArtista.TabIndex = 0;
            this.cmbArtista.SelectedValueChanged += new System.EventHandler(this.cmbArtista_SelectedValueChanged);
            this.cmbArtista.TextChanged += new System.EventHandler(this.cmbArtista_TextChanged);
            this.cmbArtista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbArtista_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Personagem: ";
            // 
            // txtNomePersonagem
            // 
            this.txtNomePersonagem.Location = new System.Drawing.Point(140, 64);
            this.txtNomePersonagem.Name = "txtNomePersonagem";
            this.txtNomePersonagem.Size = new System.Drawing.Size(154, 20);
            this.txtNomePersonagem.TabIndex = 4;
            this.txtNomePersonagem.TextChanged += new System.EventHandler(this.txtNomePersonagem_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(229, 106);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(158, 106);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(65, 23);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(87, 106);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(65, 23);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(15, 106);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(65, 23);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(300, 64);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(65, 20);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmCadastroDePersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 145);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNomePersonagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.artista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbArtista);
            this.Controls.Add(this.cmbFilme);
            this.Name = "frmCadastroDePersonagens";
            this.Text = "Cadastro De Personagens do Filme";
            this.Load += new System.EventHandler(this.frmCadastroDePersonagens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label artista;
        private System.Windows.Forms.ComboBox cmbArtista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePersonagem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}