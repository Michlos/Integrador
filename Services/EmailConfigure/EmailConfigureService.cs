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
    public class EmailConfigureService : IEmailConfigureRepository
    {
        private readonly AppDbContext Context= new AppDbContext();
        private readonly EmailConfigureRepository _emailConfigureRepository;
        private readonly EmailConfigureModel _emailConfigureModel;


        public EmailConfigureService(EmailConfigureModel emailConfigureModel)
        {
            _emailConfigureModel = emailConfigureModel;
        }

        public Task AddEmailConfigureAsync(IEmailConfigureModel config)
        {
            throw new NotImplementedException();
        }

        public Task<IEmailConfigureModel> GetEmailConfigureAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmailConfigureAsync(IEmailConfigureModel config)
        {
            throw new NotImplementedException();
        }
    }
}
