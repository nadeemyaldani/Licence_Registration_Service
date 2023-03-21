using APlus.Data.BLL;
using APlus.Data.Entity;
using APlus.Data.Model;
using Blazorise;
using Blazorise.Bootstrap;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<EntityDBContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("DbCoreConnectionString")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
        options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<EntityDBContext>();

builder.Services.AddTransient<SubscriptionBLL>();
builder.Services.AddTransient<UserBLL>();
builder.Services.AddTransient<PlanBLL>();

builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrapProviders();

builder.Services.AddAuthentication("Identity.Application").AddCookie();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");


app.Run();
