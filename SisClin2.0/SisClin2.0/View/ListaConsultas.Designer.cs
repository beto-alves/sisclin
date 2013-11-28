namespace SisClin2._0.View
{
    partial class ListaConsultas
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
            this.lblPaciente = new System.Windows.Forms.Label();
            this.dgListaConsultas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizar Histórico de Consultas:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(340, 13);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(91, 24);
            this.lblPaciente.TabIndex = 1;
            this.lblPaciente.Text = "Paciente";
            // 
            // dgListaConsultas
            // 
            this.dgListaConsultas.AllowUserToAddRows = false;
            this.dgListaConsultas.AllowUserToDeleteRows = false;
            this.dgListaConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaConsultas.Location = new System.Drawing.Point(18, 55);
            this.dgListaConsultas.Name = "dgListaConsultas";
            this.dgListaConsultas.ReadOnly = true;
            this.dgListaConsultas.RowTemplate.Height = 24;
            this.dgListaConsultas.Size = new System.Drawing.Size(894, 458);
            this.dgListaConsultas.TabIndex = 2;
            this.dgListaConsultas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaConsultas_CellDoubleClick);
            // 
            // ListaConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 525);
            this.Controls.Add(this.dgListaConsultas);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.label1);
            this.Name = "ListaConsultas";
            this.ShowIcon = false;
            this.Text = "Lista Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.DataGridView dgListaConsultas;
    }
}