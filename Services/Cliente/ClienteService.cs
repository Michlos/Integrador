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
        private readonly IClienteRepository _clienteRepository;
        private readonly OnBloxService _onBloxService;
        private readonly OnBloxConfigureModel _onBloxConfigureModel;



        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
            _onBloxService = new OnBloxService(new OnBloxConfigureRepository(new AppDbContext()));
            _onBloxConfigureModel = _onBloxService.GetOnBloxConfigure();
        }
        public ClienteModel Add(IClienteModel clienteModel)
        {

            if (_clienteRepository.ClienteExists(clienteModel.codigo))
            {
                return null;
            }
            //clienteModel.IdOnBlox = _onBloxService.SetarUltimoIdIntegrado(++_onBloxConfigureModel.ClienteUlimoIdIntegrado);
        
            return _clienteRepository.Add(clienteModel);
        }

        public bool ClienteExists(string codigo)
        {
            return _clienteRepository.ClienteExists(codigo);
        }

        public ClienteModel GetByCodigo(string codigo)
        {
            return    _clienteRepository.GetByCodigo(codigo);
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
