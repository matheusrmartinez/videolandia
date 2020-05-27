namespace GUI
{
    partial class frmHistoricoLocacoes
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
            this.dgvDezLocacoes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDezLocacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDezLocacoes);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 397);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histórico Devolucões Pendentes";
            // 
            // dgvDezLocacoes
            // 
            this.dgvDezLocacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDezLocacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.DataAtual,
            this.DataPrevista,
            this.DataEntrega,
            this.ValorPago});
            this.dgvDezLocacoes.Location = new System.Drawing.Point(6, 19);
            this.dgvDezLocacoes.Name = "dgvDezLocacoes";
            this.dgvDezLocacoes.Size = new System.Drawing.Size(544, 354);
            this.dgvDezLocacoes.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome do Cliente";
            this.Nome.Name = "Nome";
            // 
            // DataAtual
            // 
            this.DataAtual.DataPropertyName = "DataAtual";
            this.DataAtual.HeaderText = "Data Locação";
            this.DataAtual.Name = "DataAtual";
            // 
            // DataPrevista
            // 
            this.DataPrevista.DataPropertyName = "DataPrevista";
            this.DataPrevista.HeaderText = "Data Devolução Prevista";
            this.DataPrevista.Name = "DataPrevista";
            // 
            // DataEntrega
            // 
            this.DataEntrega.DataPropertyName = "DataEntrega";
            this.DataEntrega.HeaderText = "Data Devolução";
            this.DataEntrega.Name = "DataEntrega";
            // 
            // ValorPago
            // 
            this.ValorPago.DataPropertyName = "ValorPago";
            this.ValorPago.HeaderText = "Valor Pago";
            this.ValorPago.Name = "ValorPago";
            // 
            // frmHistoricoLocacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 420);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHistoricoLocacoes";
            this.Text = "Relatório: Dez Últimas Locações";
            this.Load += new System.EventHandler(this.frmHistoricoLocacoes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDezLocacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDezLocacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPago;
    }
}