using Intern_Admin_Collaboration.Data;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

//using Intern Admin Collaboration.Data;

//good job

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Addcontext>(ob =>
{
    ob.UseSqlServer(builder.Configuration.GetConnectionString("con"));  //to register connection string
});

builder.Services.AddDbContext<approvedcontext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("con"));  //to register connection string
});

builder.Services.AddDbContext<Dashcontext>(obdash =>
{
    obdash.UseSqlServer(builder.Configuration.GetConnectionString("con"));  //to register connection string
});


builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/Access/Login";
        option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
    });

//builder.Services.AddDbContext<internadmin>(o =>
//{
//    o.UseSqlServer(builder.Configuration.GetConnectionString("con"));  //to register connection string
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Access}/{action=Login}/{id?}");

app.Run();
