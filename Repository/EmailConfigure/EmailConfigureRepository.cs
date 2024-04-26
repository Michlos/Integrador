using Integrador.Domain.EmailConfigure;
using Integrador.Services;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Repository.EmailConfigure
{
    internal class EmailConfigureRepository : IEmailConfigureRepository
    {
        private readonly AppDbContext _context;
        public EmailConfigureRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddEmailConfigureAsync(IEmailConfigureModel config)
        {
            _context.EmailConfigure.Add((EmailConfigureModel)config);
            await _context.SaveChangesAsync();
        }

        public async Task<IEmailConfigureModel> GetEmailConfigureAsync(AppDbContext context)
        {
            EmailConfigureModel emailConfigureModel = await _context.EmailConfigure.FirstOrDefaultAsync();

            return (IEmailConfigureModel)(emailConfigureModel == null ? null : emailConfigureModel);
            //return emailConfigure ?? new EmailConfigureModel();
        }

        public async Task<IEmailConfigureModel> GetEmailConfigureAsync()
        {
            EmailConfigureModel emailConfigureModel = await _context.EmailConfigure.FirstOrDefaultAsync<EmailConfigureModel>();
            return (IEmailConfigureModel)(emailConfigureModel == null ? null : emailConfigureModel);
        }

        public async Task UpdateEmailConfigureAsync(IEmailConfigureModel config)
        {
            _context.Entry(config).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
