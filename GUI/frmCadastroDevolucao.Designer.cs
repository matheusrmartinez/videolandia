namespace GUI
{
    partial class frmCadastroDevolucao
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
            this.dtpDataPrevista = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnRegistrarLocacao = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.txtNovoValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJurosEMulta = new System.Windows.Forms.TextBox();
            this.btnFecharDevolucao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoDevolucao = new System.Windows.Forms.TextBox();
            this.txtFaltaPagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDataPrevista
            // 
            this.dtpDataPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPrevista.Location = new System.Drawing.Point(148, 87);
            this.dtpDataPrevista.Name = "dtpDataPrevista";
            this.dtpDataPrevista.Size = new System.Drawing.Size(100, 20);
            this.dtpDataPrevista.TabIndex = 69;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(254, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(69, 20);
            this.btnPesquisar.TabIndex = 67;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnRegistrarLocacao
            // 
            this.btnRegistrarLocacao.Location = new System.Drawing.Point(15, 310);
            this.btnRegistrarLocacao.Name = "btnRegistrarLocacao";
            this.btnRegistrarLocacao.Size = new System.Drawing.Size(114, 23);
            this.btnRegistrarLocacao.TabIndex = 64;
            this.btnRegistrarLocacao.Text = "Registrar Devolução";
            this.btnRegistrarLocacao.UseVisualStyleBackColor = true;
            this.btnRegistrarLocacao.Click += new System.EventHandler(this.btnRegistrarLocacao_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Valor Total Pago: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Valor Total: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Preço: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Título: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Código de Barras Item: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Data Prevista: ";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(148, 165);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(100, 20);
            this.txtValorPago.TabIndex = 52;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(148, 217);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 51;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(148, 139);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 50;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(148, 61);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 49;
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(148, 34);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDeBarras.TabIndex = 49;
            // 
            // txtNovoValor
            // 
            this.txtNovoValor.Location = new System.Drawing.Point(148, 271);
            this.txtNovoValor.Name = "txtNovoValor";
            this.txtNovoValor.Size = new System.Drawing.Size(100, 20);
            this.txtNovoValor.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Novo Valor Pago: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Data Entrega:";
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.Location = new System.Drawing.Point(148, 113);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(100, 20);
            this.dtpDataEntrega.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Juros/Multa Total:";
            // 
            // txtJurosEMulta
            // 
            this.txtJurosEMulta.Location = new System.Drawing.Point(148, 191);
            this.txtJurosEMulta.Name = "txtJurosEMulta";
            this.txtJurosEMulta.Size = new System.Drawing.Size(100, 20);
            this.txtJurosEMulta.TabIndex = 52;
            // 
            // btnFecharDevolucao
            // 
            this.btnFecharDevolucao.Location = new System.Drawing.Point(135, 310);
            this.btnFecharDevolucao.Name = "btnFecharDevolucao";
            this.btnFecharDevolucao.Size = new System.Drawing.Size(115, 23);
            this.btnFecharDevolucao.TabIndex = 64;
            this.btnFecharDevolucao.Text = "Fechar Devolução";
            this.btnFecharDevolucao.UseVisualStyleBackColor = true;
            this.btnFecharDevolucao.Click += new System.EventHandler(this.btnFecharDevolucao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Código Devolução: ";
            // 
            // txtCodigoDevolucao
            // 
            this.txtCodigoDevolucao.Location = new System.Drawing.Point(148, 6);
            this.txtCodigoDevolucao.Name = "txtCodigoDevolucao";
            this.txtCodigoDevolucao.Size = new System.Drawing.Size(98, 20);
            this.txtCodigoDevolucao.TabIndex = 49;
            // 
            // txtFaltaPagar
            // 
            this.txtFaltaPagar.Location = new System.Drawing.Point(148, 243);
            this.txtFaltaPagar.Name = "txtFaltaPagar";
            this.txtFaltaPagar.Size = new System.Drawing.Size(100, 20);
            this.txtFaltaPagar.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Falta Pagar: ";
            // 
            // frmCadastroDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 350);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(this.dtpDataPrevista);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnFecharDevolucao);
            this.Controls.Add(this.btnRegistrarLocacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNovoValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJurosEMulta);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtFaltaPagar);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCodigoDevolucao);
            this.Controls.Add(this.txtCodigoDeBarras);
            this.Controls.Add(this.txtTitulo);
            this.Name = "frmCadastroDevolucao";
            this.Text = "Cadastro de Devolução";
            this.Load += new System.EventHandler(this.frmCadastroDevolucao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataPrevista;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnRegistrarLocacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.TextBox txtNovoValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJurosEMulta;
        private System.Windows.Forms.Button btnFecharDevolucao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoDevolucao;
        private System.Windows.Forms.TextBox txtFaltaPagar;
        private System.Windows.Forms.Label label11;
    }
}