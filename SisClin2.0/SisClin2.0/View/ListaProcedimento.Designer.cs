namespace SisClin2._0.View
{
    partial class ListaProcedimento
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
            this.dgListaProcedimentos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProcedimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaProcedimentos
            // 
            this.dgListaProcedimentos.AllowUserToAddRows = false;
            this.dgListaProcedimentos.AllowUserToDeleteRows = false;
            this.dgListaProcedimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaProcedimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaProcedimentos.Location = new System.Drawing.Point(12, 53);
            this.dgListaProcedimentos.Name = "dgListaProcedimentos";
            this.dgListaProcedimentos.ReadOnly = true;
            this.dgListaProcedimentos.RowTemplate.Height = 24;
            this.dgListaProcedimentos.Size = new System.Drawing.Size(858, 390);
            this.dgListaProcedimentos.TabIndex = 4;
            this.dgListaProcedimentos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaProcedimentos_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Procedimentos";
            // 
            // ListaProcedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 455);
            this.Controls.Add(this.dgListaProcedimentos);
            this.Controls.Add(this.label1);
            this.Name = "ListaProcedimento";
            this.ShowIcon = false;
            this.Text = "Lista Procedimento";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProcedimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaProcedimentos;
        private System.Windows.Forms.Label label1;
    }
}