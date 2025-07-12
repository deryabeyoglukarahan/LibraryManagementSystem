var builder = WebApplication.CreateBuilder(args);

// 1. MVC Servislerini ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 2. Hata ayıklama vs. geliştirme ortamı ayarları (isteğe bağlı)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// 3. wwwroot klasörünü kullanabilmek için
app.UseStaticFiles();

// 4. Routing
app.UseRouting();

// 5. (İsteğe bağlı) Yetkilendirme - şimdilik boş geçiyoruz
app.UseAuthorization();

// 6. Varsayılan yönlendirme ayarı
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
