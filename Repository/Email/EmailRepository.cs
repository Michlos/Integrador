using Integrador.Domain.Email;
using Integrador.Services;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrador.Repository.Email
{
    public class EmailRepository : IEmailRepository
    {
        private readonly AppDbContext _context;
        private EmailModel emailModel;

        public EmailRepository(EmailModel model)
        {
            _context = new AppDbContext();
        }

        //TRATAMENTO DE DADOS NO BANCO DE DADOS
        public EmailModel Add(IEmailModel model)
        {
            emailModel = new EmailModel();
            emailModel = model as EmailModel;
            _context.Email.Add(emailModel);
            return emailModel;
        }


        public EmailModel SetarComoIntegrado(IEmailModel comoEnviado)
        {
            emailModel = new EmailModel();
            emailModel = comoEnviado as EmailModel;
            emailModel.Integrado = true;
            _context.Email.Attach(emailModel);
            _context.Entry(emailModel).State = EntityState.Modified;
            _context.SaveChanges();
            return emailModel;

        }

        public List<EmailModel> GetAll()
        {
            List<EmailModel> list = new List<EmailModel>();
            list = _context.Email.ToList();
            return list;

        }


        //COMANDOS DO SERVIDOR DE E-MAIL
        public Task<List<IEmailModel>> ReceberEmailTodos(string caixaEmail)
        {
            throw new NotImplementedException();
        }
        public Task<List<IEmailModel>> ReceberEmailPorAssunto(string caixaEmail, string assunto)
        {
            throw new NotImplementedException();
        }

        public Task<List<IEmailModel>> ReceberEmailPorAssuntoPorData(string caixaEmail, string assunto, DateTime data)
        {
            throw new NotImplementedException();
        }



    }
}
