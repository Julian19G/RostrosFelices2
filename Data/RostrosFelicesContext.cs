using Microsoft.EntityFrameworkCore;
using RostrosFelices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RostrosFelices.Data
{
    internal class RostrosFelicesContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=RostrosEF;Trusted_Connection=True;");

        }
    }

}
