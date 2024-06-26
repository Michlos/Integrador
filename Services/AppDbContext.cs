﻿using Integrador.Domain.Cliente;
using Integrador.Domain.Email;
using Integrador.Domain.EmailConfigure;
using Integrador.Domain.OnBloxConfigure;

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
        public DbSet<EmailConfigureModel> EmailConfigure { get; set; }
        public DbSet<EmailModel> Email { get; set; }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<OnBloxConfigureModel> OnBloxConfigure { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MIKE\\SQLEXPRESS;Initial Catalog=integradorDB;User ID=sa;Password=By2@fi46;Encrypt=False");
        }
    }
}
