namespace SisClin2._0.View
{
    partial class RealizarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarConsulta));
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnNovaReceita = new System.Windows.Forms.Button();
            this.btnNovoAtestado = new System.Windows.Forms.Button();
            this.textInformacoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxHorario
            // 
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Items.AddRange(new object[] {
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.cbxHorario.Location = new System.Drawing.Point(177, 40);
            this.cbxHorario.Margin = new System.Windows.Forms.Padding(4);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(100, 24);
            this.cbxHorario.TabIndex = 1015;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 1014;
            this.label6.Text = "Horário:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(173, 8);
            this.lblMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(66, 24);
            this.lblMedico.TabIndex = 1013;
            this.lblMedico.Text = "label6";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.Location = new System.Drawing.Point(566, 65);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(100, 34);
            this.btnProcurar.TabIndex = 1010;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnNovaReceita
            // 
            this.btnNovaReceita.Enabled = false;
            this.btnNovaReceita.Location = new System.Drawing.Point(347, 264);
            this.btnNovaReceita.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovaReceita.Name = "btnNovaReceita";
            this.btnNovaReceita.Size = new System.Drawing.Size(149, 47);
            this.btnNovaReceita.TabIndex = 1009;
            this.btnNovaReceita.Text = "Gerar Receita";
            this.btnNovaReceita.UseVisualStyleBackColor = true;
            // 
            // btnNovoAtestado
            // 
            this.btnNovoAtestado.Enabled = false;
            this.btnNovoAtestado.Location = new System.Drawing.Point(177, 264);
            this.btnNovoAtestado.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoAtestado.Name = "btnNovoAtestado";
            this.btnNovoAtestado.Size = new System.Drawing.Size(149, 47);
            this.btnNovoAtestado.TabIndex = 1008;
            this.btnNovoAtestado.Text = "Gerar Atestado";
            this.btnNovoAtestado.UseVisualStyleBackColor = true;
            // 
            // textInformacoes
            // 
            this.textInformacoes.Location = new System.Drawing.Point(177, 108);
            this.textInformacoes.Margin = new System.Windows.Forms.Padding(4);
            this.textInformacoes.Multiline = true;
            this.textInformacoes.Name = "textInformacoes";
            this.textInformacoes.Size = new System.Drawing.Size(759, 148);
            this.textInformacoes.TabIndex = 1007;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 1006;
            this.label3.Text = "Informações:";
            // 
            // textPaciente
            // 
            this.textPaciente.Location = new System.Drawing.Point(177, 73);
            this.textPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.textPaciente.Name = "textPaciente";
            this.textPaciente.Size = new System.Drawing.Size(380, 22);
            this.textPaciente.TabIndex = 1005;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1004;
            this.label2.Text = "Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1003;
            this.label1.Text = "Médico:";
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(345, 319);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInserir.Size = new System.Drawing.Size(160, 40);
            this.btnInserir.TabIndex = 1017;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(177, 319);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(160, 40);
            this.btnPesquisar.TabIndex = 1016;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // RealizarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 372);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbxHorario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnNovaReceita);
            this.Controls.Add(this.btnNovoAtestado);
            this.Controls.Add(this.textInformacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RealizarConsulta";
            this.ShowIcon = false;
            this.Text = "Realizar Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnNovaReceita;
        private System.Windows.Forms.Button btnNovoAtestado;
        private System.Windows.Forms.TextBox textInformacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
    }
}