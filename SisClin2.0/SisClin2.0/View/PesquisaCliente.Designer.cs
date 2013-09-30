namespace SisClin2._0.View
{
    partial class PesquisaCliente
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
            this.dgListaCliente = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtPesquisaPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaCliente
            // 
            this.dgListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaCliente.Location = new System.Drawing.Point(12, 55);
            this.dgListaCliente.Name = "dgListaCliente";
            this.dgListaCliente.RowTemplate.Height = 24;
            this.dgListaCliente.Size = new System.Drawing.Size(800, 378);
            this.dgListaCliente.TabIndex = 7;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(454, 20);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(90, 25);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Pesquisar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaPaciente
            // 
            this.txtPesquisaPaciente.Location = new System.Drawing.Point(74, 20);
            this.txtPesquisaPaciente.Name = "txtPesquisaPaciente";
            this.txtPesquisaPaciente.Size = new System.Drawing.Size(375, 22);
            this.txtPesquisaPaciente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // btnNovoPaciente
            // 
            this.btnNovoPaciente.Location = new System.Drawing.Point(550, 20);
            this.btnNovoPaciente.Name = "btnNovoPaciente";
            this.btnNovoPaciente.Size = new System.Drawing.Size(125, 25);
            this.btnNovoPaciente.TabIndex = 8;
            this.btnNovoPaciente.Text = "Novo Paciente";
            this.btnNovoPaciente.UseVisualStyleBackColor = true;
            // 
            // PesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 445);
            this.Controls.Add(this.btnNovoPaciente);
            this.Controls.Add(this.dgListaCliente);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtPesquisaPaciente);
            this.Controls.Add(this.label1);
            this.Name = "PesquisaCliente";
            this.ShowIcon = false;
            this.Text = "Pesquisa Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaCliente;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPesquisaPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoPaciente;
    }
}