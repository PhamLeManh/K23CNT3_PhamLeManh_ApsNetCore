using System;
using System.ComponentModel.DataAnnotations;

public class Account
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Họ không được để trống")]
    public string HoVaTen { get; set; }

    [Required(ErrorMessage = "Địa chỉ Email không được để trống")]
    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Số điện thoại không được để trống")]
    [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
    public string SoDienThoai { get; set; }

    [Required(ErrorMessage = "Địa chỉ không được để trống")]
    public string DiaChiThuongTru { get; set; }

    [Required(ErrorMessage = "The Ảnh đại diện field is required.")]
    public string AnhDaiDien { get; set; }

    [Required(ErrorMessage = "The Giới tính field is required.")]
    public string GioiTinh { get; set; }

    [Required(ErrorMessage = "The Mật khẩu field is required.")]
    [DataType(DataType.Password)]
    public string MatKhau { get; set; }

    [Required(ErrorMessage = "Link Facebook không được để trống")]
    [Url(ErrorMessage = "Link không hợp lệ")]
    public string LinkFacebook { get; set; }

    public DateTime NgaySinh { get; set; } = DateTime.Now;
}
