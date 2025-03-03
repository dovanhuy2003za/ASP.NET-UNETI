using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLSV1.Models;

namespace QLSV1.Data
{
    public class QLSV1Context : DbContext
    {
        public QLSV1Context (DbContextOptions<QLSV1Context> options)
            : base(options)
        {
            SeedData.Initialize(this);
        }

        public DbSet<QLSV1.Models.Lop> Lop { get; set; } = default!;

        public DbSet<QLSV1.Models.SinhVien>? SinhVien { get; set; }
    }
}
