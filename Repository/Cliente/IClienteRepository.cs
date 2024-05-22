using Integrador.Domain.Cliente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Repository.Cliente
{
    public interface IClienteRepository
    {
        ClienteModel Add(IClienteModel clienteModel);
        IEnumerable<IClienteModel> GetAll();

        ClienteModel GetById(int id);
        ClienteModel SetIntegrado(ClienteModel clienteModel);
    }
}
