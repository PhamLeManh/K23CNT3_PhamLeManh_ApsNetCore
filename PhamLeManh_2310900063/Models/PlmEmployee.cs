using System.ComponentModel.DataAnnotations;

namespace PhamLeManh_2310900063.Models
{
    public class PlmEmployee
    {
        [Key]
        public int PlmEmpId { get; set; }

        [Display(Name = "Họ tên")]
        [Required]
        public string? PlmEmpName { get; set; }

        [Display(Name = "Cấp bậc")]
        public string? PlmEmpLevel { get; set; }

        [Display(Name = "Ngày bắt đầu")]
        [DataType(DataType.Date)]
        public DateTime PlmEmpStartDate { get; set; }

        [Display(Name = "Trạng thái làm việc")]
        public bool PlmEmpStatus { get; set; }
    }
}
