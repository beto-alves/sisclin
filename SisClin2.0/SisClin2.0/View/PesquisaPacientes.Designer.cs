namespace SisClin2._0.View
{
    partial class PesquisaPacientes
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
            this.dgPesquisaPaciente = new System.Windows.Forms.DataGridView();
            this.txtPesquisaPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisaPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPesquisaPaciente
            // 
            this.dgPesquisaPaciente.AllowUserToAddRows = false;
            this.dgPesquisaPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPesquisaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisaPaciente.Location = new System.Drawing.Point(13, 39);
            this.dgPesquisaPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.dgPesquisaPaciente.Name = "dgPesquisaPaciente";
            this.dgPesquisaPaciente.Size = new System.Drawing.Size(707, 350);
            this.dgPesquisaPaciente.TabIndex = 6;
            this.dgPesquisaPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisaPaciente_CellDoubleClick);
            // 
            // txtPesquisaPaciente
            // 
            this.txtPesquisaPaciente.Location = new System.Drawing.Point(72, 6);
            this.txtPesquisaPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaPaciente.Name = "txtPesquisaPaciente";
            this.txtPesquisaPaciente.Size = new System.Drawing.Size(401, 22);
            this.txtPesquisaPaciente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(480, 2);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(90, 30);
            this.btnProcurar.TabIndex = 7;
            this.btnProcurar.Text = "Pesquisar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // PesquisaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 405);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.dgPesquisaPaciente);
            this.Controls.Add(this.txtPesquisaPaciente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesquisaPacientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Lista Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisaPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPesquisaPaciente;
        private System.Windows.Forms.TextBox txtPesquisaPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcurar;
    }
}