using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BO;

    public class DojoContext : DbContext
    {
        public DojoContext (DbContextOptions<DojoContext> options)
            : base(options)
        {
        }

        public DbSet<BO.Arme> Arme { get; set; } = default!;

        public DbSet<BO.Samourai>? Samourai { get; set; }
    }
