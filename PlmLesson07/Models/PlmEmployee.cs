using System;
using System.ComponentModel.DataAnnotations;

namespace PlmLesson07.Models
{
    public class PlmEmployee
    {
        public int PlmId { get; set; }

        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [Display(Name = "Họ và tên")]
        public string PlmName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        public DateTime PlmBirthDay { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string PlmEmail { get; set; }

        [Phone]
        [Display(Name = "Số điện thoại")]
        public string PlmPhone { get; set; }

        [Range(0, 999999999)]
        [Display(Name = "Lương")]
        public decimal PlmSalary { get; set; }

        [Display(Name = "Trạng thái")]
        public bool PlmStatus { get; set; }
    }
}
