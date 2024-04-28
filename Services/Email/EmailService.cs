using Integrador.Domain.Email;
using Integrador.Domain.EmailConfigure;
using Integrador.Repository.Email;

using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;


namespace Integrador.Services.Email
{
    public class EmailService
    {

        private ImapClient _imapClient = new ImapClient();
        private readonly EmailConfigureModel _emailConfigureModel;
        private readonly IEmailRepository _emailRepository;
        private AppDbContext context = new AppDbContext();
        public EmailService(IEmailRepository emailReponsitory, EmailConfigureModel emailConfigureModel)
        {
            _emailRepository = emailReponsitory;
            _emailConfigureModel = emailConfigureModel;

        }


        public void ConnectHost(bool connect)
        {
            if (connect)
            {

                if (_imapClient.IsConnected)
                {
                    _imapClient.Disconnect(true);
                }
                SecureSocketOptions secureSocketOptions = _emailConfigureModel.SslEntradaHabilitado ?
                    SecureSocketOptions.SslOnConnect :
                    SecureSocketOptions.None;
                _imapClient.Connect(_emailConfigureModel.EntradaServer, _emailConfigureModel.EntradaPorta, secureSocketOptions);
                _imapClient.Authenticate(_emailConfigureModel.Email, _emailConfigureModel.Senha);
            }
            else
            {
                if (!_imapClient.IsConnected)
                {
                    _imapClient.Disconnect(true);
                }
            }
        }

        private string IPAdressSet(string hostName)
        {
            string hostIp = null;
            try
            {
                ASCIIEncoding aSCII = new ASCIIEncoding();
                IPHostEntry iPHost = Dns.GetHostEntry(hostName);
                foreach (IPAddress item in iPHost.AddressList)
                {
                    hostIp = item.ToString();
                }
            }
            catch (Exception e)
            {

                throw;
            }
            return hostIp;
        }


        public async Task<List<EmailModel>> ReceberMensagensAsync(string caixaDeMensagem, string assunto)
        {
            List<EmailModel> emailModelList = new List<EmailModel>();

            using (ImapClient imapClient = new ImapClient())
            {
                await imapClient.ConnectAsync(_emailConfigureModel.EntradaServer,
                    _emailConfigureModel.EntradaPorta, _emailConfigureModel.SslEntradaHabilitado);


                await imapClient.AuthenticateAsync(_emailConfigureModel.Email,
                    _emailConfigureModel.Senha);

                IMailFolder folder = await imapClient.GetFolderAsync(_emailConfigureModel.CaixaDeEmail);
                await folder.OpenAsync(FolderAccess.ReadOnly);

                var items = await folder.FetchAsync(0, -1, MessageSummaryItems.UniqueId |
                    MessageSummaryItems.Envelope | MessageSummaryItems.Body);
                
                foreach (var item in items)
                {
                    emailModelList.Add(
                        new EmailModel()
                        {
                            IdEmailBox = item.UniqueId.Id.ToString(),
                            Remetente = item.Envelope.From.ToString(),
                            Assunto = item.Envelope.Subject,
                            DataDeRecebimento = (DateTimeOffset)item.Envelope.Date,
                            ConteudoHtml = item.HtmlBody.ToString()
                        });
                }
                //emailModelList = emailModelList.Where(sub => sub.Assunto.Contains(assunto)).ToList();
                return emailModelList;
            }



        }

        public List<EmailModel> ReceberMensagens(string caixaDeMensagem, string assunto)
        {
            List<EmailModel> emailModelList = new List<EmailModel>();

            IMailFolder folder = _imapClient.GetFolder(caixaDeMensagem);
            folder.Open(FolderAccess.ReadOnly);

            foreach (var item in folder)
            {
                emailModelList.Add(
                    new EmailModel()
                    {
                        IdEmailBox = item.MessageId,
                        Remetente = item.From.ToString(),
                        Assunto = item.Subject,
                        DataDeRecebimento = item.Date,
                        ConteudoHtml = item.HtmlBody
                    });
            }
            emailModelList = emailModelList.Where(sub => sub.Assunto.Contains(assunto)).ToList();
            return emailModelList;
        }

        public void SalvarEmailsNoBancoDeDados(List<EmailModel> lista)
        {

            foreach (var item in lista)
            {
                if (!context.Email.Any(idEmail => idEmail.IdEmailBox == item.IdEmailBox))
                {
                    context.Add(item);
                    context.SaveChanges();
                }
                else
                {
                    item.Id = context.Email.Where(id => id.Id == item.Id).Select(idDb => idDb.Id).FirstOrDefault();
                    context.Email.Attach((EmailModel)item);
                    context.Entry(item).State = EntityState.Modified;
                    context.SaveChanges();
                }       
            }



        }


    }
}
