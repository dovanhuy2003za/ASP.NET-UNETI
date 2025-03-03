using Microsoft.EntityFrameworkCore;
using QLSV1.Data;

namespace QLSV1.Models
{
    public class SeedData
    {
        public static void Initialize(QLSV1Context context)
        {
            
                // Look for any Lop.
                if (context.Lop.Any())
                {
                    return;   // DB has been seeded
                }

                context.Lop.AddRange(
                    new Lop
                    {
                        TenLop = "DHTI15A10HN"
                    },
                    new Lop
                    {
                        TenLop = "DHTI15A14HN"
                    }
                );

                context.SaveChanges();

                // Look for any SinhVien.
                if (context.SinhVien.Any())
                {
                    return;   // DB has been seeded
                }

                context.SinhVien.AddRange(
                    new SinhVien
                    {
                        TenSinhVien = "Do Van Huy",
                        NgaySinh = new DateTime(2003, 2, 28),
                        GioiTinh = true,
                        MaLop = context.Lop.First().MaLop
                    },
                    new SinhVien
                    {
                        TenSinhVien = "Nguyen Duy Anh",
                        NgaySinh = new DateTime(2003, 12, 12),
                        GioiTinh = true,
                        MaLop = context.Lop.OrderBy(l => l.MaLop).Last().MaLop
                    }
                );

                context.SaveChanges();
            
        }
    }
}
