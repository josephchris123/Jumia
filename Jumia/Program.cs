using Jumia.Data;
using Jumia.Models;
using Jumia.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<JumiaContext>
    (
    d => d.UseSqlServer(builder.Configuration.GetConnectionString("Development"))
    );
builder.Services.AddScoped<JumiaContext>();
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<JumiaContext>()
    .AddDefaultTokenProviders();

DependencyInjection.Registration(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
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
