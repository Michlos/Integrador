using Integrador.Domain.EmailConfigure;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Services
{
    public class AppDbContext : DbContext
    {
        public DbSet<EmailConfigureModel> EmailConfigs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MIKE\\SQLEXPRESS;Initial Catalog=integradorDB;User ID=sa;Encrypt=False");
        }
    }
}
