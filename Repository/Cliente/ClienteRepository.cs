using Integrador.Domain.Cliente;
using Integrador.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Repository.Cliente
{
    public class ClienteRepository : IClienteRepository
    {
        private AppDbContext context;
        private ClienteModel cliente;


        public ClienteRepository()
        {
            context = new AppDbContext();
        }
        public ClienteModel Add(IClienteModel clienteModel)
        {
            cliente = new ClienteModel();
            cliente = clienteModel as ClienteModel;
            context.Cliente.Add(cliente);
            return cliente;
        }

        public IEnumerable<IClienteModel> GetAll()
        {
            List<ClienteModel> list = new List<ClienteModel>();
            list = context.Cliente.ToList();
            return list;
        }

        public ClienteModel GetById(int id)
        {
            cliente = context.Cliente.FirstOrDefault(x => x.Id == id);
            return cliente;
        }
    }
}
