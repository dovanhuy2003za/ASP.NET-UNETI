using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using qlsv.Models;

namespace qlsv.Data
{
    public class qlsvContext : DbContext
    {
        public qlsvContext (DbContextOptions<qlsvContext> options)
            : base(options)
        {
        }

        public DbSet<qlsv.Models.SinhVien> SinhVien { get; set; } = default!;

        public DbSet<qlsv.Models.Lop>? Lop { get; set; }
    }
}
