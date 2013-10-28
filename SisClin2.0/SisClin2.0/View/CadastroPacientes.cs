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

namespace SisClin2._0.View
{
    public partial class CadastroPacientes : Form
    {
        private bool existeDispositivo = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fonteDeVideo;

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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
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
        
    }
}
