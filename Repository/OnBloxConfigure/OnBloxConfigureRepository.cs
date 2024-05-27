using Integrador.Domain.OnBloxConfigure;
using Integrador.Services;

using Microsoft.EntityFrameworkCore;

using System.Linq;

namespace Integrador.Repository.OnBloxConfigure
{
    public class OnBloxConfigureRepository : IOnBloxConfigureRepository
    {
        private readonly AppDbContext _context;
        public OnBloxConfigureRepository(AppDbContext context)
        {
            _context = context;
        }

        public OnBloxConfigureModel Add(IOnBloxConfigureModel model)
        {
            var onbloxConfigureModel = model as OnBloxConfigureModel;
            _context.OnBloxConfigure.Add(onbloxConfigureModel);
            _context.SaveChanges();
            return onbloxConfigureModel;
        }

        public OnBloxConfigureModel GetOnBloxConfigure()
        {
            return _context.OnBloxConfigure.FirstOrDefault();
        }

        public OnBloxConfigureModel Update(IOnBloxConfigureModel model)
        {
            var onbloxConfigureModel = model as OnBloxConfigureModel;
            _context.Entry(onbloxConfigureModel).State = EntityState.Modified;
            _context.SaveChanges();
            return onbloxConfigureModel;
        }

        public long SetarUltimoIdIntegrado(long id)
        {
            OnBloxConfigureModel model = _context.OnBloxConfigure.FirstOrDefault();
            model.ClienteUlimoIdIntegrado = id;
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return id;
        }
    }
}
