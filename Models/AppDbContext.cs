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
        public DbSet<Login> Logins { get; set; }
        public DbSet<Visitante> Visitantes{ get; set; }
        public DbSet<AreaComum> AreasComum { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }


    }
}
