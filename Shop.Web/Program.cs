using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Context;
using ShopApp.DAL.Daos;
using ShopApp.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//registrar el contexto//

builder.Services.AddDbContext<ShopAppContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("ShopAppContext")));

builder.Services.AddScoped<ICategoriesDb, CategoryDao>();


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
