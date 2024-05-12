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
        /// <param name="emailConfigureModel"></param>
        /// <returns></returns>
        public EmailConfigureModel Add(IEmailConfigureModel emailConfigureModel)
        {
            return _emailConfigureRepository.Add(emailConfigureModel);  
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
        /// <param name="emailConfigureModel"></param>
        /// <returns></returns>
        public EmailConfigureModel Update(IEmailConfigureModel emailConfigureModel)
        {
            return _emailConfigureRepository.Update(emailConfigureModel);
        }
    }
}
