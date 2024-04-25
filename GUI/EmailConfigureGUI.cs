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
        private EmailConfigureModel model = new EmailConfigureModel();


        public EmailConfigureGUI(IEmailConfigureRepository emailConfigureRepository)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            model.Email = emailTextBox.Text;
            model.Senha = senhaTextBox.Text;
            model.SmtpServer = smtpServerTextBox.Text;
            model.SmtpPorta = int.Parse(smtpPortaTextBox.Text);
            model.SslSaidaHabilitado = sslEntradaCheckBox.Checked;
            model.EntradaServer = entradaServerTextBox.Text;
            model.EntradaPorta = int.Parse(entradaPortaTextBox.Text);
            model.SslEntradaHabilitado = sslEntradaCheckBox.Checked;

            if (model.Id != 0)
            {
                context.Entry(model).State = EntityState.Modified;
                context.SaveChanges();
            }
            else
            {
                context.EmailConfigure.Add(model);
                context.SaveChanges();
            }
        }

        private async void EmailConfigureGUI_Load(object sender, EventArgs e)
        {
            try
            {
                if (context.EmailConfigure.Any())
                {
                    model = await context.EmailConfigure.FirstOrDefaultAsync();
                }

                if (model.Id != 0)
                {
                    emailTextBox.Text = model.Email;
                    senhaTextBox.Text = model.Senha;
                    smtpServerTextBox.Text = model.SmtpServer;
                    smtpPortaTextBox.Text = model.SmtpPorta.ToString();
                    sslSaidaCheckBox.Checked = model.SslSaidaHabilitado;
                    entradaServerTextBox.Text = model.EntradaServer;
                    entradaPortaTextBox.Text = model.EntradaPorta.ToString();
                    sslEntradaCheckBox.Checked = model.SslEntradaHabilitado;
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
    }
}
