﻿using Integrador.Domain.Email;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Repository.Email
{
    public interface IEmailRepository
    {

        //COMANDOS DE SERVIDOR
        Task<List<IEmailModel>> ReceberEmailTodos(string caixaEmail);
        Task<List<IEmailModel>> ReceberEmailPorAssunto(string caixaEmail, string assunto);
        Task<List<IEmailModel>> ReceberEmailPorAssuntoPorData(string caixaEmail, string assunto, DateTime data);

        //COMANDOS DO BANCO DE DADOS
        Task<List<IEmailModel>> SalvarEmailTodos(List<IEmailModel> emailModelList);

        void Add(IEmailModel model);
        void Update(IEmailModel model);
        void Delete(IEmailModel model);
        void SetarComoIntegrado(IEmailModel comoEnviado);
        void SalvarEmailTodos(List<EmailModel> emailModelList);
    }
}
