namespace SisClin2._0.View
{
    partial class MovimentacaoFinanceiraCliente
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
            this.dgMovimentacao = new System.Windows.Forms.DataGridView();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovimentacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMovimentacao
            // 
            this.dgMovimentacao.AllowUserToAddRows = false;
            this.dgMovimentacao.AllowUserToDeleteRows = false;
            this.dgMovimentacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovimentacao.Location = new System.Drawing.Point(22, 54);
            this.dgMovimentacao.Name = "dgMovimentacao";
            this.dgMovimentacao.ReadOnly = true;
            this.dgMovimentacao.RowTemplate.Height = 24;
            this.dgMovimentacao.Size = new System.Drawing.Size(894, 458);
            this.dgMovimentacao.TabIndex = 5;
            this.dgMovimentacao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgMovimentacao_CellFormatting);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(246, 12);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(82, 20);
            this.lblPaciente.TabIndex = 4;
            this.lblPaciente.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movimentação Financeira";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Efetuar Pagamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saldo devedor:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSaldo.Location = new System.Drawing.Point(340, 525);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(75, 20);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "devedor";
            // 
            // MovimentacaoFinanceiraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 561);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgMovimentacao);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.label1);
            this.Name = "MovimentacaoFinanceiraCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Movimentação Financeira";
            ((System.ComponentModel.ISupportInitialize)(this.dgMovimentacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMovimentacao;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldo;
    }
}