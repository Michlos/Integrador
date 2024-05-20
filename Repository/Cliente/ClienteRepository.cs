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
        private readonly AppDbContext _context;
        private ClienteModel cliente;


        public ClienteRepository()
        {
            _context = new AppDbContext();
        }
        public ClienteModel Add(IClienteModel clienteModel)
        {
            cliente = new ClienteModel();
            cliente = clienteModel as ClienteModel;
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }

        public IEnumerable<IClienteModel> GetAll()
        {
            List<ClienteModel> list = new List<ClienteModel>();
            list = _context.Cliente.ToList();
            return list;
        }

        public ClienteModel GetById(int id)
        {
            cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);
            return cliente;
        }
    }
}
