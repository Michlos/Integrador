using Integrador.Domain.OnBloxConfigure;
using Integrador.Repository.OnBloxConfigure;

namespace Integrador.Services.OnBloxConfigure
{
    public class OnBloxService : IOnBloxConfigureRepository
    {
        private IOnBloxConfigureRepository _repository;

        public OnBloxService(IOnBloxConfigureRepository repository)
        {
            _repository = repository;
        }

        public OnBloxConfigureModel Add(IOnBloxConfigureModel model)
        {
            return _repository.Add(model);
        }

        public OnBloxConfigureModel GetOnBloxConfigure()
        {
            return _repository.GetOnBloxConfigure();
        }

        public long SetarUltimoIdIntegrado(long id)
        {
            return _repository.SetarUltimoIdIntegrado(id);
        }

        public OnBloxConfigureModel Update(IOnBloxConfigureModel model)
        {
            return _repository.Update(model);
        }
    }
}
