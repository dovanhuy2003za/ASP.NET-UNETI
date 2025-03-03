using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using btTuan2.Models;

namespace btTuan2.Data
{
    public class MVCmovieContext : DbContext
    {
        public MVCmovieContext (DbContextOptions<MVCmovieContext> options)
            : base(options)
        {
            SeedData.Initialize(this);
        }

        public DbSet<btTuan2.Models.Movie> Movie { get; set; } = default!;
    }
}
