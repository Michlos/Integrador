using Integrador.Domain.Email;
using Integrador.Domain.EmailConfigure;

using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Services.Email
{
    public class EmailService : IEmailConfigureModel
    {
        private ImapClient _imapClient = new ImapClient();
        private readonly EmailConfigureModel _emailConfigureModel;
        public EmailService(EmailConfigureModel emailConfigureModel)
        {
            _emailConfigureModel = emailConfigureModel;
                
        }


        private void ConnectHost()
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
        public string GetEmail()
        {
            return _emailConfigureModel.Email;
        }

        public int GetEntradaPorta()
        {
            return _emailConfigureModel.EntradaPorta;
        }

        public string GetEntradaServer()
        {
            return _emailConfigureModel.EntradaServer;
        }

        public int GetId()
        {
            return _emailConfigureModel.Id;
        }

        public string GetSenha()
        {
            return _emailConfigureModel.Senha;
        }

        public int GetSmtpPorta()
        {
            return _emailConfigureModel.SmtpPorta;
        }

        public string GetSmtpServer()
        {
            return _emailConfigureModel.SmtpServer;
        }

        public bool GetSslEntradaHabilitado()
        {
            return _emailConfigureModel.SslEntradaHabilitado;
        }

        public bool GetSslSaidaHabilitado()
        {
            return _emailConfigureModel.SslSaidaHabilitado;
        }
    }
}
