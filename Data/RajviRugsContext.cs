using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RajviRugs.Models;

namespace RajviRugs.Data
{
    public class RajviRugsContext : DbContext
    {
        public RajviRugsContext (DbContextOptions<RajviRugsContext> options)
            : base(options)
        {
        }

        public DbSet<RajviRugs.Models.Rugs> Rugs { get; set; }
    }
}
