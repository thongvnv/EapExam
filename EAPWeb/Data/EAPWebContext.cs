using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EAPWeb.Models
{
    public class EAPWebContext : DbContext
    {
        public EAPWebContext (DbContextOptions<EAPWebContext> options)
            : base(options)
        {
        }

        public DbSet<EAPWeb.Models.Employee> Employee { get; set; }
    }
}
