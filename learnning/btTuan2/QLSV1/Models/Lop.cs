using System.ComponentModel.DataAnnotations;

namespace QLSV1.Models
{
    public class Lop
    {
        [Key]
        public int MaLop { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLop { get; set; }

        // Navigation property
        public ICollection<SinhVien> SinhViens { get; set; }
    }
}
