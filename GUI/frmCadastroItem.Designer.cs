
namespace GUI
{
    partial class frmCadastroItem
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
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAtoresParticipantes = new System.Windows.Forms.DataGridView();
            this.NomeArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePersonagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDataAdquirida = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbFotoFilme = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbGenero4 = new System.Windows.Forms.ComboBox();
            this.cmbGenero3 = new System.Windows.Forms.ComboBox();
            this.cmbGenero2 = new System.Windows.Forms.ComboBox();
            this.cmbGenero8 = new System.Windows.Forms.ComboBox();
            this.cmbGenero7 = new System.Windows.Forms.ComboBox();
            this.cmbGenero6 = new System.Windows.Forms.ComboBox();
            this.cmbGenero5 = new System.Windows.Forms.ComboBox();
            this.cmbGenero1 = new System.Windows.Forms.ComboBox();
            this.btnPesquisarCodigoDeBarras = new System.Windows.Forms.Button();
            this.btnPesquisarTitulo = new System.Windows.Forms.Button();
            this.btnFotoFilme = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtoresParticipantes)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoFilme)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Location = new System.Drawing.Point(148, 12);
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoItem.TabIndex = 0;
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(148, 38);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDeBarras.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(148, 64);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(148, 91);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 0;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(148, 117);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 0;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(148, 143);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 0;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(148, 195);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCusto.TabIndex = 0;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(148, 221);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(100, 20);
            this.txtSituacao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de Barras: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Título: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ano: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Preço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Data Adquirida: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Custo: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Situação: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvItens);
            this.groupBox1.Location = new System.Drawing.Point(15, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 223);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listagem Itens";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Status});
            this.dgvItens.Location = new System.Drawing.Point(6, 30);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(445, 193);
            this.dgvItens.TabIndex = 7;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.DataPropertyName = "CodigoDeBarras";
            this.Codigo.HeaderText = "Código de Barras";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Titulo";
            this.Nome.HeaderText = "Nome do filme";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Ano";
            this.Status.HeaderText = "Ano";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(229, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(158, 404);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(65, 23);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(87, 404);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(65, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(15, 404);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(65, 23);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAtoresParticipantes);
            this.groupBox2.Location = new System.Drawing.Point(495, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 173);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artistas Participantes:";
            // 
            // dgvAtoresParticipantes
            // 
            this.dgvAtoresParticipantes.AllowUserToAddRows = false;
            this.dgvAtoresParticipantes.AllowUserToDeleteRows = false;
            this.dgvAtoresParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtoresParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeArtista,
            this.NomePersonagem});
            this.dgvAtoresParticipantes.Location = new System.Drawing.Point(6, 19);
            this.dgvAtoresParticipantes.Name = "dgvAtoresParticipantes";
            this.dgvAtoresParticipantes.ReadOnly = true;
            this.dgvAtoresParticipantes.Size = new System.Drawing.Size(344, 146);
            this.dgvAtoresParticipantes.TabIndex = 7;
            // 
            // NomeArtista
            // 
            this.NomeArtista.DataPropertyName = "Nome";
            this.NomeArtista.HeaderText = "Nome Artista";
            this.NomeArtista.Name = "NomeArtista";
            this.NomeArtista.ReadOnly = true;
            this.NomeArtista.Width = 150;
            // 
            // NomePersonagem
            // 
            this.NomePersonagem.DataPropertyName = "NomePersonagem";
            this.NomePersonagem.HeaderText = "Nome do Personagem";
            this.NomePersonagem.Name = "NomePersonagem";
            this.NomePersonagem.ReadOnly = true;
            this.NomePersonagem.Width = 150;
            // 
            // dtpDataAdquirida
            // 
            this.dtpDataAdquirida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdquirida.Location = new System.Drawing.Point(148, 169);
            this.dtpDataAdquirida.Name = "dtpDataAdquirida";
            this.dtpDataAdquirida.Size = new System.Drawing.Size(100, 20);
            this.dtpDataAdquirida.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbFotoFilme);
            this.groupBox3.Location = new System.Drawing.Point(496, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 512);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Capa do Filme: ";
            // 
            // pbFotoFilme
            // 
            this.pbFotoFilme.Location = new System.Drawing.Point(5, 20);
            this.pbFotoFilme.Name = "pbFotoFilme";
            this.pbFotoFilme.Size = new System.Drawing.Size(471, 486);
            this.pbFotoFilme.TabIndex = 0;
            this.pbFotoFilme.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbGenero4);
            this.groupBox4.Controls.Add(this.cmbGenero3);
            this.groupBox4.Controls.Add(this.cmbGenero2);
            this.groupBox4.Controls.Add(this.cmbGenero8);
            this.groupBox4.Controls.Add(this.cmbGenero7);
            this.groupBox4.Controls.Add(this.cmbGenero6);
            this.groupBox4.Controls.Add(this.cmbGenero5);
            this.groupBox4.Controls.Add(this.cmbGenero1);
            this.groupBox4.Location = new System.Drawing.Point(15, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 129);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gênero Filme: ";
            // 
            // cmbGenero4
            // 
            this.cmbGenero4.FormattingEnabled = true;
            this.cmbGenero4.Location = new System.Drawing.Point(7, 101);
            this.cmbGenero4.Name = "cmbGenero4";
            this.cmbGenero4.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero4.TabIndex = 0;
            // 
            // cmbGenero3
            // 
            this.cmbGenero3.FormattingEnabled = true;
            this.cmbGenero3.Location = new System.Drawing.Point(7, 74);
            this.cmbGenero3.Name = "cmbGenero3";
            this.cmbGenero3.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero3.TabIndex = 0;
            // 
            // cmbGenero2
            // 
            this.cmbGenero2.FormattingEnabled = true;
            this.cmbGenero2.Location = new System.Drawing.Point(7, 47);
            this.cmbGenero2.Name = "cmbGenero2";
            this.cmbGenero2.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero2.TabIndex = 0;
            // 
            // cmbGenero8
            // 
            this.cmbGenero8.FormattingEnabled = true;
            this.cmbGenero8.Location = new System.Drawing.Point(147, 100);
            this.cmbGenero8.Name = "cmbGenero8";
            this.cmbGenero8.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero8.TabIndex = 0;
            // 
            // cmbGenero7
            // 
            this.cmbGenero7.FormattingEnabled = true;
            this.cmbGenero7.Location = new System.Drawing.Point(147, 73);
            this.cmbGenero7.Name = "cmbGenero7";
            this.cmbGenero7.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero7.TabIndex = 0;
            // 
            // cmbGenero6
            // 
            this.cmbGenero6.FormattingEnabled = true;
            this.cmbGenero6.Location = new System.Drawing.Point(147, 46);
            this.cmbGenero6.Name = "cmbGenero6";
            this.cmbGenero6.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero6.TabIndex = 0;
            // 
            // cmbGenero5
            // 
            this.cmbGenero5.FormattingEnabled = true;
            this.cmbGenero5.Location = new System.Drawing.Point(147, 19);
            this.cmbGenero5.Name = "cmbGenero5";
            this.cmbGenero5.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero5.TabIndex = 0;
            // 
            // cmbGenero1
            // 
            this.cmbGenero1.FormattingEnabled = true;
            this.cmbGenero1.Location = new System.Drawing.Point(7, 20);
            this.cmbGenero1.Name = "cmbGenero1";
            this.cmbGenero1.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero1.TabIndex = 0;
            // 
            // btnPesquisarCodigoDeBarras
            // 
            this.btnPesquisarCodigoDeBarras.Location = new System.Drawing.Point(254, 38);
            this.btnPesquisarCodigoDeBarras.Name = "btnPesquisarCodigoDeBarras";
            this.btnPesquisarCodigoDeBarras.Size = new System.Drawing.Size(75, 20);
            this.btnPesquisarCodigoDeBarras.TabIndex = 19;
            this.btnPesquisarCodigoDeBarras.Text = "Pesquisar";
            this.btnPesquisarCodigoDeBarras.UseVisualStyleBackColor = true;
            this.btnPesquisarCodigoDeBarras.Click += new System.EventHandler(this.btnPesquisarCodigoDeBarras_Click_1);
            // 
            // btnPesquisarTitulo
            // 
            this.btnPesquisarTitulo.Location = new System.Drawing.Point(254, 64);
            this.btnPesquisarTitulo.Name = "btnPesquisarTitulo";
            this.btnPesquisarTitulo.Size = new System.Drawing.Size(75, 20);
            this.btnPesquisarTitulo.TabIndex = 19;
            this.btnPesquisarTitulo.Text = "Pesquisar";
            this.btnPesquisarTitulo.UseVisualStyleBackColor = true;
            this.btnPesquisarTitulo.Click += new System.EventHandler(this.btnPesquisarTitulo_Click_1);
            // 
            // btnFotoFilme
            // 
            this.btnFotoFilme.Location = new System.Drawing.Point(885, 716);
            this.btnFotoFilme.Name = "btnFotoFilme";
            this.btnFotoFilme.Size = new System.Drawing.Size(93, 23);
            this.btnFotoFilme.TabIndex = 20;
            this.btnFotoFilme.Text = "Selecionar Foto";
            this.btnFotoFilme.UseVisualStyleBackColor = true;
            this.btnFotoFilme.Click += new System.EventHandler(this.btnFotoFilme_Click);
            // 
            // frmCadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 751);
            this.Controls.Add(this.btnFotoFilme);
            this.Controls.Add(this.btnPesquisarTitulo);
            this.Controls.Add(this.btnPesquisarCodigoDeBarras);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtpDataAdquirida);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigoDeBarras);
            this.Controls.Add(this.txtCodigoItem);
            this.Name = "frmCadastroItem";
            this.Text = "Cadastro de Item";
            this.Load += new System.EventHandler(this.frmcadastroitem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtoresParticipantes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoFilme)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoItem;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDataAdquirida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbFotoFilme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbGenero4;
        private System.Windows.Forms.ComboBox cmbGenero3;
        private System.Windows.Forms.ComboBox cmbGenero2;
        private System.Windows.Forms.ComboBox cmbGenero8;
        private System.Windows.Forms.ComboBox cmbGenero7;
        private System.Windows.Forms.ComboBox cmbGenero6;
        private System.Windows.Forms.ComboBox cmbGenero5;
        private System.Windows.Forms.ComboBox cmbGenero1;
        private System.Windows.Forms.DataGridView dgvAtoresParticipantes;
        private System.Windows.Forms.Button btnPesquisarCodigoDeBarras;
        private System.Windows.Forms.Button btnPesquisarTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePersonagem;
        private System.Windows.Forms.Button btnFotoFilme;
    }
}