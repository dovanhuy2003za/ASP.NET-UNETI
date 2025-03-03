using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace qlsv.Models
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
