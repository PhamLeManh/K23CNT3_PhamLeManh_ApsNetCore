using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TEST.Controllers
{
    public class PlmProductController : Controller
    {
        public IActionResult DoNu()
        {
            var products = new List<ProductViewModel>
            {
                new ProductViewModel { Id = 1, Name = "Nike - Váy thể thao nữ", Price = 500000, ImageUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/eb99da5d-e893-441b-9e0c-62e1502fc806/AS+W+NSW+NK+CHLL+KNT+RIB+MINI.png" },
                new ProductViewModel { Id = 2, Name = "Nike - Áo nữ", Price = 300000, ImageUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/7f5e7f97-d517-4104-bfa8-207c73543e32/AS+W+NSW+NK+CHLL+FT+MR+4%22+AOP.png" },
                new ProductViewModel { Id = 3, Name = "Nike - Váy ngắn nữ", Price = 400000, ImageUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/67ffb846-acbc-439f-9f10-88c8147f85bf/AS+W+NSW+NK+CHLL+FT+MR+MINI+SK.png" },
            };
            ViewData["CategoryTitle"] = "ĐỒ NỮ";
            return View("ProductList", products);
        }

        public IActionResult DoNam()
        {
            var products = new List<ProductViewModel>
            {
                new ProductViewModel { Id = 4, Name = "Nike - Áo thể thao nam", Price = 550000, ImageUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/4be0177c-881a-473b-b5c6-965f626a6a9f/M+J+DF+SPRT+SS+TOP.png" },
                new ProductViewModel { Id = 5, Name = "Nike - Quần short nam", Price = 350000, ImageUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/06670cb6-fde4-4d6d-90e0-633f6b273734/M+J+JD+SPRT+BRND+DF+SS+CREW.png" },
                new ProductViewModel { Id = 6, Name = "Nike - Áo Hoodie nam", Price = 750000, ImageUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/4f81e90a-b598-4b06-9c92-9365bb6426dc/M+J+DF+SPRT+SLVLS+TOP.png" },
            };
            ViewData["CategoryTitle"] = "ĐỒ NAM";
            return View("ProductList", products);
        }

        public IActionResult TrangSuc()
        {
            var products = new List<ProductViewModel>
            {
                new ProductViewModel { Id = 7, Name = "Nike - Vòng tay nữ thể thao", Price = 200000, ImageUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/1fdce1db-6797-4dfb-86c8-45f31d639b37/NK+UTILITY+M+POWER+DUFF+-+2.0.png" },
                new ProductViewModel { Id = 8, Name = "Nike - Dây chuyền nữ", Price = 1200000, ImageUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/146a66b9-5475-4d3e-9819-1c3acc5afa01/NK+AURA+WAISTPACK.png" },
                new ProductViewModel { Id = 9, Name = "Nike - Nhẫn nữ đá đen", Price = 950000, ImageUrl = "https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/770d9331-01f1-488a-be7a-a0f89a752224/NK+BRSLA+M+BKPK+-+9.5+%2824L%29.png" },
            };
            ViewData["CategoryTitle"] = "TRANG SỨC";
            return View("ProductList", products);
        }

        public IActionResult DongHo()
        {
            var products = new List<ProductViewModel>
            {
                new ProductViewModel { Id = 10, Name = "Nike - Đồng hồ nam Casio", Price = 890000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiEYep7M1910NDhDjIYBE772Kqax2GCRuNhXSqWd3ZxJJiPm0BlXsIn6_ZjtO5SsJYwnI&usqp=CAU" },
                new ProductViewModel { Id = 11, Name = "Nike - Đồng hồ nữ Rolex", Price = 25000000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiEYep7M1910NDhDjIYBE772Kqax2GCRuNhXSqWd3ZxJJiPm0BlXsIn6_ZjtO5SsJYwnI&usqp=CAU" },
                new ProductViewModel { Id = 12, Name = "Nike - Đồng hồ thể thao Seiko", Price = 3100000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiEYep7M1910NDhDjIYBE772Kqax2GCRuNhXSqWd3ZxJJiPm0BlXsIn6_ZjtO5SsJYwnI&usqp=CAU" },
            };
            ViewData["CategoryTitle"] = "ĐỒNG HỒ";
            return View("ProductList", products);
        }
    }

    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
