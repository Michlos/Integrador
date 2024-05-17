using Integrador.Domain.OnBloxConfigure;
using Integrador.Services;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Repository.OnBloxConfigure
{
    public class OnBloxConfigureRepository : IOnBloxConfigureRepository
    {
        private readonly AppDbContext _context;
        public OnBloxConfigureRepository()
        {
            _context = new AppDbContext();
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
    }
}
