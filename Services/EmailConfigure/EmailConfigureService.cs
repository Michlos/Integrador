using Integrador.Domain.EmailConfigure;
using Integrador.Repository.EmailConfigure;

namespace Integrador.Services.EmailConfigure
{
    public class EmailConfigureService : IEmailConfigureRepository
    {
        private IEmailConfigureRepository _emailConfigureRepository;

        public EmailConfigureService(IEmailConfigureRepository emailConfigureRepository)
        {
            _emailConfigureRepository = emailConfigureRepository;
        }


        /// <summary>
        /// Adiciona a nova configuração de e-mail
        /// </summary>
        /// <param name="emailConfigureRepository"></param>
        /// <returns></returns>
        public EmailConfigureModel Add(IEmailConfigureModel emailConfigureRepository)
        {
            return _emailConfigureRepository.Add(emailConfigureRepository);  
        }

        /// <summary>
        /// Busca a atual configuração do e-mail
        /// </summary>
        /// <returns></returns>
        public EmailConfigureModel GetEmailConfigure()
        {
            return _emailConfigureRepository.GetEmailConfigure();
        }


        /// <summary>
        /// Atualiza a atual configuração do e-mail existente
        /// </summary>
        /// <param name="emailConfigureRepository"></param>
        /// <returns></returns>
        public EmailConfigureModel Update(IEmailConfigureModel emailConfigureRepository)
        {
            return _emailConfigureRepository.Update(emailConfigureRepository);
        }
    }
}
