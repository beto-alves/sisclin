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
            this.label6 = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.textInformacoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtAtestado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReceita = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgProcedimentosConsulta = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbProcedimentos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.btnConsultaAnterior = new System.Windows.Forms.Button();
            this.lblDt = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedimentosConsulta)).BeginInit();
            this.SuspendLayout();
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
            this.lblMedico.Size = new System.Drawing.Size(79, 24);
            this.lblMedico.TabIndex = 1013;
            this.lblMedico.Text = "medico";
            // 
            // textInformacoes
            // 
            this.textInformacoes.Location = new System.Drawing.Point(177, 108);
            this.textInformacoes.Margin = new System.Windows.Forms.Padding(4);
            this.textInformacoes.Multiline = true;
            this.textInformacoes.Name = "textInformacoes";
            this.textInformacoes.Size = new System.Drawing.Size(500, 200);
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
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(30, 752);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInserir.Size = new System.Drawing.Size(257, 40);
            this.btnInserir.TabIndex = 1017;
            this.btnInserir.Text = "Finalizar Consulta";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(173, 39);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(76, 24);
            this.lblHorario.TabIndex = 1018;
            this.lblHorario.Text = "horario";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(173, 72);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(76, 24);
            this.lblPaciente.TabIndex = 1019;
            this.lblPaciente.Text = "horario";
            // 
            // txtAtestado
            // 
            this.txtAtestado.Location = new System.Drawing.Point(177, 316);
            this.txtAtestado.Margin = new System.Windows.Forms.Padding(4);
            this.txtAtestado.Multiline = true;
            this.txtAtestado.Name = "txtAtestado";
            this.txtAtestado.Size = new System.Drawing.Size(500, 200);
            this.txtAtestado.TabIndex = 1021;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 1020;
            this.label4.Text = "Atestado:";
            // 
            // txtReceita
            // 
            this.txtReceita.Location = new System.Drawing.Point(177, 524);
            this.txtReceita.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceita.Multiline = true;
            this.txtReceita.Name = "txtReceita";
            this.txtReceita.Size = new System.Drawing.Size(500, 200);
            this.txtReceita.TabIndex = 1023;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 523);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 1022;
            this.label5.Text = "Receita:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgProcedimentosConsulta);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.cbProcedimentos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(711, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 617);
            this.groupBox1.TabIndex = 1024;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procedimentos Solicitados";
            // 
            // dgProcedimentosConsulta
            // 
            this.dgProcedimentosConsulta.AllowUserToAddRows = false;
            this.dgProcedimentosConsulta.AllowUserToDeleteRows = false;
            this.dgProcedimentosConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProcedimentosConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcedimentosConsulta.Location = new System.Drawing.Point(11, 77);
            this.dgProcedimentosConsulta.Name = "dgProcedimentosConsulta";
            this.dgProcedimentosConsulta.ReadOnly = true;
            this.dgProcedimentosConsulta.RowTemplate.Height = 24;
            this.dgProcedimentosConsulta.Size = new System.Drawing.Size(616, 521);
            this.dgProcedimentosConsulta.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(442, 33);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(185, 25);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar Procedimento";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbProcedimentos
            // 
            this.cbProcedimentos.FormattingEnabled = true;
            this.cbProcedimentos.Location = new System.Drawing.Point(116, 33);
            this.cbProcedimentos.Name = "cbProcedimentos";
            this.cbProcedimentos.Size = new System.Drawing.Size(320, 24);
            this.cbProcedimentos.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Procedimentos";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetorno.Location = new System.Drawing.Point(707, 18);
            this.lblRetorno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(277, 24);
            this.lblRetorno.TabIndex = 1028;
            this.lblRetorno.Text = "Essa consulta é um retorno. ";
            this.lblRetorno.Visible = false;
            // 
            // btnConsultaAnterior
            // 
            this.btnConsultaAnterior.Enabled = false;
            this.btnConsultaAnterior.Location = new System.Drawing.Point(982, 17);
            this.btnConsultaAnterior.Name = "btnConsultaAnterior";
            this.btnConsultaAnterior.Size = new System.Drawing.Size(165, 31);
            this.btnConsultaAnterior.TabIndex = 1029;
            this.btnConsultaAnterior.Text = "Ver Consulta Anterior";
            this.btnConsultaAnterior.UseVisualStyleBackColor = true;
            this.btnConsultaAnterior.Visible = false;
            this.btnConsultaAnterior.Click += new System.EventHandler(this.btnConsultaAnterior_Click);
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt.Location = new System.Drawing.Point(295, 39);
            this.lblDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(63, 24);
            this.lblDt.TabIndex = 1030;
            this.lblDt.Text = "Data: ";
            this.lblDt.Visible = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(366, 39);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 24);
            this.lblData.TabIndex = 1031;
            this.lblData.Text = "Data: ";
            this.lblData.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(1098, 752);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFechar.Size = new System.Drawing.Size(257, 40);
            this.btnFechar.TabIndex = 1032;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // RealizarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 805);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDt);
            this.Controls.Add(this.btnConsultaAnterior);
            this.Controls.Add(this.lblRetorno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtReceita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAtestado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.textInformacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RealizarConsulta";
            this.ShowIcon = false;
            this.Text = "Realizar Consulta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedimentosConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox textInformacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtAtestado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReceita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgProcedimentosConsulta;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cbProcedimentos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.Button btnConsultaAnterior;
        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnFechar;
    }
}