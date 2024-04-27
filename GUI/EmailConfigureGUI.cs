using Integrador.Domain.EmailConfigure;
using Integrador.Repository.EmailConfigure;
using Integrador.Services;

using Microsoft.EntityFrameworkCore;

using System;
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
        private readonly AppDbContext context = new AppDbContext();
        private EmailConfigureModel emailConfigureModel = new EmailConfigureModel();
        private EmailConfigureRepository _emailConfigureRepository;


        public EmailConfigureGUI(IEmailConfigureRepository emailConfigureRepository)
        {
            _emailConfigureRepository = (EmailConfigureRepository)emailConfigureRepository;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            emailConfigureModel.CaixaDeEmail = caixaDeEmailTextBox.Text;
            emailConfigureModel.Email = emailTextBox.Text;
            emailConfigureModel.Senha = senhaTextBox.Text;
            emailConfigureModel.SmtpServer = smtpServerTextBox.Text;
            emailConfigureModel.SmtpPorta = int.Parse(smtpPortaTextBox.Text);
            emailConfigureModel.SslSaidaHabilitado = sslEntradaCheckBox.Checked;
            emailConfigureModel.EntradaServer = entradaServerTextBox.Text;
            emailConfigureModel.EntradaPorta = int.Parse(entradaPortaTextBox.Text);
            emailConfigureModel.SslEntradaHabilitado = sslEntradaCheckBox.Checked;

            if (emailConfigureModel.Id != 0)
            {
                context.Entry(emailConfigureModel).State = EntityState.Modified;
                context.SaveChanges();
            }
            else
            {
                context.EmailConfigure.Add(emailConfigureModel);
                context.SaveChanges();
            }
        }

        private async void EmailConfigureGUI_Load(object sender, EventArgs e)
        {
            try
            {
                if (context.EmailConfigure.Any())
                {
                    emailConfigureModel = await context.EmailConfigure.FirstOrDefaultAsync();
                }

                if (emailConfigureModel.Id != 0)
                {
                    caixaDeEmailTextBox.Text = emailConfigureModel.CaixaDeEmail;
                    emailTextBox.Text = emailConfigureModel.Email;
                    senhaTextBox.Text = emailConfigureModel.Senha;
                    smtpServerTextBox.Text = emailConfigureModel.SmtpServer;
                    smtpPortaTextBox.Text = emailConfigureModel.SmtpPorta.ToString();
                    sslSaidaCheckBox.Checked = emailConfigureModel.SslSaidaHabilitado;
                    entradaServerTextBox.Text = emailConfigureModel.EntradaServer;
                    entradaPortaTextBox.Text = emailConfigureModel.EntradaPorta.ToString();
                    sslEntradaCheckBox.Checked = emailConfigureModel.SslEntradaHabilitado;
                }
                else
                {
                    MessageBox.Show("Nenhuma configuração de e-mail.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a configuração de e-mail: " + ex.Message);
            }
        }

        private void verEmailButton_Click(object sender, EventArgs e)
        {
            MailViewGUI mailViewGUI = new MailViewGUI();
            mailViewGUI.ShowDialog();
        }
    }
}
