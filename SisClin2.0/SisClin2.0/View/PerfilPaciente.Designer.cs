namespace SisClin2._0.View
{
    partial class PerfilPaciente
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
            this.pbFotoPaciente = new System.Windows.Forms.PictureBox();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFotoPaciente
            // 
            this.pbFotoPaciente.Location = new System.Drawing.Point(217, 50);
            this.pbFotoPaciente.Name = "pbFotoPaciente";
            this.pbFotoPaciente.Size = new System.Drawing.Size(348, 201);
            this.pbFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoPaciente.TabIndex = 1;
            this.pbFotoPaciente.TabStop = false;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(298, 317);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(187, 30);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Histórico de Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Location = new System.Drawing.Point(298, 353);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(187, 30);
            this.btnFinanceiro.TabIndex = 4;
            this.btnFinanceiro.Text = "Histórico Financeiros";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(217, 268);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(348, 25);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "label1";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerfilPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 605);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.pbFotoPaciente);
            this.Name = "PerfilPaciente";
            this.ShowIcon = false;
            this.Text = "Perfil Paciente";
            this.Load += new System.EventHandler(this.PerfilPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFotoPaciente;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Label lblNome;
    }
}