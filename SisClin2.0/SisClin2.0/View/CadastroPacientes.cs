using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using SisClin2._0.Controller;
using SisClin2._0.Vo;

namespace SisClin2._0.View
{
    public partial class CadastroPacientes : Form
    {
        private bool existeDispositivo = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fonteDeVideo;

        private PacienteVO paciente = new PacienteVO();

        public CadastroPacientes()
        {
            InitializeComponent();
        }

        private void CadastroPacientes_Load(object sender, EventArgs e)
        {
            this.buscarDispositivos();
            this.cbDispositivos.SelectedIndex = 1;
        }

        private void CadastroPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnCamera.Text == "Capturar")
            {
                btnCamera_Click(sender, e);
            }
        }

        //Funções da camera

        public void carregaDispositivo(FilterInfoCollection dispositivos)
        {
            for (int i = 0; i < dispositivos.Count; i++)
            {
                cbDispositivos.Items.Add(dispositivos[0].Name.ToString());
            }
            cbDispositivos.Text = cbDispositivos.Items[0].ToString();
        }

        public void buscarDispositivos()
        {
            dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivosDeVideo.Count == 0)
            {
                existeDispositivo = false;
            }
            else
            {
                existeDispositivo = true;
                carregaDispositivo(dispositivosDeVideo);
            }
        }

        public void terminarFonteDeVideo()
        {
            if (!(fonteDeVideo == null))
            {
                if (fonteDeVideo.IsRunning)
                {
                    fonteDeVideo.SignalToStop();
                    fonteDeVideo = null;
                }
            }
        }

        private void videoNovoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagem = (Bitmap)eventArgs.Frame.Clone();
            pbFotoPaciente.Image = imagem;
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            if (btnCamera.Text == "Iniciar")
            {
                if (existeDispositivo)
                {
                    string[] nomeDaImagem = Directory.GetFiles(Application.StartupPath + @"\Fotos");
                    fonteDeVideo = new VideoCaptureDevice(dispositivosDeVideo[cbDispositivos.SelectedIndex].MonikerString);
                    fonteDeVideo.NewFrame += new NewFrameEventHandler(videoNovoFrame);
                    fonteDeVideo.Start();
                    lblStatus.Text = "Executando dispositivo";
                    btnCamera.Text = "Capturar";
                    cbDispositivos.Enabled = false;

                }
                else
                {
                    lblStatus.Text = "Erro: Nenhum dispositivo encontrado";
                }
            }
            else if (fonteDeVideo.IsRunning)
            {
                terminarFonteDeVideo();
                salvarImg();
                lblStatus.Text = "Dispositivo capturado";
                btnCamera.Text = "Iniciar";
                cbDispositivos.Enabled = true;
            }
        }       

        private void salvarImg()
        {
            int numeroDeFotos;
            string nome = txtCpf.Text;
            string[] nomeDaImagem;

            nomeDaImagem = Directory.GetFiles(Application.StartupPath + @"\Fotos");
            numeroDeFotos = nomeDaImagem.Length;

            if (numeroDeFotos > 0)
            {
                for (int i = 0; i < nomeDaImagem.Length; i++)
                {
                    string[] diretorioSeparado = nomeDaImagem[i].Split('\\');
                }
                pbFotoPaciente.Image.Save(Application.StartupPath + @"\Fotos\" + nome + ".jpeg");
                MessageBox.Show("Foto Salva com Sucesso", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pbFotoPaciente.Image.Save(Application.StartupPath + @"\Fotos\" + nome + ".jpeg");
                MessageBox.Show("Foto Salva com Sucesso", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Fim das funções da camera
        private void pacienteExiste(object sender, EventArgs e)
        {
            PacienteController controller = new PacienteController();
            bool retorno = controller.buscaPaciente(txtCpf.Text);

            if (retorno == true)
            {
                MessageBox.Show("O CPF informado já está cadastrado no sistema", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                btnInserir_Click();
            }
        }

        private void btnInserir_Click()
        {
            paciente.nome = txtNome.Text;
            paciente.nascimento = txtNascimento.Text;
            paciente.rg = txtRg.Text;
            paciente.cpf = txtCpf.Text;
            paciente.telefone = txtTelefone.Text;
            paciente.celular = txtCelular.Text;
            paciente.email = txtEmail.Text;
            paciente.rua = txtRua.Text;
            paciente.bairro = txtBairro.Text;
            paciente.cidade = txtCidade.Text;
            paciente.cep = txtCep.Text;
            paciente.estado = cbUf.Text;
            paciente.complemento = txtComplemento.Text;
            paciente.numero = txtNumero.Text;
            paciente.profissao = txtProfissao.Text;

            if (pbFotoPaciente.Image != null)
            {
                paciente.foto =  txtCpf.Text;
            }

            PacienteController controller = new PacienteController();
            bool retorno = controller.cadPaciente(paciente);

            if (retorno)
            {
                MessageBox.Show("Paciente incluído com sucesso", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTela();
            }
            else
            {
                MessageBox.Show("Ocorreu algum erro", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void habilitaControles(object sender, EventArgs e)
        {
            if (!txtNome.Text.Trim().Equals(String.Empty) &&
                txtNascimento.MaskFull && txtTelefone.MaskFull && txtCelular.MaskFull && txtRg.MaskFull && txtCpf.MaskFull &&
                !txtRua.Text.Trim().Equals(String.Empty) && !txtNumero.Text.Trim().Equals(String.Empty) &&
                !txtCidade.Text.Trim().Equals(String.Empty) && txtCep.MaskFull && !txtBairro.Text.Trim().Equals(String.Empty))
            {
                btnInserir.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
            }
            if (txtCpf.MaskFull)
            {
                btnCamera.Enabled = true;
            }
        }

        public void desabilitaControles(bool altera)
        {
            if (altera)
            {
                btnEditar.Enabled = btnExcluir.Enabled = true;
                btnInserir.Enabled = false;
            }
            else
            {
                btnInserir.Enabled = btnEditar.Enabled = btnExcluir.Enabled = false;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaPacientes pesquisaPacientes = new PesquisaPacientes(this);
            pesquisaPacientes.ShowDialog();

            int codigo = Auxiliar.resultadoPesquisa;

            if (codigo != 0)
            {
                PacienteController controller = new PacienteController();
                paciente = controller.buscaPaciente(codigo);

                txtNome.Text = paciente.nome;
                txtNascimento.Text = paciente.nascimento;
                txtRg.Text = paciente.rg;
                txtCpf.Text = paciente.cpf;
                txtTelefone.Text = paciente.telefone;
                txtCelular.Text = paciente.celular;
                txtEmail.Text = paciente.email;
                txtRua.Text = paciente.rua;
                txtBairro.Text = paciente.bairro;
                txtCidade.Text = paciente.cidade;
                txtCep.Text = paciente.cep;
                cbUf.SelectedItem = paciente.estado;
                txtComplemento.Text = paciente.complemento;
                txtNumero.Text = paciente.numero;
                txtProfissao.Text = paciente.profissao;
                pbFotoPaciente.ImageLocation = Application.StartupPath + @"\Fotos\" + paciente.foto + ".jpeg";
                desabilitaControles(true);
 
            }

        }

        private void limpaTela()
        {
            txtNome.Text = txtEmail.Text = txtNascimento.Text = txtRg.Text = txtCpf.Text = txtTelefone.Text
            = txtCelular.Text = txtRua.Text = txtNumero.Text = txtComplemento.Text = txtCidade.Text = txtCep.Text = cbUf.Text = txtBairro.Text =  String.Empty;
            pbFotoPaciente.Image = null;
            desabilitaControles(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            PacienteController controller = new PacienteController();

            if (controller.deletaPaciente(paciente))
            {
                MessageBox.Show("Paciente excluído com sucesso", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTela();
            }
            else
            {
                MessageBox.Show("Ocorreu algum erro", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PacienteController controller = new PacienteController();

            paciente.nome = txtNome.Text;
            paciente.nascimento = txtNascimento.Text;
            paciente.rg = txtRg.Text;
            paciente.cpf = txtCpf.Text;
            paciente.telefone = txtTelefone.Text;
            paciente.celular = txtCelular.Text;
            paciente.email = txtEmail.Text;
            paciente.rua = txtRua.Text;
            paciente.bairro = txtBairro.Text;
            paciente.cidade = txtCidade.Text;
            paciente.cep = txtCep.Text;
            paciente.estado = cbUf.Text;
            paciente.complemento = txtComplemento.Text;
            paciente.numero = txtNumero.Text;
            paciente.profissao = txtProfissao.Text;

            if (!pbFotoPaciente.Image.ToString().Trim().Equals(String.Empty))
            {
                paciente.foto = txtCpf.Text;
            }

            if (controller.atualizaPaciente(paciente))
            {
                MessageBox.Show("Paciente atualizado com sucesso", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTela();
            }
            else
            {
                MessageBox.Show("Ocorreu algum erro", "Cadastro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
