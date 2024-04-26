using Integrador.Domain.EmailConfigure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Repository.EmailConfigure
{
    public interface IEmailConfigureRepository
    {
        Task<IEmailConfigureModel> GetEmailConfigureAsync();
        Task AddEmailConfigureAsync(IEmailConfigureModel config);
        Task UpdateEmailConfigureAsync(IEmailConfigureModel config);

    }
}
