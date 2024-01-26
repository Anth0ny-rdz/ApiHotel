using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tuki.Controllers.Models;

namespace tuki.Data
{
    public class tukiContext : DbContext
    {
        public tukiContext (DbContextOptions<tukiContext> options)
            : base(options)
        {
        }

        public DbSet<tuki.Controllers.Models.Empleado> Empleado { get; set; } = default!;

        public DbSet<tuki.Controllers.Models.Sede>? Sede { get; set; }
    }
}
