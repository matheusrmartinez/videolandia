namespace GUI
{
    partial class frmHistoricoLocacaoClientes
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
            this.dgvLocacoesClientes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLocacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucaoPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacoesClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLocacoesClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 397);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histórico Locações Clientes";
            // 
            // dgvLocacoesClientes
            // 
            this.dgvLocacoesClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocacoesClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.DataLocacao,
            this.DataDevolucao,
            this.ValorPago,
            this.DataDevolucaoPrevista});
            this.dgvLocacoesClientes.Location = new System.Drawing.Point(7, 20);
            this.dgvLocacoesClientes.Name = "dgvLocacoesClientes";
            this.dgvLocacoesClientes.Size = new System.Drawing.Size(537, 371);
            this.dgvLocacoesClientes.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.Frozen = true;
            this.Nome.HeaderText = "Nome Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // DataLocacao
            // 
            this.DataLocacao.DataPropertyName = "DataAtual";
            this.DataLocacao.Frozen = true;
            this.DataLocacao.HeaderText = "Data Locação";
            this.DataLocacao.Name = "DataLocacao";
            this.DataLocacao.ReadOnly = true;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.DataPropertyName = "DataEntrega";
            this.DataDevolucao.Frozen = true;
            this.DataDevolucao.HeaderText = "Data Devolução";
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.ReadOnly = true;
            // 
            // ValorPago
            // 
            this.ValorPago.DataPropertyName = "ValorPago";
            this.ValorPago.Frozen = true;
            this.ValorPago.HeaderText = "Valor Pago";
            this.ValorPago.Name = "ValorPago";
            this.ValorPago.ReadOnly = true;
            // 
            // DataDevolucaoPrevista
            // 
            this.DataDevolucaoPrevista.DataPropertyName = "DataPrevista";
            this.DataDevolucaoPrevista.Frozen = true;
            this.DataDevolucaoPrevista.HeaderText = "Data Devolução Prevista";
            this.DataDevolucaoPrevista.Name = "DataDevolucaoPrevista";
            this.DataDevolucaoPrevista.ReadOnly = true;
            // 
            // frmHistoricoLocacaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 419);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHistoricoLocacaoClientes";
            this.Text = "Relatório: Histórico Locações Clientes";
            this.Load += new System.EventHandler(this.frmHistoricoLocacaoClientes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacoesClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLocacoesClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLocacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucaoPrevista;
    }
}