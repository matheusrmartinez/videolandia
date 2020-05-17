namespace GUI
{
    partial class frmFuncionario
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
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSituacaoPagamentos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(114, 12);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFuncionario.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(114, 142);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 0;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(114, 168);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 0;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(114, 194);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(181, 20);
            this.txtEndereco.TabIndex = 0;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(114, 220);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 0;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(114, 246);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 0;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(114, 298);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 0;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(114, 324);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 350);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Nascimento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sexo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Estado Civil: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "RG: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "CPF: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Endereço: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cidade: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "CEP: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Estado: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Telefone: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Celular: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Email: ";
            // 
            // dtpDtNascimento
            // 
            this.dtpDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNascimento.Location = new System.Drawing.Point(114, 65);
            this.dtpDtNascimento.Name = "dtpDtNascimento";
            this.dtpDtNascimento.Size = new System.Drawing.Size(100, 20);
            this.dtpDtNascimento.TabIndex = 2;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(114, 90);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(38, 21);
            this.cmbSexo.TabIndex = 3;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(114, 116);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoCivil.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(15, 415);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(65, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(87, 415);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(65, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(158, 415);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(65, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(230, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(220, 12);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(75, 20);
            this.Pesquisar.TabIndex = 5;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            ""});
            this.cmbEstado.Location = new System.Drawing.Point(114, 272);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(47, 21);
            this.cmbEstado.TabIndex = 6;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.CPF,
            this.Status});
            this.dgvFuncionarios.Location = new System.Drawing.Point(1, 34);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(443, 168);
            this.dgvFuncionarios.TabIndex = 7;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodigoPessoa";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "SituacaoPagamentos";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFuncionarios);
            this.groupBox1.Location = new System.Drawing.Point(15, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listagem Funcionários";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Status:";
            // 
            // cmbSituacaoPagamentos
            // 
            this.cmbSituacaoPagamentos.FormattingEnabled = true;
            this.cmbSituacaoPagamentos.Items.AddRange(new object[] {
            "OK",
            "Devendo"});
            this.cmbSituacaoPagamentos.Location = new System.Drawing.Point(114, 375);
            this.cmbSituacaoPagamentos.Name = "cmbSituacaoPagamentos";
            this.cmbSituacaoPagamentos.Size = new System.Drawing.Size(121, 21);
            this.cmbSituacaoPagamentos.TabIndex = 9;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 677);
            this.Controls.Add(this.cmbSituacaoPagamentos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.dtpDtNascimento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigoFuncionario);
            this.Name = "frmFuncionario";
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDtNascimento;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSituacaoPagamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}