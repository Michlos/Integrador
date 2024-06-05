using Integrador.Domain.EmailConfigure;
using Integrador.Services;

using Microsoft.EntityFrameworkCore;

using System.Linq;

namespace Integrador.Repository.EmailConfigure
{
    public class EmailConfigureRepository : IEmailConfigureRepository
    {
        private readonly AppDbContext _context;

        public EmailConfigureRepository(AppDbContext context)
        {
            _context = context;
        }

        public EmailConfigureModel Add(IEmailConfigureModel configure)
        {

            var emailConfigureModel = configure as EmailConfigureModel;
            _context.EmailConfigure.Add(emailConfigureModel);
            _context.SaveChanges();
            return emailConfigureModel;
        }

        public EmailConfigureModel GetEmailConfigure()
        {
            return _context.EmailConfigure.FirstOrDefault();
        }

        public EmailConfigureModel Update(IEmailConfigureModel configure)
        {
            var emailConfigureModel = configure as EmailConfigureModel;
            _context.Entry(emailConfigureModel).State = EntityState.Modified;
            _context.SaveChanges();
            return emailConfigureModel;

        }
    }
}
