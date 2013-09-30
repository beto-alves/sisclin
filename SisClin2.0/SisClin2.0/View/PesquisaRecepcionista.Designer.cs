namespace SisClin2._0.View
{
    partial class PesquisaRecepcionista
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
            this.dgListaRecepcionista = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtPesquisaRecepcionista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaRecepcionista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaRecepcionista
            // 
            this.dgListaRecepcionista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaRecepcionista.Location = new System.Drawing.Point(25, 52);
            this.dgListaRecepcionista.Name = "dgListaRecepcionista";
            this.dgListaRecepcionista.RowTemplate.Height = 24;
            this.dgListaRecepcionista.Size = new System.Drawing.Size(800, 378);
            this.dgListaRecepcionista.TabIndex = 7;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(467, 17);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(90, 25);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Pesquisar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaRecepcionista
            // 
            this.txtPesquisaRecepcionista.Location = new System.Drawing.Point(87, 17);
            this.txtPesquisaRecepcionista.Name = "txtPesquisaRecepcionista";
            this.txtPesquisaRecepcionista.Size = new System.Drawing.Size(375, 22);
            this.txtPesquisaRecepcionista.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // PesquisaRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 443);
            this.Controls.Add(this.dgListaRecepcionista);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtPesquisaRecepcionista);
            this.Controls.Add(this.label1);
            this.Name = "PesquisaRecepcionista";
            this.ShowIcon = false;
            this.Text = "Pesquisa Recepcionista";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaRecepcionista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaRecepcionista;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPesquisaRecepcionista;
        private System.Windows.Forms.Label label1;
    }
}