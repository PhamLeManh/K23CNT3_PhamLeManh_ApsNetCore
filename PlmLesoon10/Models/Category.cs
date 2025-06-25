using System.ComponentModel.DataAnnotations;

namespace PlmLesoon10.Models
{
    public class Category
    {
        [Key]
        public int CateId { get; set; }

        [Display(Name = "Tên danh mục")]
        [Required(ErrorMessage = "Tên danh mục không được bỏ trống")]
        public string CateName { get; set; }

        [Display(Name = "Trạng thái")]
        public bool CateStatus { get; set; } // ✅ Sửa từ int ➜ bool
    }
}
