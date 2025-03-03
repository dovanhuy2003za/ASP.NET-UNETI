using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qlsv.Models
{
    public class SinhVien
    {
        [Key]
        public int MaSinhVien { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSinhVien { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        public Boolean GioiTinh { get; set; }

        [ForeignKey("Lop")]
        public int MaLop { get; set; }

        // Navigation property
        public Lop Lop { get; set; }
    }
}
