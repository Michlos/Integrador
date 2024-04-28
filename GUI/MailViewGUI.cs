using Integrador.Domain.Email;
using Integrador.Domain.EmailConfigure;
using Integrador.Repository.Email;
using Integrador.Services;
using Integrador.Services.Email;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador.GUI
{
    public partial class MailViewGUI : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private EmailConfigureModel _emailConfigureModel;
        private readonly EmailService emailService;
        private EmailModel emailModel = new EmailModel();
        private List<EmailModel> EmailListData = new List<EmailModel>();
        private IEnumerable<EmailModel> EmailListEnum = null;
        private readonly IEmailRepository _emailReponsitory;

        public MailViewGUI(EmailConfigureModel emailConfigureModel)
        {
            _emailConfigureModel = emailConfigureModel;
            InitializeComponent();

        }
        private EmailService GetEmailService()
        {
            return emailService;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MailViewGUI_Load(object sender, EventArgs e)
        {

        }
        private void ReceberEmail(EmailService emailService)
        {
            //LISTA DE EMAILMODEL PARA RECEBER TODAS AS MENSAGENS DO SERVIDOR
            List<EmailModel> emailModelList = new List<EmailModel>();
            emailService = new EmailService(_emailReponsitory, _emailConfigureModel);
            emailService.ConnectHost(true);

            //SOLICITA O RECEBIMENTO DE MENSAGENS AO EMAILSERVICE
            emailModelList = emailService.ReceberMensagens(_emailConfigureModel.CaixaDeEmail, _emailConfigureModel.AssuntoEmail);
            EmailListData = emailModelList;
            emailService.SalvarEmailsNoBancoDeDados(EmailListData);

        }

        private void receberEmailsButton_Click(object sender, EventArgs e)
        {
            ReceberEmail(GetEmailService());
            PreencheDataGridView();
            
        }

        private void PreencheDataGridView()
        {
            EmailListEnum = EmailListData;
            DataTable tableMail = ModelaMailTable();
            ModelaMailRow(tableMail, EmailListEnum);
            listaEmailDataGridView.DataSource = tableMail;
            ConfiguraDataGrid();


        }

        private void ConfiguraDataGrid()
        {
            listaEmailDataGridView.Columns[0].Width = 50;
            listaEmailDataGridView.Columns[1].Width = 200;
            listaEmailDataGridView.Columns[2].Width = 200;
            listaEmailDataGridView.Columns[3].Width = 100;
      
        }

        private void ModelaMailRow(DataTable tableMail, IEnumerable<EmailModel> emailListEnum)
        {
            DataRow row;

            if (this.EmailListEnum.Any())
            {
                foreach (EmailModel model in emailListEnum)
                {
                    row = tableMail.NewRow();
                    row["Id"] = model.IdEmailBox.ToString();
                    row["Remetente"] = model.Remetente.ToString();
                    row["Assunto"] = model.Assunto.ToString();
                    row["Data"] = model.DataDeRecebimento;

                    tableMail.Rows.Add(row);

                }
            }
        }

        private DataTable ModelaMailTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Remetente", typeof(string));
            table.Columns.Add("Assunto", typeof(string));
            table.Columns.Add("Data", typeof(DateTimeOffset));

            return table;
        }
    }
}
