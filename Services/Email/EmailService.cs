using HtmlAgilityPack;

using Integrador.Domain.Cliente;
using Integrador.Domain.Email;
using Integrador.Domain.EmailConfigure;
using Integrador.Repository.Cliente;
using Integrador.Repository.Email;
using Integrador.Repository.EmailConfigure;
using Integrador.Services.ArquivoTemporario;
using Integrador.Services.Cliente;

using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Integrador.Services.Email
{
    //class Indice
    //{
    //    public int inicio;
    //    public int fim;
    //}
    public class EmailService
    {

        //public AppDbContext context = new AppDbContext();
        private ImapClient _imapClient = new ImapClient();
        private readonly EmailConfigureModel _emailConfigureModel;
        private readonly IEmailRepository _emailRepository;
        private EmailConfigureRepository _emailConfigureRepository = new EmailConfigureRepository(new AppDbContext());
        //private readonly IClienteRepository _clienteRepository;
        private readonly ClienteService _clienteService;

        public List<EmailModel> EmailModelList;
        public EmailService(IEmailRepository emailReponsitory, EmailConfigureModel emailConfigureModel)
        {
            _emailRepository = emailReponsitory;
            _emailConfigureModel = emailConfigureModel;
            //_clienteRepository = new ClienteRepository();
            _clienteService = new ClienteService(new ClienteRepository(new AppDbContext()));
            

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
                return emailModelList;
            }



        }

        public List<EmailModel> LerEmailsDoBancoDeDados()
        {
            return _emailRepository.GetAll();
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
            EmailModelList = _emailRepository.GetAll();
            foreach (var item in lista)
            {
                if (EmailModelList.Any(idMail => idMail.IdEmailBox == item.IdEmailBox))
                {
                    _emailRepository.Add(item);
                }
            }
        }

        public void SalvarClienteNoBanco()
        {
            List<EmailModel> emailModelList;

            emailModelList = _emailRepository.GetAll();
            string[] valuesExtract = new string[10];

            try
            {
                foreach (var mail in emailModelList)
                {
                    //verifica se já foi extraido ou não
                    if (!mail.Integrado)
                    {
                        ArquivoTemporarioService _arquivoTemporario = new ArquivoTemporarioService(mail);
                        var lines = _arquivoTemporario.RetornaLInhas();
                        var indice = _arquivoTemporario.GetIndice(lines);
                        for (int indiceLines = indice.inicio; indiceLines < indice.fim; indiceLines++)
                        {
                            var htmlNodes = ExtractNodes(lines[indiceLines]);


                            int indextExtrat = 0;
                            foreach (var node in htmlNodes)
                            {
                                if (indextExtrat < valuesExtract.Length)
                                {
                                    valuesExtract[indextExtrat] = node.InnerText;
                                    indextExtrat++;

                                }
                                else
                                {

                                    throw new Exception();
                                }
                            }





                            ClienteModel cli = new ClienteModel();
                            cli = PreparaCliente(valuesExtract, mail);
                            if (cli != null && cli.nome != null)
                            {

                                _clienteService.Add(cli);

                            }

                        }
                        _emailRepository.SetarComoIntegrado(mail);
                    }


                }

            }
            catch (Exception e)
            {

                throw new Exception($"ErrorMessage: {e.Message}", e.InnerException);
            }
        }




        public ClienteModel PreparaCliente(string[] valuesExtract, EmailModel mail)
        {
            ClienteModel cliente = new ClienteModel();
            if (!cliente.integrado)
            {

                cliente.nome = valuesExtract[1];
                cliente.codigo = valuesExtract[2];
                cliente.tpDoc = valuesExtract[3].ToString().Length == 23 ? "CPF" : "CNPJ";
                cliente.cgc = cliente.tpDoc.ToString() == "CPF" ? valuesExtract[3].ToString().Substring(3, 11) : valuesExtract[3].ToString().Substring(3, 14);
                cliente.fantasia = valuesExtract[4];
                cliente.fone = valuesExtract[5];
                cliente.cep = int.Parse(valuesExtract[6]);
                string[] endreco = valuesExtract[7].Split(',');
                cliente.logradouro = endreco[0].Trim();
                string[] numero = endreco[1].Split('-');
                cliente.numero = numero[0].Trim();
                cliente.bairro = endreco[2].Trim();
                cliente.cidade = valuesExtract[8];
                cliente.uf = valuesExtract[9];


            }
            return cliente;

        }

        public HtmlNodeCollection ExtractNodes(string line)
        {
            var htmlExtract = new HtmlAgilityPack.HtmlDocument();
            htmlExtract.LoadHtml(line);
            var htmlNodes = htmlExtract.DocumentNode.SelectNodes("//tr//td");
            return htmlNodes;
        }


    }
}
