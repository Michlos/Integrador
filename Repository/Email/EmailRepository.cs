using Integrador.Domain.Email;
using Integrador.Services;
using Integrador.Services.Email;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador.Repository.Email
{
    public class EmailRepository : IEmailRepository
    {
        AppDbContext appDbContext = new AppDbContext();

        public EmailRepository(EmailModel model)
        {

        }
        public void Add(IEmailModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEmailModel model)
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

        public Task<List<IEmailModel>> ReceberEmailTodos(string caixaEmail)
        {
            throw new NotImplementedException();
        }

        public Task<List<IEmailModel>> SalvarEmailTodos(List<IEmailModel> emailModelList)
        {
            throw new NotImplementedException();
        }

        public void SalvarEmailTodos(List<EmailModel> emailModelList)
        {
            throw new NotImplementedException();
        }

        public void SetarComoIntegrado(IEmailModel comoEnviado)
        {
            throw new NotImplementedException();
        }

        public void Update(IEmailModel model)
        {
            throw new NotImplementedException();
        }
    }
}
