using Integrador.Domain.EmailConfigure;
using Integrador.Repository.EmailConfigure;
using Integrador.Services;
using Integrador.Services.EmailConfigure;

using Microsoft.EntityFrameworkCore;

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador.GUI
{
    public partial class EmailConfigureGUI : Form
    {
        private EmailConfigureModel emailConfigureModel;
        private EmailConfigureService _emailConfigureService;



        //private readonly AppDbContext context = new AppDbContext();
        //private EmailConfigureModel emailConfigureModel = new EmailConfigureModel();
        //private EmailConfigureRepository _emailConfigureRepository;


        public EmailConfigureGUI()
        {
            InitializeComponent();
            _emailConfigureService = new EmailConfigureService(new EmailConfigureRepository(new AppDbContext()));
        }
        private void EmailConfigureGUI_Load(object sender, EventArgs e)
        {
            CarregarCamposEmailConfigure();

        }


        private void salvarButton_Click(object sender, EventArgs e)
        {
            SalvarDadosEmailConfigure();

        }

        private void SalvarDadosEmailConfigure()
        {
            
            emailConfigureModel.Email = emailTextBox.Text;
            emailConfigureModel.Senha = senhaTextBox.Text;
            emailConfigureModel.SmtpServer = smtpServerTextBox.Text;
            emailConfigureModel.SmtpPorta = int.Parse(smtpPortaTextBox.Text);
            emailConfigureModel.SslSaidaHabilitado = sslEntradaCheckBox.Checked;
            emailConfigureModel.EntradaServer = entradaServerTextBox.Text;
            emailConfigureModel.EntradaPorta = int.Parse(entradaPortaTextBox.Text);
            emailConfigureModel.SslEntradaHabilitado = sslEntradaCheckBox.Checked;
            emailConfigureModel.CaixaDeEmail = caixaDeEmailTextBox.Text;
            emailConfigureModel.AssuntoEmail = emailAssuntoTextBox.Text;
            emailConfigureModel.InicioRelatorio = inicioRelatoiroTextBox.Text;
            emailConfigureModel.FinalRelatorio = finalRelatorioTextBox.Text;
            emailConfigureModel.TagExtracao = tagsExtracaoTextBox.Text;
            emailConfigureModel.PastaTemporaria = pastaTemporairaTextBox.Text;



            if (emailConfigureModel.Id != 0)
            {
                _emailConfigureService.Update(emailConfigureModel);
                MessageBox.Show("Configuração de E-Mail salva com sucesso!");

            }
            else
            {
                _emailConfigureService.Add(emailConfigureModel);
                MessageBox.Show("Configuração de E-mail adicionada com sucesso!");

            }
        }



        private void verEmailButton_Click(object sender, EventArgs e)
        {
            MailViewGUI mailViewGUI = new MailViewGUI(emailConfigureModel);
            mailViewGUI.ShowDialog();
        }

        private void pastaTemporariaButton_Click(object sender, EventArgs e)
        {

            SelecionarPastaTemporaria();

        }
        private void CarregarCamposEmailConfigure()
        {
            emailConfigureModel = _emailConfigureService.GetEmailConfigure();

            emailTextBox.Text = emailConfigureModel.Email;
            senhaTextBox.Text = emailConfigureModel.Senha;
            smtpServerTextBox.Text = emailConfigureModel.SmtpServer;
            smtpPortaTextBox.Text = emailConfigureModel.SmtpPorta.ToString();
            sslSaidaCheckBox.Checked = emailConfigureModel.SslSaidaHabilitado;
            entradaServerTextBox.Text = emailConfigureModel.EntradaServer;
            entradaPortaTextBox.Text = emailConfigureModel.EntradaPorta.ToString();
            sslEntradaCheckBox.Checked = emailConfigureModel.SslEntradaHabilitado;
            caixaDeEmailTextBox.Text = emailConfigureModel.CaixaDeEmail; //"INBOX"
            emailAssuntoTextBox.Text = emailConfigureModel.AssuntoEmail; //Relatório: [TI] Clientes Faturamento executar em XX/XX/XXXX
            inicioRelatoiroTextBox.Text = emailConfigureModel.InicioRelatorio; //"<!-- Start report output -->"
            finalRelatorioTextBox.Text = emailConfigureModel.FinalRelatorio;  //"Totais gerais"
            tagsExtracaoTextBox.Text = emailConfigureModel.TagExtracao; // "//tr//td"
            pastaTemporairaTextBox.Text = emailConfigureModel.PastaTemporaria;

        }

        private void SelecionarPastaTemporaria()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Selecione a pasta de arquivos temporários";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    pastaTemporairaTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
