namespace GUI
{
    partial class frmCadastroLocacao
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
            this.dtpDataAtual = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.btnRegistrarLocacao = new System.Windows.Forms.Button();
            this.btnFecharLocacao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataPrevista = new System.Windows.Forms.DateTimePicker();
            this.btnCodigoDeBarrasItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDataAtual
            // 
            this.dtpDataAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAtual.Location = new System.Drawing.Point(148, 84);
            this.dtpDataAtual.Name = "dtpDataAtual";
            this.dtpDataAtual.Size = new System.Drawing.Size(100, 20);
            this.dtpDataAtual.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Nome Item: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Código de Barras Item: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Data Atual: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nome Cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "CPF Cliente: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código Funcionário: ";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(148, 136);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(100, 20);
            this.txtNomeItem.TabIndex = 26;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(148, 110);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoBarras.TabIndex = 25;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(148, 58);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCliente.TabIndex = 20;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(148, 32);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 28;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(148, 6);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFuncionario.TabIndex = 19;
            // 
            // btnRegistrarLocacao
            // 
            this.btnRegistrarLocacao.Location = new System.Drawing.Point(12, 292);
            this.btnRegistrarLocacao.Name = "btnRegistrarLocacao";
            this.btnRegistrarLocacao.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrarLocacao.TabIndex = 43;
            this.btnRegistrarLocacao.Text = "Registrar Locação ";
            this.btnRegistrarLocacao.UseVisualStyleBackColor = true;
            // 
            // btnFecharLocacao
            // 
            this.btnFecharLocacao.Location = new System.Drawing.Point(135, 292);
            this.btnFecharLocacao.Name = "btnFecharLocacao";
            this.btnFecharLocacao.Size = new System.Drawing.Size(113, 23);
            this.btnFecharLocacao.TabIndex = 43;
            this.btnFecharLocacao.Text = "Fechar Locação ";
            this.btnFecharLocacao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Valor: ";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(148, 162);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Data Prevista:";
            // 
            // dtpDataPrevista
            // 
            this.dtpDataPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPrevista.Location = new System.Drawing.Point(148, 188);
            this.dtpDataPrevista.Name = "dtpDataPrevista";
            this.dtpDataPrevista.Size = new System.Drawing.Size(100, 20);
            this.dtpDataPrevista.TabIndex = 45;
            // 
            // btnCodigoDeBarrasItem
            // 
            this.btnCodigoDeBarrasItem.Location = new System.Drawing.Point(254, 110);
            this.btnCodigoDeBarrasItem.Name = "btnCodigoDeBarrasItem";
            this.btnCodigoDeBarrasItem.Size = new System.Drawing.Size(69, 20);
            this.btnCodigoDeBarrasItem.TabIndex = 43;
            this.btnCodigoDeBarrasItem.Text = "Pesquisar";
            this.btnCodigoDeBarrasItem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 20);
            this.button1.TabIndex = 43;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(148, 214);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Valor Total: ";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(148, 240);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(100, 20);
            this.txtValorPago.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Valor Pago: ";
            // 
            // frmCadastroLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 327);
            this.Controls.Add(this.dtpDataPrevista);
            this.Controls.Add(this.dtpDataAtual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCodigoDeBarrasItem);
            this.Controls.Add(this.btnFecharLocacao);
            this.Controls.Add(this.btnRegistrarLocacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNomeItem);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCodigoFuncionario);
            this.Name = "frmCadastroLocacao";
            this.Text = "Cadastro de Locação";
            this.Load += new System.EventHandler(this.frmCadastroLocacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataAtual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.Button btnRegistrarLocacao;
        private System.Windows.Forms.Button btnFecharLocacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataPrevista;
        private System.Windows.Forms.Button btnCodigoDeBarrasItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label7;
    }
}