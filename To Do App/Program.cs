using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;

var builder = WebApplication.CreateBuilder(args);

// I chose to add services to the container here.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext <TodoDbContext>(Options =>
{
    Options.UseSqlite($"Data Source=mydb.db;");
});

var app = builder.Build();

// Configuration o the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
