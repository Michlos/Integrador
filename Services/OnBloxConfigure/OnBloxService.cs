using Integrador.Domain.OnBloxConfigure;
using Integrador.Repository.OnBloxConfigure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public OnBloxConfigureModel Update(IOnBloxConfigureModel model)
        {
            return _repository.Update(model);
        }
    }
}
