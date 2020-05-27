namespace GUI
{
    partial class frmCadastroArtista
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFilmesArtista = new System.Windows.Forms.DataGridView();
            this.btnPesquisarNomeAtor = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAtor = new System.Windows.Forms.TextBox();
            this.txtCodigoArtista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeDiretor = new System.Windows.Forms.TextBox();
            this.btnPesquisarNomeDiretor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaisNascimento = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbArtista = new System.Windows.Forms.PictureBox();
            this.Filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomedoPersonagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmesArtista)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFilmesArtista);
            this.groupBox1.Location = new System.Drawing.Point(16, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 213);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Filmes do Artista";
            // 
            // dgvFilmesArtista
            // 
            this.dgvFilmesArtista.AllowUserToAddRows = false;
            this.dgvFilmesArtista.AllowUserToDeleteRows = false;
            this.dgvFilmesArtista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmesArtista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filme,
            this.NomedoPersonagem});
            this.dgvFilmesArtista.Location = new System.Drawing.Point(6, 29);
            this.dgvFilmesArtista.Name = "dgvFilmesArtista";
            this.dgvFilmesArtista.ReadOnly = true;
            this.dgvFilmesArtista.Size = new System.Drawing.Size(382, 178);
            this.dgvFilmesArtista.TabIndex = 7;
            // 
            // btnPesquisarNomeAtor
            // 
            this.btnPesquisarNomeAtor.Location = new System.Drawing.Point(241, 30);
            this.btnPesquisarNomeAtor.Name = "btnPesquisarNomeAtor";
            this.btnPesquisarNomeAtor.Size = new System.Drawing.Size(65, 23);
            this.btnPesquisarNomeAtor.TabIndex = 53;
            this.btnPesquisarNomeAtor.Text = "Pesquisar";
            this.btnPesquisarNomeAtor.UseVisualStyleBackColor = true;
            this.btnPesquisarNomeAtor.Click += new System.EventHandler(this.btnPesquisarNomeAtor_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(162, 427);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(65, 23);
            this.btnRemover.TabIndex = 52;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(91, 427);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(65, 23);
            this.btnAtualizar.TabIndex = 51;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(20, 427);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(65, 23);
            this.btnAdicionar.TabIndex = 50;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nome Ator: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Código:";
            // 
            // txtNomeAtor
            // 
            this.txtNomeAtor.Location = new System.Drawing.Point(113, 32);
            this.txtNomeAtor.Name = "txtNomeAtor";
            this.txtNomeAtor.Size = new System.Drawing.Size(122, 20);
            this.txtNomeAtor.TabIndex = 46;
            this.txtNomeAtor.TextChanged += new System.EventHandler(this.txtNomeAtor_TextChanged);
            // 
            // txtCodigoArtista
            // 
            this.txtCodigoArtista.Location = new System.Drawing.Point(113, 6);
            this.txtCodigoArtista.Name = "txtCodigoArtista";
            this.txtCodigoArtista.Size = new System.Drawing.Size(122, 20);
            this.txtCodigoArtista.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nome Diretor: ";
            // 
            // txtNomeDiretor
            // 
            this.txtNomeDiretor.Location = new System.Drawing.Point(113, 58);
            this.txtNomeDiretor.Name = "txtNomeDiretor";
            this.txtNomeDiretor.Size = new System.Drawing.Size(122, 20);
            this.txtNomeDiretor.TabIndex = 46;
            this.txtNomeDiretor.TextChanged += new System.EventHandler(this.txtNomeDiretor_TextChanged);
            // 
            // btnPesquisarNomeDiretor
            // 
            this.btnPesquisarNomeDiretor.Location = new System.Drawing.Point(241, 56);
            this.btnPesquisarNomeDiretor.Name = "btnPesquisarNomeDiretor";
            this.btnPesquisarNomeDiretor.Size = new System.Drawing.Size(65, 23);
            this.btnPesquisarNomeDiretor.TabIndex = 53;
            this.btnPesquisarNomeDiretor.Text = "Pesquisar";
            this.btnPesquisarNomeDiretor.UseVisualStyleBackColor = true;
            this.btnPesquisarNomeDiretor.Click += new System.EventHandler(this.btnPesquisarNomeDiretor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Data Nascimento: ";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(113, 84);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(122, 20);
            this.dtpDataNascimento.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "País Nascimento: ";
            // 
            // txtPaisNascimento
            // 
            this.txtPaisNascimento.Location = new System.Drawing.Point(113, 110);
            this.txtPaisNascimento.Name = "txtPaisNascimento";
            this.txtPaisNascimento.Size = new System.Drawing.Size(122, 20);
            this.txtPaisNascimento.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbArtista);
            this.groupBox2.Location = new System.Drawing.Point(15, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 280);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto Artista";
            // 
            // pbArtista
            // 
            this.pbArtista.Location = new System.Drawing.Point(7, 20);
            this.pbArtista.Name = "pbArtista";
            this.pbArtista.Size = new System.Drawing.Size(382, 254);
            this.pbArtista.TabIndex = 0;
            this.pbArtista.TabStop = false;
            // 
            // Filme
            // 
            this.Filme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Filme.DataPropertyName = "Titulo";
            this.Filme.HeaderText = "Filme";
            this.Filme.Name = "Filme";
            this.Filme.ReadOnly = true;
            this.Filme.Width = 239;
            // 
            // NomedoPersonagem
            // 
            this.NomedoPersonagem.DataPropertyName = "NomePersonagem";
            this.NomedoPersonagem.HeaderText = "Nome do Personagem";
            this.NomedoPersonagem.Name = "NomedoPersonagem";
            this.NomedoPersonagem.ReadOnly = true;
            // 
            // frmCadastroArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPesquisarNomeDiretor);
            this.Controls.Add(this.btnPesquisarNomeAtor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPaisNascimento);
            this.Controls.Add(this.txtNomeDiretor);
            this.Controls.Add(this.txtNomeAtor);
            this.Controls.Add(this.txtCodigoArtista);
            this.Name = "frmCadastroArtista";
            this.Text = "Cadastro de Artista";
            this.Load += new System.EventHandler(this.frmCadastroArtista_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmesArtista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArtista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFilmesArtista;
        private System.Windows.Forms.Button btnPesquisarNomeAtor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAtor;
        private System.Windows.Forms.TextBox txtCodigoArtista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeDiretor;
        private System.Windows.Forms.Button btnPesquisarNomeDiretor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaisNascimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomedoPersonagem;
    }
}