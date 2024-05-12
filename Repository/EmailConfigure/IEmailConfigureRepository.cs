using Integrador.Domain.EmailConfigure;

namespace Integrador.Repository.EmailConfigure
{
    public interface IEmailConfigureRepository
    {
        EmailConfigureModel GetEmailConfigure();
        EmailConfigureModel Add(IEmailConfigureModel emailConfigureModel);
        EmailConfigureModel Update(IEmailConfigureModel emailConfigureModel);

    }
}
