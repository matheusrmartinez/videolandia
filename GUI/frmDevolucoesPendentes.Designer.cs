namespace GUI
{
    partial class frmDevolucoesPendentes
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
            this.dgvDevolucoesPendentes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucacaoPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeDiasAtrasados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoesPendentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDevolucoesPendentes
            // 
            this.dgvDevolucoesPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucoesPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCliente,
            this.NomeItem,
            this.Preco,
            this.DataDevolucacaoPrevista,
            this.QuantidadeDiasAtrasados});
            this.dgvDevolucoesPendentes.Location = new System.Drawing.Point(6, 19);
            this.dgvDevolucoesPendentes.Name = "dgvDevolucoesPendentes";
            this.dgvDevolucoesPendentes.Size = new System.Drawing.Size(544, 354);
            this.dgvDevolucoesPendentes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDevolucoesPendentes);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 397);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histórico Devolucões Pendentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o funcionário: ";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(143, 10);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(197, 21);
            this.cmbFuncionario.TabIndex = 3;
            this.cmbFuncionario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbFuncionario_MouseClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(346, 8);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "Nome";
            this.NomeCliente.HeaderText = "Nome do Cliente";
            this.NomeCliente.Name = "NomeCliente";
            // 
            // NomeItem
            // 
            this.NomeItem.DataPropertyName = "Titulo";
            this.NomeItem.HeaderText = "Nome do Item";
            this.NomeItem.Name = "NomeItem";
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Valor";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // DataDevolucacaoPrevista
            // 
            this.DataDevolucacaoPrevista.DataPropertyName = "DataPrevista";
            this.DataDevolucacaoPrevista.HeaderText = "Data de Devolução Prevista";
            this.DataDevolucacaoPrevista.Name = "DataDevolucacaoPrevista";
            // 
            // QuantidadeDiasAtrasados
            // 
            this.QuantidadeDiasAtrasados.DataPropertyName = "DiasAtrasados";
            this.QuantidadeDiasAtrasados.HeaderText = "Quantidade de Dias Atrasados";
            this.QuantidadeDiasAtrasados.Name = "QuantidadeDiasAtrasados";
            // 
            // frmDevolucoesPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cmbFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDevolucoesPendentes";
            this.Text = "Relatório: Devoluções Pendentes por Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucoesPendentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevolucoesPendentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucacaoPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeDiasAtrasados;
    }
}