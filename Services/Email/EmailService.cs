using HtmlAgilityPack;

using Integrador.Domain.Cliente;
using Integrador.Domain.Email;
using Integrador.Domain.EmailConfigure;
using Integrador.Repository.Email;
using Integrador.Repository.EmailConfigure;
using Integrador.Services.EmailConfigure;

using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Integrador.Services.Email
{
    class Indice
    {
        public int inicio;
        public int fim;
    }
    public class EmailService
    {

        public AppDbContext context = new AppDbContext();
        private ImapClient _imapClient = new ImapClient();
        private readonly EmailConfigureModel _emailConfigureModel;
        private readonly IEmailRepository _emailRepository;
        private EmailConfigureRepository _emailConfigureRepository = new EmailConfigureRepository();
        //public ClienteModel Cliente = new ClienteModel();
        public List<ClienteModel> ClienteModelList = new List<ClienteModel>();
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

        public List<EmailModel> LerEmailsDoBancoDeDados()
        {
            List<EmailModel> emailModelList = new List<EmailModel>();
            emailModelList = context.Email.ToList();
            return emailModelList;
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
                //else
                //{
                //    item.Id = context.Email.Where(id => id.Id == item.Id).Select(idDb => idDb.Id).FirstOrDefault();
                //    context.Email.Attach((EmailModel)item);
                //    context.Entry(item).State = EntityState.Modified;
                //    context.SaveChanges();
                //}
            }



        }

        public void SalvarClienteNoBanco()
        {
            EmailModel emailModel = new EmailModel();
            List<EmailModel> emailModelList = new List<EmailModel>();
            emailModelList = context.Email.ToList();
            string[] valuesExtract = new string[10];
            try
            {
                foreach (var mail in emailModelList)
                {
                    var lines = RetornaLinhas(mail);
                    Indice indice = GetIndice(lines);
                    for (int indiceLines = indice.inicio; indiceLines < indice.fim; indiceLines++)
                    {
                        var htmlNodes = ExtractNodes(lines[indiceLines]);
                        int indextExtrat = 0;
                        foreach (var node in htmlNodes)
                        {
                            valuesExtract[indextExtrat] = node.InnerText;
                            indextExtrat++;
                        }
                        ClienteModel cli = AddCliente(valuesExtract, mail);
                        if (cli.nome != null)
                        {
                            context.Cliente.Add(cli);
                            context.SaveChanges(true);
                        }

                    }

                }



                //SaveClienteChange(ClienteModelList);
                MarcarComoIntegrado(emailModelList);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MarcarComoIntegrado(List<EmailModel> emailModelList)
        {
            foreach (var mail in emailModelList)
            {

                mail.Integrado = true;
                context.Email.Attach(mail);
                context.Entry(mail).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        private void SaveClienteChange(List<ClienteModel> listaClientes)
        {
            foreach (var cliente in listaClientes)
            {
                try
                {

                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                }
                catch (Exception e)
                {

                    throw new Exception($"Erro ao salvar o cliente no banco de dados: {e.Message} ", e.InnerException);
                }

            }
        }

        private ClienteModel AddCliente(string[] valuesExtract, EmailModel mail)
        {
            ClienteModel cliente = new ClienteModel();
            //EmailModel emailModel = new EmailModel();
            //emailModel = mail;
            if (!mail.Integrado)
            {

                cliente.nome = valuesExtract[1];
                cliente.codigo = valuesExtract[2];
                cliente.tpDoc = valuesExtract[3].ToString().Length == 23 ? "CPF" : "CNPJ";
                cliente.cgc = cliente.tpDoc.ToString() == "CPF" ? valuesExtract[3].ToString().Substring(3, 11) : valuesExtract[3].ToString().Substring(3, 14);
                cliente.fantasia = valuesExtract[4];
                cliente.fone = valuesExtract[5];
                cliente.cep = valuesExtract[6];
                string[] endreco = valuesExtract[7].Split(',');
                cliente.logradouro = endreco[0];
                string[] numero = endreco[1].Split('-');
                cliente.numero = numero[0];
                cliente.bairro = endreco[2];
                cliente.cidade = valuesExtract[8];
                cliente.uf = valuesExtract[9];

            }
            return cliente;

        }

        private static HtmlNodeCollection ExtractNodes(string line)
        {
            var htmlExtract = new HtmlAgilityPack.HtmlDocument();
            htmlExtract.LoadHtml(line);
            var htmlNodes = htmlExtract.DocumentNode.SelectNodes("//tr//td");
            return htmlNodes;
        }


        //ENCONTRA O INICIO E FINAL DO TXT SALVO
        private static Indice GetIndice(string[] lines)
        {
            EmailConfigureRepository repositoryMail = new EmailConfigureRepository();
            var indices = new Indice();
            indices.inicio = 0;
            indices.fim = 0;
            int linha = 0;

            while (indices.fim == 0 || indices.inicio == 0)
            {

                if (lines[linha].Contains("Totais gerais"))
                {
                    indices.fim = linha;
                }

                if (lines[linha].Contains("<!-- Start report output -->"))
                {
                    indices.inicio = linha + 2;
                }
                linha++;
            }

            return indices;
        }

        private static String[] RetornaLinhas(EmailModel mail)
        {
            //CRIA ARQUIVO PARA RECEBER O CORPO DO E-MAIL
            StreamWriter sw = new StreamWriter("\\INTEGRADOR\\Temp.txt");

            //SALVA O CORPO DO E-MAIL NO ARQUIVO CRIADO
            sw.WriteLine(mail.ConteudoHtml);

            //FECHA ARQUIVO
            sw.Close();

            //SALVA DADOS DO ARQUIVO EM UM ARRAY
            var lines = File.ReadAllLines("\\INTEGRADOR\\Temp.txt");

            //APAGA ARQUIVO TEMPORARIO
            //File.Delete("\\INTEGRADOR\\Temp.txt");

            //RETORNA O ARRAY COM O CORPO DO E-MAIL.
            return lines;
        }
    }
}
