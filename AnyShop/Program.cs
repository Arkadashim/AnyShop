using AnyShop.Interfaces;
using AnyShop.Mocks;

var builder = WebApplication.CreateBuilder(args);

// add mvc
builder.Services.AddControllersWithViews();
// add interfaces
builder.Services.AddTransient<IAllCars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseExceptionHandler("/Home/Error");

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
