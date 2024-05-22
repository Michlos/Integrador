using Integrador.Domain.Cliente;
using Integrador.Repository.Cliente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Services.Cliente
{
    public class ClienteService : IClienteRepository
    {
        private IClienteRepository _clienteRepository;



        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public ClienteModel Add(IClienteModel clienteModel)
        {
            return _clienteRepository.Add(clienteModel);
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
