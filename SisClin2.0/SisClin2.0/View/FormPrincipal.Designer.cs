namespace SisClin2._0.View
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnSecretaria = new System.Windows.Forms.ToolStripMenuItem();
            this.smnMarcarConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.smnListaConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.smnCadPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.smnPesquisaPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.smnVerConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.smnRealizaConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.smnPesquisaPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.smnCadFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.smnListaFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtBemVindo = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNomeUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSecretaria,
            this.mnMedico,
            this.mnAdministrador,
            this.usuárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnSecretaria
            // 
            this.mnSecretaria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnMarcarConsulta,
            this.smnListaConsulta,
            this.smnCadPaciente,
            this.smnPesquisaPacientes});
            this.mnSecretaria.Name = "mnSecretaria";
            this.mnSecretaria.Size = new System.Drawing.Size(87, 24);
            this.mnSecretaria.Text = "Secretária";
            // 
            // smnMarcarConsulta
            // 
            this.smnMarcarConsulta.Name = "smnMarcarConsulta";
            this.smnMarcarConsulta.Size = new System.Drawing.Size(207, 24);
            this.smnMarcarConsulta.Text = "Marcar Consulta";
            this.smnMarcarConsulta.Click += new System.EventHandler(this.smnMarcarConsulta_Click);
            // 
            // smnListaConsulta
            // 
            this.smnListaConsulta.Name = "smnListaConsulta";
            this.smnListaConsulta.Size = new System.Drawing.Size(207, 24);
            this.smnListaConsulta.Text = "Listar Consultas";
            this.smnListaConsulta.Click += new System.EventHandler(this.smnListaConsulta_Click);
            // 
            // smnCadPaciente
            // 
            this.smnCadPaciente.Name = "smnCadPaciente";
            this.smnCadPaciente.Size = new System.Drawing.Size(207, 24);
            this.smnCadPaciente.Text = "Cadastrar Pacientes";
            this.smnCadPaciente.Click += new System.EventHandler(this.smnCadPaciente_Click);
            // 
            // smnPesquisaPacientes
            // 
            this.smnPesquisaPacientes.Name = "smnPesquisaPacientes";
            this.smnPesquisaPacientes.Size = new System.Drawing.Size(207, 24);
            this.smnPesquisaPacientes.Text = "Pesquisar Pacientes";
            this.smnPesquisaPacientes.Click += new System.EventHandler(this.smnPesquisaPacientes_Click);
            // 
            // mnMedico
            // 
            this.mnMedico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnVerConsultas,
            this.smnRealizaConsultas,
            this.smnPesquisaPaciente});
            this.mnMedico.Name = "mnMedico";
            this.mnMedico.Size = new System.Drawing.Size(71, 24);
            this.mnMedico.Text = "Médico";
            // 
            // smnVerConsultas
            // 
            this.smnVerConsultas.Name = "smnVerConsultas";
            this.smnVerConsultas.Size = new System.Drawing.Size(206, 24);
            this.smnVerConsultas.Text = "Ver Agenda";
            this.smnVerConsultas.Click += new System.EventHandler(this.smnVerConsultas_Click);
            // 
            // smnRealizaConsultas
            // 
            this.smnRealizaConsultas.Name = "smnRealizaConsultas";
            this.smnRealizaConsultas.Size = new System.Drawing.Size(206, 24);
            this.smnRealizaConsultas.Text = "Realizar Consulta";
            this.smnRealizaConsultas.Click += new System.EventHandler(this.smnRealizaConsultas_Click);
            // 
            // smnPesquisaPaciente
            // 
            this.smnPesquisaPaciente.Name = "smnPesquisaPaciente";
            this.smnPesquisaPaciente.Size = new System.Drawing.Size(206, 24);
            this.smnPesquisaPaciente.Text = "Pesquisar Pacientes";
            this.smnPesquisaPaciente.Click += new System.EventHandler(this.smnPesquisaPaciente_Click);
            // 
            // mnAdministrador
            // 
            this.mnAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnCadFuncionario,
            this.smnListaFuncionarios});
            this.mnAdministrador.Name = "mnAdministrador";
            this.mnAdministrador.Size = new System.Drawing.Size(116, 24);
            this.mnAdministrador.Text = "Administrador";
            // 
            // smnCadFuncionario
            // 
            this.smnCadFuncionario.Name = "smnCadFuncionario";
            this.smnCadFuncionario.Size = new System.Drawing.Size(222, 24);
            this.smnCadFuncionario.Text = "Cadastrar Funcionário";
            // 
            // smnListaFuncionarios
            // 
            this.smnListaFuncionarios.Name = "smnListaFuncionarios";
            this.smnListaFuncionarios.Size = new System.Drawing.Size(222, 24);
            this.smnListaFuncionarios.Text = "Lista de Funcionários";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusDadosToolStripMenuItem,
            this.smnSair});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // meusDadosToolStripMenuItem
            // 
            this.meusDadosToolStripMenuItem.Name = "meusDadosToolStripMenuItem";
            this.meusDadosToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.meusDadosToolStripMenuItem.Text = "Meus Dados";
            // 
            // smnSair
            // 
            this.smnSair.Name = "smnSair";
            this.smnSair.Size = new System.Drawing.Size(160, 24);
            this.smnSair.Text = "Sair";
            this.smnSair.Click += new System.EventHandler(this.smnSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBemVindo,
            this.txtNomeUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(916, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtBemVindo
            // 
            this.txtBemVindo.Name = "txtBemVindo";
            this.txtBemVindo.Size = new System.Drawing.Size(96, 20);
            this.txtBemVindo.Text = "Bem Vindo - ";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(0, 20);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 405);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "SisClin - Gerenciamento de Consultórios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnSecretaria;
        private System.Windows.Forms.ToolStripMenuItem smnMarcarConsulta;
        private System.Windows.Forms.ToolStripMenuItem smnListaConsulta;
        private System.Windows.Forms.ToolStripMenuItem mnMedico;
        private System.Windows.Forms.ToolStripMenuItem mnAdministrador;
        private System.Windows.Forms.ToolStripMenuItem smnCadPaciente;
        private System.Windows.Forms.ToolStripMenuItem smnPesquisaPacientes;
        private System.Windows.Forms.ToolStripMenuItem smnVerConsultas;
        private System.Windows.Forms.ToolStripMenuItem smnRealizaConsultas;
        private System.Windows.Forms.ToolStripMenuItem smnPesquisaPaciente;
        private System.Windows.Forms.ToolStripMenuItem smnCadFuncionario;
        private System.Windows.Forms.ToolStripMenuItem smnListaFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smnSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtBemVindo;
        private System.Windows.Forms.ToolStripStatusLabel txtNomeUser;
    }
}