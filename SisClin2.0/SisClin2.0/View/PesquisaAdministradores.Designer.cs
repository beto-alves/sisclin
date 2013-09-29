namespace SisClin2._0.View
{
    partial class PesquisaAdministradores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaAdm = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtPesquisaAdm
            // 
            this.txtPesquisaAdm.Location = new System.Drawing.Point(90, 20);
            this.txtPesquisaAdm.Name = "txtPesquisaAdm";
            this.txtPesquisaAdm.Size = new System.Drawing.Size(375, 22);
            this.txtPesquisaAdm.TabIndex = 1;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(470, 20);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(90, 25);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Pesquisar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // PesquisaAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 445);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtPesquisaAdm);
            this.Controls.Add(this.label1);
            this.Name = "PesquisaAdministradores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pesquisa Administradores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaAdm;
        private System.Windows.Forms.Button btnProcurar;
    }
}