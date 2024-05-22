using Integrador.Domain.Email;
using Integrador.Domain.EmailConfigure;
using Integrador.Repository.Email;
using Integrador.Services.Email;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Integrador.GUI
{
    public partial class MailViewGUI : Form
    {
        private EmailConfigureModel _emailConfigureModel;
        private List<EmailModel> EmailListData;
        private IEnumerable<EmailModel> EmailListEnum = null;
        private readonly IEmailRepository _emailReponsitory;
        private EmailService emailService;

        public MailViewGUI(EmailConfigureModel emailConfigureModel)
        {
            _emailConfigureModel = emailConfigureModel;
            _emailReponsitory = new EmailRepository(new EmailModel());
            EmailListData = new List<EmailModel>();
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
            PopulaDataGridView();
            PreencheDataGridView();
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

        private void PopulaDataGridView()
        {
            List<EmailModel> emailModelList = new List<EmailModel>();
            emailService = new EmailService(_emailReponsitory, _emailConfigureModel);
            emailModelList = emailService.LerEmailsDoBancoDeDados();
            EmailListData = emailModelList;

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
            listaEmailDataGridView.Columns[4].Width = 70;
      
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
                    row["Integrado"] = model.Integrado ? 1 : 0;

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
            table.Columns.Add("Integrado", typeof(bool));

            return table;
        }

        private void salvarClienteButton_Click(object sender, EventArgs e)
        {
            emailService.SalvarClienteNoBanco();
        }

        private void testIntegracaoButton_Click(object sender, EventArgs e)
        {
            ClientesListGUI clienteForm = new ClientesListGUI();
            clienteForm.ShowDialog();
        }
    }
}
