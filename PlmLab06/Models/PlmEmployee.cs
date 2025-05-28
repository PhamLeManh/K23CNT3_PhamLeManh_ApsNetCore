using System.ComponentModel.DataAnnotations;

namespace PlmLab06.Models
{
    public class PlmEmployee
    {
        [Key]
        public int PlmId { get; set; }

        [Required]
        [Display(Name = "Họ và Tên")]
        public string PlmName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày Sinh")]
        public DateTime PlmBirthDay { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string PlmEmail { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Số Điện Thoại")]
        public string PlmPhone { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Lương phải lớn hơn 0")]
        [Display(Name = "Lương")]
        public double PlmSalary { get; set; }

        [Display(Name = "Trạng Thái")]
        public bool PlmStatus { get; set; }
    }
}
