using Microsoft.EntityFrameworkCore;
using PhamLeManh_2310900063.Data;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Thêm MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Cấu hình pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/PlmHome/PlmError");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Tuyến mặc định
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PlmHome}/{action=PlmIndex}/{id?}");

app.Run();
