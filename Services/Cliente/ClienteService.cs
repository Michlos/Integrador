using Integrador.Domain.Cliente;
using Integrador.Domain.OnBloxConfigure;
using Integrador.Repository.Cliente;
using Integrador.Repository.OnBloxConfigure;
using Integrador.Services.OnBloxConfigure;

using System.Collections.Generic;

namespace Integrador.Services.Cliente
{
    public class ClienteService : IClienteRepository
    {
        private IClienteRepository _clienteRepository;
        private OnBloxService _onBloxService;
        private OnBloxConfigureModel _onBloxConfigureModel;



        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
            _onBloxService = new OnBloxService(new OnBloxConfigureRepository(new AppDbContext()));
            _onBloxConfigureModel = _onBloxService.GetOnBloxConfigure();
        }
        public ClienteModel Add(IClienteModel clienteModel)
        {

            clienteModel.IdOnBlox = _onBloxService.SetarUltimoIdIntegrado(++_onBloxConfigureModel.ClienteUlimoIdIntegrado);
        
            return _clienteRepository.Add(clienteModel);
        }

        public bool ClienteExists(string codigo)
        {
            return _clienteRepository.ClienteExists(codigo);
        }

        public IEnumerable<IClienteModel> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public ClienteModel GetById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public ClienteModel SetIntegrado(ClienteModel clienteModel)
        {
            return _clienteRepository.SetIntegrado(clienteModel);
        }
    }
}
