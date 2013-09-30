namespace SisClin2._0.View
{
    partial class PesquisaMedico
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
            this.dgListaMedico = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtPesquisaMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaMedico
            // 
            this.dgListaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaMedico.Location = new System.Drawing.Point(28, 51);
            this.dgListaMedico.Name = "dgListaMedico";
            this.dgListaMedico.RowTemplate.Height = 24;
            this.dgListaMedico.Size = new System.Drawing.Size(800, 378);
            this.dgListaMedico.TabIndex = 7;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(470, 16);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(90, 25);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Pesquisar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaMedico
            // 
            this.txtPesquisaMedico.Location = new System.Drawing.Point(90, 16);
            this.txtPesquisaMedico.Name = "txtPesquisaMedico";
            this.txtPesquisaMedico.Size = new System.Drawing.Size(375, 22);
            this.txtPesquisaMedico.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // PesquisaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 445);
            this.Controls.Add(this.dgListaMedico);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtPesquisaMedico);
            this.Controls.Add(this.label1);
            this.Name = "PesquisaMedico";
            this.Text = "PesquisaMedico";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaMedico;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPesquisaMedico;
        private System.Windows.Forms.Label label1;
    }
}