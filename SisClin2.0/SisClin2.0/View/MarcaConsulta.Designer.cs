namespace SisClin2._0.View
{
    partial class MarcaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcaConsulta));
            this.label2 = new System.Windows.Forms.Label();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.dgListaConsultas = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Médico:";
            // 
            // cbMedico
            // 
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(114, 20);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(345, 24);
            this.cbMedico.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data:";
            // 
            // dtDataConsulta
            // 
            this.dtDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataConsulta.Location = new System.Drawing.Point(114, 50);
            this.dtDataConsulta.Name = "dtDataConsulta";
            this.dtDataConsulta.Size = new System.Drawing.Size(113, 22);
            this.dtDataConsulta.TabIndex = 10;
            this.dtDataConsulta.Value = new System.DateTime(2013, 10, 5, 0, 0, 0, 0);
            this.dtDataConsulta.ValueChanged += new System.EventHandler(this.dtDataConsulta_ValueChanged);
            // 
            // dgListaConsultas
            // 
            this.dgListaConsultas.AllowUserToAddRows = false;
            this.dgListaConsultas.AllowUserToDeleteRows = false;
            this.dgListaConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaConsultas.Location = new System.Drawing.Point(19, 92);
            this.dgListaConsultas.Name = "dgListaConsultas";
            this.dgListaConsultas.RowTemplate.Height = 24;
            this.dgListaConsultas.Size = new System.Drawing.Size(534, 337);
            this.dgListaConsultas.TabIndex = 14;
            this.dgListaConsultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaConsultas_CellClick);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(19, 449);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInserir.Size = new System.Drawing.Size(160, 40);
            this.btnInserir.TabIndex = 38;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // MarcaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 504);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgListaConsultas);
            this.Controls.Add(this.dtDataConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.label2);
            this.Name = "MarcaConsulta";
            this.ShowIcon = false;
            this.Text = "Marca Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataConsulta;
        private System.Windows.Forms.DataGridView dgListaConsultas;
        private System.Windows.Forms.Button btnInserir;
    }
}