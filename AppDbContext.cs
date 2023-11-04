using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arpagen.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

      
        public DbSet<Morador> Moradores { get; set; }
        public DbSet<Login> Login { get; set; }
        //public DbSet<Consumo> Consumos { get; set; }
       
    }
}
