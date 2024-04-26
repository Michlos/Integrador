using Integrador.Domain.Email;
using Integrador.Domain.EmailConfigure;
using Integrador.Repository.EmailConfigure;

using Microsoft.EntityFrameworkCore;

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Services.EmailConfigure
{
    public class EmailConfigureService : IEmailConfigureModel
    {
        private readonly AppDbContext Context= new AppDbContext();
        private readonly EmailConfigureRepository _emailConfigureRepository;
        private readonly EmailConfigureModel _emailConfigureModel;


        public EmailConfigureService(EmailConfigureModel emailConfigureModel)
        {
            _emailConfigureModel = emailConfigureModel;
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
