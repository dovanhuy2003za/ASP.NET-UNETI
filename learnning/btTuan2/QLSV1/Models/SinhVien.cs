using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLSV1.Models
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
